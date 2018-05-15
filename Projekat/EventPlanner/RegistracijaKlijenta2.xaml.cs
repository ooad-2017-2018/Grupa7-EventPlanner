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

    public sealed partial class RegistracijaKlijenta2 : Page
    {

        public static RegistracijaKlijenta2 ulaz;

        string naziv1;
        string password1;
        string kor;
        string br;
  
        public RegistracijaKlijenta2()
        {
            this.InitializeComponent();

            ulaz = this;
            //baza = bazica;
            
        }
        

       /* private void Button_Click(object sender, RoutedEventArgs e)
        {
            naziv1 = ime.Text + prezime.Text;
            password1 = password.Text;
            kor = korime.Text;
            br = brkar.Text;
            if (naziv1.Length < 2) throw new Exception("Neispravan unos");
            if (password1.Length < 5) throw new Exception("Neispravan format sifre");
            if (password1 != novi.Text) throw new Exception("Password i potvrda se razlikuju");
            if (korime.Text.Length < 10) throw new Exception("Nesipravan format korisnickog imena");
            if (brkar.Text.Length < 6) throw new Exception("Neisoravan format broja kreditne kartice");

            Klijent k = new Klijent(naziv1, password1, kor, br);
            baza.ListaKlijenata.Add(k);

        }*/
       /* private void btnSpasi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                IMobileServiceTable<Klijent> userTableObj = App.MobileService.GetTable<Klijent>();

                Klijent obj = new Klijent(naziv1, password1, kor, br);
                obj.Naziv = ime.Text + prezime.Text;
                obj.Sifra = password.Text;
                obj.KorisnickoIme = korime.Text;
                br = brkar.Text;
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog studenta.");
                msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }

        }*/

        private void ime_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void btnNazad_Click(object sender, RoutedEventArgs e)
        {
            //this.Frame.Navigate(typeof(IzbornikKorisnika));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            naziv1 = ime.Text + prezime.Text;
            password1 = password.Text;
            kor = korime.Text;
            br = brkar.Text;
            if (naziv1.Length < 2) throw new Exception("Neispravan unos");
            if (password1.Length < 5) throw new Exception("Neispravan format sifre");
            if (password1 != novi.Text) throw new Exception("Password i potvrda se razlikuju");
            if (korime.Text.Length < 10) throw new Exception("Nesipravan format korisnickog imena");
            if (brkar.Text.Length < 6) throw new Exception("Neisoravan format broja kreditne kartice");

            try
            {
                IMobileServiceTable<KlijentBaza> userTableObj = App.MobileService.GetTable<KlijentBaza>();

                KlijentBaza obj = new KlijentBaza();
                obj.ime = ime.Text;
                obj.prezime = prezime.Text;
                obj.sifra = password.Text;
                obj.korisnickoIme = korime.Text;
                obj.brojKartice = brkar.Text;
                obj.IDKlijenta = obj.IDKlijenta;
                userTableObj.InsertAsync(obj);
                MessageDialog msgDialog = new MessageDialog("Uspješno ste unijeli novog klijenta");
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
            this.Frame.Navigate(typeof(IzbornikKorisnika));
        }
    }
}
