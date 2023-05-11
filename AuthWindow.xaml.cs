using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Windows.Shapes;
using task_tracking;

namespace task_tracking
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click(object slender, RoutedEventArgs e)
        {
            string email = EmailBox.Text.Trim();
            string pass = PasswordBox.Password.Trim();

            // Функция содержания строки в базе данных (условно dbContains())
            public void dbContains()
            {

            }
            // Функция нахождения пароля пользователя в базе данных (условно dbUserPass(email))
            public string dbUserPass(string email)
            {
                return password;
            }
            if (!email.dbContains())
            {
                EmailBox.ToolTip = "Такого пользователя не существует";
                EmailBox.Background = Brushes.Red;
            }
            else if (pass != dbUserPass(email))
            {
                PasswordBox.ToolTip = "Вы ввели неправильный пароль";
                PasswordBox.Background = Brushes.Red;
            }
            else
            {
                EmailBox.ToolTip = "";
                EmailBox.Background = Brushes.Transparent;
                PasswordBox.ToolTip = "";
                PasswordBox.Background = Brushes.Transparent;



                MessageBox.Show("Вы успешно вошли!");
            }
        }

        private void Button_Window_Reg_Click(object slender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}