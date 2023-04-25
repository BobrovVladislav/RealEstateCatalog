using RealEstateCatalog.Base;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RealEstateCatalog.Views.ApartmentViews
{
    /// <summary>
    /// Логика взаимодействия для ApartmentDelete.xaml
    /// </summary>
    public partial class ApartmentDelete : Window
    {
        public ApartmentDelete()
        {
            InitializeComponent();
        }

        private void DeleteApartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IDApartTxt.Text == "")
            {
                MessageBox.Show("Заполните ID!");
            }
            else if (AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text)) != null)
            {
                {
                    if (MessageBox.Show("Вы действительно хотите удалить данную запись?",
                        "Уведомление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                    {
                        Apartment apartment = AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text));
                        AppData.db.Apartment.Remove(apartment);
                        AppData.db.SaveChanges();
                        MessageBox.Show("Удаление прошло успешно");
                    }

                    Close();
                }
            }
            else
            {
                MessageBox.Show("Такой записи нет в базе данных");
            }
        }

        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {

            Close();
        }

    } 
}
