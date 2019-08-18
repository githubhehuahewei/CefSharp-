using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace CefSharp浏览器
{
    public partial class Form1 : Form
    {
        ChromiumWebBrowser chromeBrowser;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chromeBrowser = new ChromiumWebBrowser(textBox1.Text);

            panel1.Controls.Add(chromeBrowser);
        }
    }
}
