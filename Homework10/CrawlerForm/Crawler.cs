using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CrawlerForm
{
    public class Crawler
    {
        public ConcurrentDictionary<string,bool> Urls { get; set; }
        public string StartUrl { get; set; }
        public int Count { get; set; }
        public event InformEventHandler Inform;

        private Task[] tasks = new Task[10];

        public Crawler()
        {
            Urls =new ConcurrentDictionary<string,bool>();
            Count = 0;
        }

        //普通模式启动
        public void Start()
        {
            if(Urls.TryAdd(StartUrl, false) == false)
            {
                Inform(this, new InformEventArgs() { Url = StartUrl, Message = "已存在" });
            }

            Inform(this, new InformEventArgs() { Url = null, Message = "开始爬取" });
            while (Count < 10)
            {
                string currentUrl = null;
                foreach (string url in Urls.Keys)
                {
                    if ((bool)Urls[url])
                        continue;
                    currentUrl = url;
                }

                if (currentUrl == null)
                    break;

                string html = Download(currentUrl);
                Urls[currentUrl] = true;
                Count++;
                Parse(html, currentUrl);
            }
            Inform(this, new InformEventArgs() { Url = null, Message = "结束爬取" });
        }

        //并行模式启动
        public void StartParallel()
        {
            if(Urls.TryAdd(StartUrl, false)==false){
                Inform(this, new InformEventArgs() { Url = StartUrl, Message = "已存在" });
            }

            Inform(this, new InformEventArgs() { Url = null, Message = "开始爬取" });
            while (Count<10)
            {
                string currentUrl = null;
                foreach(string url in Urls.Keys)
                {
                    if ((bool)Urls[url])
                        continue;
                    currentUrl = url;
                }

                if (currentUrl!=null)
                {
                    Urls[currentUrl] = true;
                    ++Count;
                    Task task=Task.Run(() => {
                        string html = Download(currentUrl);
                        Parse(html, currentUrl);
                    });
                    tasks[Count - 1] = task;
                }
            }
            Task.WaitAll(tasks);
            Inform(this, new InformEventArgs() { Url = null, Message = "结束爬取" });
        }

        //下载
        public string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = Count.ToString();
                File.WriteAllText(DateTime.Now.ToFileTimeUtc().ToString(), html, Encoding.UTF8);            //系统时间作为文件名，避免多线程数据争用
                Inform(this,new InformEventArgs() { Url = url, Message = "成功" });
                return html;
            }
            catch (Exception ex)
            {
                Inform(this, new InformEventArgs() { Url = url, Message = ex.Message });
                return "";
            }
        }

        //解析
        private void Parse(string html,string currentUrl)
        {
            //匹配html
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(.html|.HTML)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0)
                {
                    continue;
                }

                //主域名
                Uri uri = new Uri(currentUrl);
                string domain = uri.Scheme+ "://" + uri.Host;

                //相对地址转为绝对地址
                if(Regex.IsMatch(strRef, "^[//]"))
                {
                    strRef = uri.Scheme + strRef;                               //以“//”开头的相对地址转换为绝对地址
                }
                else if (Regex.IsMatch(strRef, "^[/]"))                              
                {
                    strRef = domain + strRef;                                   //以“/”开头的相对地址转换为绝对地址
                }
                else if(Regex.IsMatch(strRef, "^(http|HTTP|https|HTTPS)") == false)
                {
                    strRef = currentUrl + "/" + strRef;                         //不以“/”开头的相对地址转换为绝对地址
                }

                if (Regex.IsMatch(strRef, domain) ==false)                      //除去非本网站的网址                     
                    continue;

                Urls.TryAdd(strRef, false);                                     //添加新网址
            }
        }
    }


    public delegate void InformEventHandler(object o,InformEventArgs e);

    public class InformEventArgs : EventArgs
    {
        public string Url { get; set; }
        public string Message { get; set; }
    }
}
