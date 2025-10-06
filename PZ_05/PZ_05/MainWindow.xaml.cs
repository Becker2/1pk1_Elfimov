using System;
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



    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    namespace TableBookingSystem
    {
        public partial class MainWindow : Window
        {
            private Dictionary<string, (string password, string role)> users = new()
        {
            { "user1", ("1234", "user") },
            { "manager1", ("admin", "manager") }
        };

            public MainWindow()
            {
                InitializeComponent();
            }

            private void LoginButton_Click(object sender, RoutedEventArgs e)
            {
                string login = LoginTextBox.Text;
                string password = PasswordBox.Password;

                if (users.ContainsKey(login) && users[login].password == password)
                {
                    string role = users[login].role;
                    if (role == "user")
                        new UserWindow().Show();
                    else if (role == "manager")
                        new ManagerWindow().Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.");
                }
            }
        }
    }
