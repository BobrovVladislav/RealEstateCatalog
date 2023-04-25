using RealEstateCatalog.Base;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для ApartmentAdd.xaml
    /// </summary>
    public partial class ApartmentAdd : Window
    {
        public ApartmentAdd()
        {
            InitializeComponent();
        }

        private void SaveApartBtn_Click(object sender, RoutedEventArgs e)
        {
            if (
                AdressApartTxt.Text == "" ||
                NumApartTxt.Text == "" ||
                ApartmentTypeTxt.Text == "" ||
                ApartmentSquareTxt.Text == "" ||
                NumRoomsTxt.Text == "" ||
                ApartmentConditionTxt.Text == "" ||
                PriceApartTxt.Text == "" ||
                ApartmentInfoTxt.Text == "" ||
                FullNameOwnerTxt.Text == "" ||
                TelOwnerTxt.Text == ""
                )
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                Apartment apartment = new Apartment();
                apartment.adressApart = AdressApartTxt.Text;
                apartment.apartmentNum = NumApartTxt.Text;
                apartment.apartmentType = ApartmentTypeTxt.Text;
                apartment.apartmentSquare = int.Parse(ApartmentSquareTxt.Text);
                apartment.numRooms = int.Parse(NumRoomsTxt.Text);
                apartment.apartmentCondition = ApartmentConditionTxt.Text;
                apartment.price = int.Parse(PriceApartTxt.Text);
                apartment.apartmentInfo = ApartmentInfoTxt.Text;
                apartment.fullNameOwner = FullNameOwnerTxt.Text;
                apartment.telOwner = TelOwnerTxt.Text;
                apartment.IDPhotoCatalog = 1;

                AppData.db.Apartment.Add(apartment);
                AppData.db.SaveChanges();
                MessageBox.Show("Недвижимость добавлена в базу");

                Close();
            }
        }

        private void CancelBtn_Click( object sender, RoutedEventArgs e )
        {

            Close();
        }
    }
}
