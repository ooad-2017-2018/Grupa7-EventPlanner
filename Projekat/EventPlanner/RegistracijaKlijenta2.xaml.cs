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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EventPlanner
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegistracijaKlijenta2 : Page
    {
        Baza baza;
        public RegistracijaKlijenta2(Baza bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string naziv1 = ime.Text + prezime.Text;
            string password1 = password.Text;
            string kor = korime.Text;
            string br = brkar.Text;
            if (naziv1.Length < 2) throw new Exception("Neispravan unos");
            if (password1.Length < 5) throw new Exception("Neispravan format sifre");
            if (password1 != novi.Text) throw new Exception("Password i potvrda se razlikuju");
            if (korime.Text.Length < 10) throw new Exception("Nesipravan format korisnickog imena");
            if (brkar.Text.Length < 6) throw new Exception("Neisoravan format broja kreditne kartice");

            Klijent k = new Klijent(naziv1, password1, kor, br);
            baza.ListaKlijenata.Add(k);

        }

        private void ime_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IzbornikKorisnika));
        }
    }
}
