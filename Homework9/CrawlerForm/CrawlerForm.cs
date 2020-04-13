using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form()
        {
            InitializeComponent();
            Crawler = new Crawler();
            Crawler.Inform += Crawler_PageDownloaded;
            txtUrl.DataBindings.Add("Text", Crawler, "StartUrl");
        }

        private void Crawler_PageDownloaded(object o, InformEventArgs e)
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

        private void btnStart_Click(object sender, EventArgs e)
        {
            lsbMain.Items.Clear();
            new Thread(Crawler.Start).Start();
        }
    }
}
