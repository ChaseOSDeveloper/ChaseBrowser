using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace ChaseBrowser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeLifetimeService();
            AeroPeekEnabled = true;
            Cef.Initialize(new CefSettings());
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
    }
}
