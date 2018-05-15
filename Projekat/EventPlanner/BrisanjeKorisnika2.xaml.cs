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
    public sealed partial class BrisanjeKorisnika2 : Page
    {
        Kontejnerska baza;
        public BrisanjeKorisnika2(Kontejnerska bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nesto = textBoxus.Text;
            bool nadjeno = false;
            for(int i = 0; i < baza.ListaKlijenata.Count(); i++)
            {
                if(nesto == baza.ListaKlijenata[i].BrojKartice)
                {
                    nadjeno = true;
                 
                }
            }
            if (nadjeno == false) throw new Exception("nepostojeci korisnik");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nesto = textBoxus.Text;
            bool nadjeno = false;
            for (int i = 0; i < baza.ListaKlijenata.Count(); i++)
            {
                if (nesto == baza.ListaKlijenata[i].BrojKartice)
                {
                    nadjeno = true;
                    baza.ListaKlijenata.Remove(baza.ListaKlijenata[i]);
                }
            }
        }

        private void dugmetrazi_Click(object sender, RoutedEventArgs e)
        {
            string nesto = textBoxus.Text;
            bool nadjeno = false;
            for (int i = 0; i < baza.ListaKlijenata.Count(); i++)
            {
                if (nesto == baza.ListaKlijenata[i].BrojKartice)
                {
                    nadjeno = true;

                }
            }
            if (nadjeno == false) throw new Exception("nepostojeci korisnik");
        }

        private void dugmepotvrdi_Click(object sender, RoutedEventArgs e)
        {
            string nesto = textBoxus.Text;
            bool nadjeno = false;
            for (int i = 0; i < baza.ListaKlijenata.Count(); i++)
            {
                if (nesto == baza.ListaKlijenata[i].BrojKartice)
                {
                    nadjeno = true;
                    baza.ListaKlijenata.Remove(baza.ListaKlijenata[i]);
                }
            }
        }

        private void dugmeodustani_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdminIzbornik));
        }
    }
}
