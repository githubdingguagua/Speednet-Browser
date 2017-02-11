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
using DevComponents.DotNetBar;

namespace ChromiumTest
{
    public partial class Form1 : Office2007Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeChromium();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            ChromiumWebBrowser chromeBrowser = new ChromiumWebBrowser(Properties.Settings.Default.Homepage);
            chromeBrowser.Parent = tabControl.SelectedTab;
            chromeBrowser.Dock = DockStyle.Fill;
            chromeBrowser.AddressChanged += Chrome_AddressChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
        }

        private void Chrome_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(()=>
            {
                textBox1.Text = e.Address;
            }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromeBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chromeBrowser != null)
                if (chromeBrowser.CanGoBack)
            {
                chromeBrowser.Back();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromeBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chromeBrowser != null)
                if (chromeBrowser.CanGoForward)
            {
                chromeBrowser.Forward();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Navigate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromeBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chromeBrowser != null)
                chromeBrowser.Refresh();
        }

       private void button3_Click(object sender, EventArgs e)
        {
            ChromiumWebBrowser chromeBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chromeBrowser != null)
                chromeBrowser.Load(Properties.Settings.Default.Homepage);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings();
            settingsForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void newTabB_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);
            ChromiumWebBrowser chromeBrowser = new ChromiumWebBrowser(Properties.Settings.Default.Homepage);
            chromeBrowser.Parent = tab;
            chromeBrowser.Dock = DockStyle.Fill;
            textBox1.Text = Properties.Settings.Default.Homepage;
            chromeBrowser.AddressChanged += Chrome_AddressChanged;
            chromeBrowser.TitleChanged += ChromeBrowser_TitleChanged;
        }

        private void ChromeBrowser_TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                tabControl.SelectedTab.Text = e.Title;
            }));
        }

        private void rTabB_Click(object sender, EventArgs e)
        {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)ConsoleKey.Enter)
            {
                Navigate();
                e.Handled = true;
            }
        }

        private void Navigate()
        {
            ChromiumWebBrowser chromeBrowser = tabControl.SelectedTab.Controls[0] as ChromiumWebBrowser;
            if (chromeBrowser != null)
                chromeBrowser.Load(textBox1.Text);
        }
    }
}
