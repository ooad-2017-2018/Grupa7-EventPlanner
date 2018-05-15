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
    public sealed partial class RegistracijaSaradnika2 : Page
    {
        public static RegistracijaSaradnika2 ulaz;

        public RegistracijaSaradnika2()
        {
            this.InitializeComponent();
            ulaz = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string naziv1 = naziv.Text;
            string password1 = pass.Text;
            string adresa = adres.Text;
            string br = brkar.Text;

            bool nadjeno = false;
            if (naziv.Text.Length < 5) throw new Exception("Nepravilan naziv usluge");
            if (vrsta.Text.Length < 5) throw new Exception("Nepravilna vrsta usluge");
     /*       for(int i = 0; i < baza.ListaSaradnika.Count(); i++)
            {
                if (pass.Text == baza.ListaSaradnika[i].Sifra) nadjeno = true;
            } 
            if (nadjeno == false) throw new Exception("Nije pronaadjen nijedan uneseni password"); */
            if (brkar.Text.Length < 6) throw new Exception("Neispravan unos");
            if (vrsta.Text.Length < 6) throw new Exception("Neispravan unos");
            if (adres.Text.Length < 4) throw new Exception("Neispravan unos");

            try
            {
                IMobileServiceTable<SaradnikBaza> userTableObj = App.MobileService.GetTable<SaradnikBaza>();

                SaradnikBaza obj = new SaradnikBaza();
                obj.naziv = naziv.Text;
                obj.sifra = pass.Text;
                obj.korisnickoIme = naziv.Text;
                obj.brojKartice = brkar.Text;
                obj.IDSaradnika = obj.IDSaradnika;
                obj.adresa = adres.Text;
                obj.kontakt = kontakt.Text;
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog saradnika");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Izbornik));
        }
    }
}
