using RealEstateCatalog.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
using static System.Windows.Media.ImageSourceConverter;

namespace RealEstateCatalog.Views.ApartmentViews
{
    /// <summary>
    /// Логика взаимодействия для ApartmentCard.xaml
    /// </summary>
    public partial class ApartmentCard : Window
    {
        public ApartmentCard()
        {
            InitializeComponent();
        }

        
        private void OpenApartBtn_Click(object sender, RoutedEventArgs e)
        {
            if ( AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text)) != null)
            {
                ApartCardView.Visibility = Visibility.Visible;

                Apartment apartment = AppData.db.Apartment.Find(int.Parse(IDApartTxt.Text));
                adressApart.Text = apartment.adressApart;
                apartmentNum.Text = apartment.apartmentNum;
                apartmentType.Text = apartment.apartmentType;
                apartmentSquare.Text = apartment.apartmentSquare.ToString();
                apartmentNumRooms.Text = apartment.apartmentNum;
                apartmentCondition.Text = apartment.apartmentCondition;
                price.Text = apartment.price.ToString();
                apartmentInfo.Text = apartment.apartmentInfo;

                fullNameOwner.Text = apartment.fullNameOwner;
                telOwner.Text = apartment.telOwner;

                PhotoCatalog photoCatalog = AppData.db.PhotoCatalog.Find(apartment.IDPhotoCatalog);

                ImageSourceConverter converter = new ImageSourceConverter();
                ImageSource src1 = converter.ConvertFromString(photoCatalog.image_1) as ImageSource;
                ImageSource src2 = converter.ConvertFromString(photoCatalog.image_2) as ImageSource;
                ImageSource src3 = converter.ConvertFromString(photoCatalog.image_3) as ImageSource;

                img1.Source = src1;
                img2.Source = src2;
                img3.Source = src3;

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
