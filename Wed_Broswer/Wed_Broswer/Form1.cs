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
using EasyTabs;

namespace Wed_Broswer
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser chromeBrowser;

        protected TitleBarTabs ParentTabs

        {

            get

            {

                return (ParentForm as TitleBarTabs);

            }

        }


        public Form1()
        {
            InitializeComponent();
            InitializeChrome(); 
        }

        private void InitializeChrome()
        {
            try
            {
                CefSettings settings = new CefSettings();
                Cef.Initialize(settings);
            }
            catch (Exception) { }
            chromeBrowser = new ChromiumWebBrowser("https://www.google.com/search?q=");
            this.Panel.Controls.Add(chromeBrowser);

        }
      
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //std
        }


        private void BackArrow_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Back();
        }

        private void ForwardArrow_Click_1(object sender, EventArgs e)
        {
            chromeBrowser.Forward();
        }

        private void RefreshArrow_Click(object sender, EventArgs e)
        {
            chromeBrowser.Reload();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            chromeBrowser.Load("https://www.google.com/search?q=");
        }

        private void URL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chromeBrowser.Load("https://www.google.com/search?q=" + URL.Text);
                Text = URL.Text;
            }
        }
    }
}
