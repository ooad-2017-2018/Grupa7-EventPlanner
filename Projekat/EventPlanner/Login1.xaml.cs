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
    public sealed partial class Login1 : Page
    {
        Baza baza;
        public Login1(Baza bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool nadjeno1 = false;
            for(int i = 0; i < baza.ListaKlijenata.Count(); i++)
            {
                if (baza.ListaKlijenata[i].KorisnickoIme == prva.Text && baza.ListaKlijenata[i].Sifra == druga.Text) nadjeno1 = true;
              
            }
            for (int i = 0; i < baza.ListaSaradnika.Count(); i++)
            {
                if (baza.ListaSaradnika[i].KorisnickoIme == prva.Text && baza.ListaSaradnika[i].Sifra == druga.Text) nadjeno1 = true;

            }
            if (nadjeno1 == false) throw new Exception("Nije pronadjen niti jedan korisnik sa datim podacima");
        }
    }
}
