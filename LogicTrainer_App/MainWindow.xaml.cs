using System;
using System.Windows;
using LogicTrainer_App.Pages2;
using LogicTrainer_App.Themes;

namespace LogicTrainer_App
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PagesNavigation.Navigate(new HomePage());

          
           
            stackbox.Visibility = Visibility.Collapsed;
            dagrid.Visibility = Visibility.Collapsed;
            dagrid2.Visibility = Visibility.Collapsed;

        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //menu navigation
        private void rdHome_Click(object sender, RoutedEventArgs e)
        {

            dagrid.Visibility = Visibility.Collapsed;
            dagrid2.Visibility = Visibility.Collapsed;

            PagesNavigation.Navigate(new System.Uri("Pages2/HomePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdSounds_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/SoundsPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdNotes_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/NotesPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void rdPayment_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/PaymentPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void rdAbout_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages2/AboutPage.xaml", UriKind.RelativeOrAbsolute));
            dagrid.Visibility = Visibility.Collapsed;
            dagrid2.Visibility = Visibility.Collapsed;
        }


        //gates page navigation
        private void OrG_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/OrGatePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void NotG_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/NotGatePage.xaml", UriKind.RelativeOrAbsolute));
        }


        private void NorG_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/NorGatePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void AndG_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/AndGatePage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void NandG_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/NandGatePage.xaml", UriKind.RelativeOrAbsolute));
        
        }

        private void ExOrG_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/ExOrGatePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void ExNorG_Click(object sender, RoutedEventArgs e)
        {
            PagesNavigation.Navigate(new System.Uri("Pages/ExNorGatePage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void Themes_Click(object sender, RoutedEventArgs e)
        {
            if (Themes.IsChecked == true)
                ThemeControl.SetTheme(ThemeControl.ThemeTypes.Dark);
            else
                ThemeControl.SetTheme(ThemeControl.ThemeTypes.Light);
        }
    }
}


