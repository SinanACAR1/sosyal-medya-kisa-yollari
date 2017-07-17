using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bazı_Sosyal_Medya_kısaYolları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://www.facebook.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Facebook";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://twitter.com/");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Twitter";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://accounts.google.com/ServiceLogin?service=mail&passive=true&rm=false&continue=https://mail.google.com/mail/&ss=1&scc=1&ltmpl=default&ltmplcache=2&emr=1&osid=1#identifier");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Gmail";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://www.microsoft.com/tr-tr/outlook-com/?cb=v8ho");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Outlook";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("https://login.live.com/tr");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Microsoft";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            f2.webBrowser1.Navigate("http://www.msn.com/tr-tr");
            f2.webBrowser1.ScriptErrorsSuppressed = true;
            f2.Text = "Msn";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
