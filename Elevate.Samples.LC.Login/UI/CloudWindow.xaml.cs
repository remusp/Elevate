using Sdl.LanguageCloud.IdentityApi;
using System.Diagnostics;
using System.Windows;

namespace Elevate.Samples.LC.Login.UI
{
    /// <summary>
    /// Interaction logic for Trados_Look_and_Feel.xaml
    /// </summary>
    public partial class CloudWindow : Window
    {
        private ILanguageCloudIdentityApi _lcInstance;

        public CloudWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _lcInstance = LanguageCloudIdentityApi.Instance;
            ReadData();
        }

        private void ReadData()
        {
            if (IsLoggedIn())
            {
                var credential = _lcInstance.LanguageCloudCredential;
                tbEmail.Text = credential.Email;
                tbAccount.Text = credential.AccountName;
                var key = _lcInstance.ApiKey;
                Debug.WriteLine(key);
            }
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (IsLoggedIn())
            {
                MessageBox.Show("Already logged in!", "LC Plugin", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                if (_lcInstance.TryLogin(out string errorMessage))
                {
                    ReadData();
                }
                else
                {
                    MessageBox.Show($"Login error: {errorMessage}", "LC Plugin", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private bool IsLoggedIn()
        {
            return !string.IsNullOrEmpty(_lcInstance.AccessToken);
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (!_lcInstance.Logout())
            {
                MessageBox.Show($"Error at logout", "LC Plugin", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            ClearData();
        }

        private void ClearData()
        {
            tbEmail.Text = "Email";
            tbAccount.Text = "Account";
        }
    }
}
