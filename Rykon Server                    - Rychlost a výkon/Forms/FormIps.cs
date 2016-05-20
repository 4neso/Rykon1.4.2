using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RykonServer.Forms
{
    public partial class FormIps : Form
    {
        public FormIps()
        {
            InitializeComponent();
        }

        private void linkLabelcopyip_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (textBox1.Text.Length >0)
                Clipboard.SetText(textBox1.Text);
        }

        private void linkLabel_GetIp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetIp();
        }

        private void ResetIp()
        {
            try
            {

                textBox1.Text = "";
                var req = (HttpWebRequest)WebRequest.Create("http://canyouseeme.org");
                var resp = (HttpWebResponse)req.GetResponse();
                string x = new StreamReader(resp.GetResponseStream()).ReadToEnd();
                //  input type="hidden" name="IP" value="41.238.175.7"/>
                string[] sepd = x.Split(new char[] { '<' });
                foreach (string s in sepd)
                    if (s.Contains("input type=\"hidden\" name=\"IP\""))
                    {
                        string[] spdbyspace = s.Split(new char[] { ' ' });
                        foreach (string sen in spdbyspace)
                            if (sen.Contains("value"))
                            {
                                string[] spd_by_qoute = sen.Split(new char[] { '"' });
                                this.CurrentExIp = spd_by_qoute[1];
                                textBox1.Text = this.CurrentExIp;

                                this.ExIpDetetected = true;
                                return;
                            }
                    }
            }
            catch
            {
            }
        }

        public string CurrentExIp = "";//{ get; set; }
        public bool ExIpDetetected = false;

        private void FormIps_Load(object sender, EventArgs e)
        {
            ResetIp();
            ResetIpLoc();
        }

        private void ResetIpLoc()
        {
            richTextBox1.Text = "";
            foreach(var p in this.locips)
                richTextBox1.Text += (space(p.Item2)+" - "+p.Item1+"\r\n");
        }

        private string space(string p)
        {
            string x = "";
            for(int i =0;i<(15-p.Length);i++)
            {
                x += " ";
            }
            return p +" "+ x;
        }
        public List<Tuple<string, string>> locips = new List<Tuple<string, string>>();
    }
}
