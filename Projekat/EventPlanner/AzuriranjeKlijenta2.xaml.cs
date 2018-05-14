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
    public sealed partial class AzuriranjeKlijenta2 : Page
    {
        Baza baza;
        public AzuriranjeKlijenta2(Baza bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string stari = prva.Text;
            bool nadjeno = false;
            for(int i = 0;  i < baza.ListaKlijenata.Count(); i++)
            {
                if(stari == baza.ListaKlijenata[i].Sifra)
                {
                    nadjeno = true;
                    if(druga.Text.Length != 0)
                    {
                        bool ispravno = true;
                        if (druga.Text.Length < 5)
                        {
                            ispravno = false;
                            throw new Exception("Prekratak password");
                         
                        }
                        if (druga.Text != treca.Text)
                        {
                            ispravno = false;
                            throw new Exception("Passwordi se ne podudaraju");
                           
                        }
                       if(ispravno == true) baza.ListaKlijenata[i].Sifra = druga.Text;
                    }
                    if (textbox_KontaktInfo.Text.Length < 5 && textbox_KontaktInfo.Text.Length != 0) throw new Exception("neispravan format kartice");
                    else if (textbox_KontaktInfo.Text.Length >= 5 && textbox_KontaktInfo.Text.Length != 0) baza.ListaKlijenata[i].BrojKartice = textbox_KontaktInfo.Text;

                    if (textbox_OVama.Text.Length != 0 && textbox_OVama.Text.Length < 10) throw new Exception("Neispravan format korisnickog imena");
                    if (textbox_OVama.Text.Length != 0 && textbox_OVama.Text.Length >= 10) baza.ListaKlijenata[i].KorisnickoIme = textbox_OVama.Text;

                }
            }
            if (nadjeno == false) throw new Exception("Nepostojeci password");

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(IzbornikKorisnika));
        }
    }
}
