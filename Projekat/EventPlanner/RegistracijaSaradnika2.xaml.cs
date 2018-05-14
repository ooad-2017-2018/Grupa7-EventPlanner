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
    public sealed partial class RegistracijaSaradnika2 : Page
    {
        Baza baza;
        public RegistracijaSaradnika2(Baza bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool nadjeno = false;
            if (naziv.Text.Length < 5) throw new Exception("Nepravilan naziv usluge");
            if (vrsta.Text.Length < 5) throw new Exception("Nepravilna vrsta usluge");
            for(int i = 0; i < baza.ListaSaradnika.Count(); i++)
            {
                if (pass.Text == baza.ListaSaradnika[i].Sifra) nadjeno = true;
            }
            if (nadjeno == false) throw new Exception("Nije pronaadjen nijedan uneseni password");
            if (textbox_KontaktInfo.Text.Length < 6) throw new Exception("Neispravan unos");
            if (textbox_OVama.Text.Length < 6) throw new Exception("Nesipravan unos");
            if (adres.Text.Length < 4) throw new Exception("Nesipravan unos");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Izbornik));
        }
    }
}
