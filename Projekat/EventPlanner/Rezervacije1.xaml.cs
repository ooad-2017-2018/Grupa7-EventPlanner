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
    public sealed partial class Rezervacije1 : Page
    {
        Baza baza;
        public Rezervacije1(Baza bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool nadjeno = false;
            for (int i = 0; i < baza.ListaRezervacija.Count(); i++)
            {
                if (baza.ListaRezervacija[i].BrojRezervacije.ToString() == deseta.Text) nadjeno = true;

            }
            if (nadjeno == false) throw new Exception("Nepostojeci ID broj rezervacije");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < baza.ListaRezervacija.Count(); i++)
            {
                if (baza.ListaRezervacija[i].BrojRezervacije.ToString() == deseta.Text) baza.ListaRezervacija.Remove(baza.ListaRezervacija[i]);

            }
        }
    }
}
