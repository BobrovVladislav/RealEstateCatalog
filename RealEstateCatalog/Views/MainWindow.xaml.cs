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

namespace RealEstateCatalog.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        List<Page> pages;
        public MainWindow()
        {
            InitializeComponent();
            this.pages = new List<Page>();  

            pages.Add(new ApartmentViews.ApartmentMain());
            pages.Add(new ClientsViews.ClientsMain());
            pages.Add(new ContractsViews.ContractMain());
            pages.Add(new ServicesView.ServicesMain());
            pages.Add(new AboutProgramm());

            if (myFrame.Content == null)
            {
                myFrame.Content = pages[0];

                ListBoxApartment.IsSelected = true;
            }
        }

        

        private void ExitBtn_Click(Object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void OpenApartBtn_Click(object obj, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentCard card = new ApartmentViews.ApartmentCard();
            card.Show();
        }

        private void AddApartBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentAdd add = new ApartmentViews.ApartmentAdd();
            add.Show();
        }

        private void RedactApartBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentRedact redact = new ApartmentViews.ApartmentRedact();
            redact.Show();
        }

        private void DeleteApartBtn_Click(object sender, RoutedEventArgs e)
        {
            ApartmentViews.ApartmentDelete delete = new ApartmentViews.ApartmentDelete();
            delete.Show();
        }

        private void ContractsBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = pages[2];
        }

        private void AboutProgrammBtn_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Content = pages[3];
        }




        private void ListBoxApartment_Selected(object sender, RoutedEventArgs e)
        {
            myFrame.Content = pages[0];
        }

        private void ListBoxClient_Selected(object sender, RoutedEventArgs e)
        {
            myFrame.Content = pages[1];
        }

        private void ListBoxСontracts_Selected(object sender, RoutedEventArgs e)
        {
            myFrame.Content = pages[2];
        }

        private void ListBoxServices_Selected(object sender, RoutedEventArgs e)
        {
            myFrame.Content = pages[3];
        }
        private void ListBoxAbout_Selected(object sender, RoutedEventArgs e)
        {
            myFrame.Content = pages[4];
        }
        private void ListBoxExit_Selected(object sender, RoutedEventArgs e)
        {
            Authorization card = new Authorization();
            card.Show();
            Close();
        }
    }
}
