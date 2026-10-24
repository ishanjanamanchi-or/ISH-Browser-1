using System;
using System.Windows;
using Microsoft.Web.WebView2.Wpf;
using System.Windows.Controls;

namespace ISH_Browser_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Browser.Source = new Uri("https://google.com");

            GoButton.Click += GoButton_Click;
        }

        private void GoButton_Click(object sender, RoutedEventArgs e)
        {
            Browser.Source = new Uri(AddressBar.Text);
        }

        private void NewTabButton_Click(object sender, RoutedEventArgs e)
        {
            TabItem tab = new TabItem();
            tab.Header = "New Tab";

            WebView2 browser = new WebView2();
            browser.Source = new Uri("https://google.com");

            tab.Content = browser;

            BrowserTabs.Items.Add(tab);
            BrowserTabs.SelectedItem = tab;
        }
    }
}