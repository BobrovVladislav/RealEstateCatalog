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

namespace RealEstateCatalog.Views.ApartmentViews
{
    /// <summary>
    /// Логика взаимодействия для ApartmentRedact.xaml
    /// </summary>
    public partial class ApartmentRedact : Window
    {
        public ApartmentRedact()
        {
            InitializeComponent();
        }

        private void ID_Changed(object sender, RoutedEventArgs e)
        {
            if (IDApartTxt.Text != "")
            {
                if (AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text)) != null)
                {

                    Apartment apartment = AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text));

                    AdressApartTxt.Text = apartment.fullNameOwner;
                    NumApartTxt.Text = apartment.apartmentNum;
                    ApartmentTypeTxt.Text = apartment.apartmentType;
                    ApartmentSquareTxt.Text = apartment.apartmentSquare.ToString();
                    NumRoomsTxt.Text = apartment.numRooms.ToString();
                    ApartmentConditionTxt.Text = apartment.apartmentCondition;
                    PriceApartTxt.Text = apartment.price.ToString();
                    ApartmentInfoTxt.Text = apartment.apartmentInfo;
                    FullNameOwnerTxt.Text = apartment.fullNameOwner;
                    TelOwnerTxt.Text = apartment.telOwner;

                }
            }
        }

            private void RedactApartBtn_Click(object sender, RoutedEventArgs e)
        {
            if(IDApartTxt.Text == ""
                )
            {
                MessageBox.Show("Заполните ID!");
            } else if (AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text)) != null)
                {

                Apartment apartment = AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text));

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

                AppData.db.SaveChanges();
                MessageBox.Show("Информация о недвижимости была изменена!");


                Close();
            } else
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
