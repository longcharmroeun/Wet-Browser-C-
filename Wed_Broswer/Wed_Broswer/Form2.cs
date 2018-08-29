using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using CefSharp;

namespace Wed_Broswer
{
    public partial class Form2 : TitleBarTabs
    {
        public Form2()
        {

            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }


        public override TitleBarTab CreateTab()

        {

            return new TitleBarTab(this)

            {

                Content = new Form1

                {

                    Text = "New Tab"

                }

            };

        }
        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
