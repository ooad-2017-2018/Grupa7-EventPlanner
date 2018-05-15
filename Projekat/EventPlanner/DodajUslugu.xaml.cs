using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.WindowsAzure.MobileServices;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EventPlanner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DodajUslugu : Page
    {
        Kontejnerska baza;
        public DodajUslugu(Kontejnerska bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IzbornikKorisnika));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (prva.Text.Length < 3) throw new Exception("nevalidan unos");
            if (druga.Text.Length < 3) throw new Exception("nevalidan unos");

            string naziv = prva.Text;
            int id = Convert.ToInt16(cetvrta.Text);
            string vrsta = druga.Text;
            Int16 cijena  = Convert.ToInt16(treca.Text);
            Usluga u = new Usluga(id, cijena, naziv, vrsta);
            baza.ListaUsluga.Add(u);

            try
            {
                IMobileServiceTable<UslugaBaza> userTableObj = App.MobileService.GetTable<UslugaBaza>();

                UslugaBaza obj = new UslugaBaza();
                obj.naziv = prva.Text;
                obj.IDUsluge = obj.IDUsluge;
                obj.vrsta = druga.Text;
                obj.IDSaradnika = Convert.ToInt16(cetvrta.Text);
                obj.cijena = Convert.ToInt32(treca.Text);
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novu uslugu");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }

        }
    }
}
