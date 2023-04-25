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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RealEstateCatalog.Views.ApartmentViews
{
    /// <summary>
    /// Логика взаимодействия для ApartmentMain.xaml
    /// </summary>
    public partial class ApartmentMain : Page
    {
        public ApartmentMain()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ApartmentDate.ItemsSource = AppData.db.Apartment.ToList();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentDate.ItemsSource = null;
            ApartmentDate.ItemsSource = AppData.db.Apartment.ToList();  
        }



        private void AddApartBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentAdd add = new ApartmentViews.ApartmentAdd();
            add.Show();
        }

        private void RedactApartBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentRedact card = new ApartmentViews.ApartmentRedact();
            card.Show();
        }

        private void CardApartBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentCard card= new ApartmentViews.ApartmentCard();
            card.Show();
        }

        private void ApartmentDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentDelete card = new ApartmentViews.ApartmentDelete();
            card.Show();
        }

        
    }
}
