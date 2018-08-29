using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;

namespace Wed_Broswer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form2 testApp = new Form2();



            testApp.Tabs.Add(

                new TitleBarTab(testApp)

                {

                    Content = new Form1

                    {

                        Text = "New Tab"

                    }

                });

            testApp.SelectedTabIndex = 0;



            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();

            applicationContext.Start(testApp);



            Application.Run(applicationContext);
        }
    }
}
