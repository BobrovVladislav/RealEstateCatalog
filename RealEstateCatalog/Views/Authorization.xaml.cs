using RealEstateCatalog.Base;
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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace RealEstateCatalog.Views
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtLogin.Text == "" || txtPassword.Password == "") {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                var CurrentUser = AppData.db.User.FirstOrDefault(u => u.Login == txtLogin.Text && u.Password == txtPassword.Password);
                if (CurrentUser != null)
                {
                    MainWindow mainWindow = new MainWindow();
                    mainWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Такого пользователя нет в базе данных");
                }
            }
        }
    }
}
