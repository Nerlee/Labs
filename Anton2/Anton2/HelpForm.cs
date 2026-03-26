using System;
using System.IO;
using System.Windows.Forms;

namespace Anton2
{
    public class HelpForm : Form
    {
        private WebBrowser webBrowser;

        public HelpForm(string htmlPath)
        {
            Text = "Справка - Anton2";
            Width = 900;
            Height = 600;
            StartPosition = FormStartPosition.CenterScreen;

            webBrowser = new WebBrowser
            {
                Dock = DockStyle.Fill,
                ScriptErrorsSuppressed = true
            };

            Controls.Add(webBrowser);

            if (File.Exists(htmlPath))
            {
                webBrowser.Navigate(htmlPath);
            }
            else
            {
                webBrowser.DocumentText = "<html><body><h1>Файл справки не найден</h1></body></html>";
            }
        }
    }
}