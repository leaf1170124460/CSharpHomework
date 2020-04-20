using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrawlerForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Crawler Crawler { get; set; }
        public Crawler CrawlerParallel { get; set; }
        public string StartUrl { get; set; }

        public Form()
        {
            InitializeComponent();
            Crawler = new Crawler();
            CrawlerParallel = new Crawler();
            Crawler.Inform += CrawlerInform;
            CrawlerParallel.Inform += CrawlerInformParallel;
            txtUrl.DataBindings.Add("Text", this, "StartUrl");
            StartUrl = "https://www.cnblogs.com/dstang2000/";
        }

        //普通模式更新界面
        private void CrawlerInform(object o, InformEventArgs e)
        {
            //以线程安全方式更新界面
            if (lsbMain.InvokeRequired)
            {
                Action<InformEventArgs> action = AddResult;
                this.Invoke(action, e);
            }else
            {
                AddResult(e);
            }
        }

        //并行模式更行界面
        private void CrawlerInformParallel(object o, InformEventArgs e)
        {
            //以线程安全方式更新界面
            if (lsbParallel.InvokeRequired)
            {
                Action<InformEventArgs> action = AddResultParallel;
                this.Invoke(action, e);
            }
            else
            {
                AddResultParallel(e);
            }
        }

        //普通模式增加结果
        private void AddResult(InformEventArgs e)
        {
            if (e.Url == null)
            {
                lsbMain.Items.Add(e.Message);
            }
            else
            {
                lsbMain.Items.Add("正在爬取：" + e.Url + "\t状态为：" + e.Message);
            }
        }

        //并行模式增加结果
        private void AddResultParallel(InformEventArgs e)
        {
            if (e.Url == null)
            {
                lsbParallel.Items.Add(e.Message);
            }
            else
            {
                lsbParallel.Items.Add("正在爬取：" + e.Url + "\t状态为：" + e.Message);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //初始化
            lsbMain.Items.Clear();
            lsbParallel.Items.Clear();
            Crawler.Urls.Clear();
            CrawlerParallel.Urls.Clear();
            Crawler.Count = 0;
            CrawlerParallel.Count = 0;
            Crawler.StartUrl = StartUrl;
            CrawlerParallel.StartUrl = StartUrl;

            //启动
            Thread thread = new Thread(Crawler.Start);
            Thread threadParallel = new Thread(CrawlerParallel.StartParallel);
            thread.Start();
            threadParallel.Start();
        }
    }
}
