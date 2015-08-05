using System;
using System.Windows;
using System.Windows.Media.Imaging;
using GravatarSharp.Core;

namespace SystemOut.GravatarSharp.Wpf
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

        private async void GetUserProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            var controller = new GravatarController();
            var profileResult = await controller.GetProfile(InputTextBox.Text);
            if (profileResult.Profile != null)
            {
                Image.Source = new BitmapImage(new Uri(GravatarController.GetImageUrl(InputTextBox.Text, (int)Image.Width)));
                IdTextBox.Text = profileResult.Profile.Id;
                HashTextBox.Text = profileResult.Profile.Hash;
                FullNameTextBox.Text = profileResult.Profile.FullName;
                UsernameTextBox.Text = profileResult.Profile.UserName;
            }
            else
            {
                MessageBox.Show(this, profileResult.ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }    
        }
    }
}
