using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Webbrowser

{    /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                //If You Want to define a defualt URI then you can define like below...
                MyWebBrowser.Source = new Uri("http://www.c-sharpcorner.com");

                //Otherwise for blank you can set it as like below...
                //MyWebBrowser.Source = new Uri("about:blank");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyBack_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.GoBack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyForward_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.GoForward();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyGo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MyWebBrowser.Source = new Uri("http://" + MyTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MyWebBrowser_LoadCompleted(object sender, NavigationEventArgs e)
        {
            MessageBox.Show("Completed.");
        }
    }
}
