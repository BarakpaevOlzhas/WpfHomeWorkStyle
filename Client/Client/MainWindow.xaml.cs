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

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsNigth = false;

        public MainWindow()
        {
            InitializeComponent();

            var uri = new Uri("StandartTheme.xaml", UriKind.Relative);            
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;            
            Application.Current.Resources.Clear();            
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void ButtonClickSignIn(object sender, RoutedEventArgs e)
        {
            RegistrationPanel.Visibility = Visibility.Collapsed;
            LoginPanel.Visibility = Visibility.Visible;
        }

        private void ButtonClickSignUp(object sender, RoutedEventArgs e)
        {
            LoginPanel.Visibility = Visibility.Collapsed;
            RegistrationPanel.Visibility = Visibility.Visible;
        }

        private void Button_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void ButtonClickForChangeTheme(object sender, RoutedEventArgs e)
        {
            IsNigth = !IsNigth;           

            if (IsNigth)
            {
                ImgIcon.Source = BitmapFrame.Create(new Uri(@"https://pngimage.net/wp-content/uploads/2018/05/black-moon-png-3.png"));
                var uri = new Uri("NightTheme.xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
            else
            {
                ImgIcon.Source = BitmapFrame.Create(new Uri(@"https://pngimage.net/wp-content/uploads/2018/06/sun-black-and-white-png-3.png"));                
                var uri = new Uri("StandartTheme.xaml", UriKind.Relative);
                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            }
        }
    }
}
