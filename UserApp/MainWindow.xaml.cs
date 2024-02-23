using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserApp
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

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = txtBoxLogin.Text.Trim();
            string password = passBox.Password.Trim();
            string password2 = passBox2.Password.Trim();
            string email = txtBoxEmail.Text.ToLower();

            if (login.Length < 5)
            {
                txtBoxLogin.ToolTip = "Not Correct";
                txtBoxLogin.Background = Brushes.DarkRed;

            }
            else
            {
                txtBoxLogin.Background = Brushes.Transparent;
            }
            if(password.Length < 5)
            {
                passBox.ToolTip = "Not Correct";
                passBox.Background = Brushes.DarkRed;
            }
            else
            {
                passBox.Background = Brushes.Transparent;
            }
            if (password2 != password)
            {
                passBox2.ToolTip = "Not Correct";
                passBox2.Background = Brushes.DarkRed;
            }
            else
            {
                passBox2.Background = Brushes.Transparent;
            }
            if (!IsValidEmail(email))
            {
                txtBoxEmail.ToolTip = "Not Correct";
                txtBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                txtBoxLogin.ToolTip = "";
                txtBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox2.ToolTip = "";
                passBox2.Background = Brushes.Transparent;
                txtBoxEmail.ToolTip = "";
                txtBoxEmail.Background = Brushes.Transparent;
                MessageBox.Show("OK");
            }
            static bool IsValidEmail(string email)
            {
               
                string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                return Regex.IsMatch(email, pattern);
            }
        }
    }
}