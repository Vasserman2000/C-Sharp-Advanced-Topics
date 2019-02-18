using System;
using System.Collections.Generic;
using System.Linq;
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

        private void Button_Click(object sender, RoutedEventArgs args)
        {
            textBlock.Text = "Hello Elisha";
        }
    }
}
