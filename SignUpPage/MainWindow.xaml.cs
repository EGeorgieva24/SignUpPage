using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace SignUpPage
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            char[] arr = {'1', '@', '*', '_','<', '>', '$', '%','^', '&', '-', ',', '>'};
            string ran = arr.ToString();
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;

            if (pswdBox.Password.Length < 8 && !pswdBox.Password.Contains(ran))
            {
                MessageBox.Show("Wrong attempt, go back and try again","error", MessageBoxButton.YesNoCancel,MessageBoxImage.Error);

            }
           else if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("First name and last name cannot be empty.");
                
            }

            else if (!email.Contains("@"))
            {
                MessageBox.Show("Invalid email address.");
                return;
            }

            else
            {
                MessageBox.Show("User registered successfully!");
                MessageBox.Show($"Your username is: {txtUsername.Text}");
                MessageBox.Show($"Your username is: {pswdBox.Password}");
            }
        }
    


        private void UsernameClear(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = "";
        }

        private void FirstNameClear(object sender, RoutedEventArgs e)
        {
            txtFirstName.Text = "";
        }

        private void LastNameClear(object sender, RoutedEventArgs e)
        {
            txtLastName.Text = "";

        }

        private void EmailClear(object sender, RoutedEventArgs e)
        {
            txtEmail.Text = "";

        }

        private void Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Update(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(SqlConnection);
                SqlConnection.Open();
                string query = $"UPDATE Users SET FirstName = '{txtFirstName.Text}'.LastName = '{txtLastName.Text}', Email = 'yxy.Email.text}', Password = 'pswdBox.Password}' WHERE Username = 'txtUsername.Text}'";
                SqlCommand cmd = new SqlCommand(qury, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Success it words fine!");
                    }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
