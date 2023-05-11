using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace task_tracking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();

            //db = new ApplicationContext();
        }

        private void Button_Window_Auth_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
            this.Hide();
        }
        private void RegistrationButton_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = FirstNameBox.Text.Trim();
            string SecondName = SecondNameBox.Text.Trim();
            string Email = EmailBox.Text.Trim();
            string Password = PasswordBox.Password.Trim();
            string checkPass = textBoxCheckPass.Password.Trim();
            if (!(Email.Contains("@gmail.com") || Email.Contains("@mail.ru") || Email.Contains("@‌yandex.ru")))
            {
                EmailBox.ToolTip = "Invalid email format";
                EmailBox.Background = Brushes.DarkRed;
            }
            else if (Password.Length < 8)
            {
                PasswordBox.ToolTip = "The password is too short";
                PasswordBox.Background = Brushes.DarkRed;
            }
            if (FirstName.Length <= 1)
            {
                FirstNameBox.ToolTip = "Введите имя";
                FirstNameBox.Background = Brushes.Red;
            }
            else if (SecondName.Length <= 1)
            {
                SecondNameBox.ToolTip = "Введите фамилию";
                SecondNameBox.Background = Brushes.Red;
            }
            else if (checkPass != Password)
            {
                textBoxCheckPass.ToolTip = "Пароли не совпадают";
                textBoxCheckPass.Background = Brushes.Red;
            }
            else
            {
                FirstNameBox.ToolTip = null;
                FirstNameBox.Background = null;
                SecondNameBox.ToolTip = null;
                SecondNameBox.Background = Brushes.Transparent;
                EmailBox.ToolTip = null;
                EmailBox.Background = Brushes.Transparent;
                PasswordBox.ToolTip = null;
                PasswordBox.Background = Brushes.Transparent;
                textBoxCheckPass.ToolTip = null;
                textBoxCheckPass.Background = Brushes.Transparent;

                MessageBox.Show("You are registered");
            }
            string Login = FirstName + " " + SecondName;
            User user = new User(Login, Email, Password);
            // Здесь мы отправляем информацию о пользователе в базу данных
            //db.Users.Add(user);
            //db.SaveChanges();
        }
    }
}

