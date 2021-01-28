using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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

namespace WebBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btGo_Click(object sender, RoutedEventArgs e)
        {
            string myUrl = tbUrl.Text;
            //TODO Check URL
            if (Uri.IsWellFormedUriString(myUrl, UriKind.RelativeOrAbsolute))
                wbMain.Navigate(myUrl);
            else
                MessageBox.Show($"Url [{myUrl}] is not well formed.", "Bad url", MessageBoxButton.OK, MessageBoxImage.Warning);
        }

        private void miBack_Click(object sender, RoutedEventArgs e)
        {
            if (wbMain.CanGoBack)
                wbMain.GoBack();
        }

        private void miForward_Click(object sender, RoutedEventArgs e)
        {
            if (wbMain.CanGoForward)
                wbMain.GoForward();
        }
    }
}
