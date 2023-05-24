using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.Web.WebView2.Core;
using System;

namespace CustomMousePointerHangsUI
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webView2.Loaded += async (s, e) =>
            {
                await webView2.EnsureCoreWebView2Async().AsTask();
                webView2.CoreWebView2.SetVirtualHostNameToFolderMapping(hostName: "shan.tutorials.winui3",
                folderPath: "Assets",
                accessKind: CoreWebView2HostResourceAccessKind.Allow);

                webView2.Source = new Uri("https://shan.tutorials.winui3/html/index.html");
            };
        }
    }
}
