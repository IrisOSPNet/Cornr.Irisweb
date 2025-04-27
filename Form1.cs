using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace IrisCornr
{
    public partial class Form1 : Form
    {
        private const string TabsFileName = "tabs.txt"; // File to save the tab URLs

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Enable key preview to capture key events
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestoreTabs(); // Restore tabs when the app loads
        }

        private void RestoreTabs()
        {
            if (File.Exists(TabsFileName))
            {
                var urls = File.ReadAllLines(TabsFileName).ToList();
                foreach (var url in urls)
                {
                    CreateNewTab(url);
                }
            }
            else
            {
                CreateNewTab("https://ai-btech.wixstudio.com/launcher"); // Default tab
            }
        }

        private void CreateNewTab(string url)
        {
            TabPage newTabPage = new TabPage("New Tab");
            WebView2 newWebView = new WebView2
            {
                Dock = DockStyle.Fill,
                Source = new Uri(url)
            };
            newTabPage.Controls.Add(newWebView);
            tabControl1.TabPages.Add(newTabPage);
        }

        private void SaveTabs()
        {
            List<string> urls = new List<string>();
            foreach (TabPage tab in tabControl1.TabPages)
            {
                if (tab.Controls.Count > 0 && tab.Controls[0] is WebView2 webView)
                {
                    urls.Add(webView.Source.ToString());
                }
            }
            File.WriteAllLines(TabsFileName, urls);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveTabs(); // Save tabs when the app closes
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string url = txtAddressBar.Text;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }

            // Get the active TabPage
            TabPage activeTab = tabControl1.SelectedTab;
            if (activeTab != null && activeTab.Controls.Count > 0 && activeTab.Controls[0] is WebView2 webView)
            {
                // Navigate to the new URL
                webView.Source = new Uri(url);
            }
        }

        private void txtAddressBar_TextChanged(object sender, EventArgs e)
        {
            btnGo.Enabled = !string.IsNullOrWhiteSpace(txtAddressBar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a new TabPage
            CreateNewTab("https://ai-btech.wixstudio.com/launcher");
        }

        private void btnDeleteTab_Click(object sender, EventArgs e)
        {
            // Get the active TabPage
            TabPage activeTab = tabControl1.SelectedTab;

            // Check if there is an active tab
            if (activeTab != null)
            {
                tabControl1.TabPages.Remove(activeTab);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Get the active TabPage
            TabPage activeTab = tabControl1.SelectedTab;
            if (activeTab != null && activeTab.Controls.Count > 0 && activeTab.Controls[0] is WebView2 webView && webView.CanGoBack)
            {
                webView.GoBack();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            // Get the active TabPage
            TabPage activeTab = tabControl1.SelectedTab;
            if (activeTab != null && activeTab.Controls.Count > 0 && activeTab.Controls[0] is WebView2 webView && webView.CanGoForward)
            {
                webView.GoForward();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // You can add your custom event handling code here
        }
    }
}
