using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Asynchronous_Programming
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// -------------------------------------
    /// In synchronous program execution, program is executed line by line - one at a time, when 
    /// a function is called, program execution has to wait until the function returns before it 
    /// continues execution to the next line
    /// 
    /// In an asynchronous programming when a function is called, progrm execution continues to the 
    /// next line without waiting for the function to complete.
    /// Improves responisveness of the application
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs args)
        {
            Task<string> html = DownloadHtmlAsync("http://msdn.microsoft.com");

            textBlock.Text = await html;

            MessageBoxResult mb = MessageBox.Show("", "ABC", MessageBoxButton.OK, MessageBoxImage.Hand); 
        }

        // Three things to note in the signature:  
        //  - The method has an async modifier.   
        //  - The return type is Task or Task<T>.  
        //    Here, it is Task<string> because the return statement returns a string.  
        //  - The method name ends in "Async." 
        private async Task<string> DownloadHtmlAsync(string url)
        {
            using (var webClient = new WebClient())
            {
                var html = await webClient.DownloadStringTaskAsync(url);

                using (var streamWriter = new StreamWriter(@"C:\Users\result.html"))
                {
                    await streamWriter.WriteAsync(html);

                    var x = 1 + 2;
                }
                return html;
            }
        }

        private string DownloadHtml(string url)
        {
            using (var webClient = new WebClient())
            {
                var html = webClient.DownloadString(url);

                using (var streamWriter = new StreamWriter(@"C:\Users\Vasserman\Desktop\result.html"))
                {
                    streamWriter.Write(html);
                }
                return html;
            }
        }
    }
}
