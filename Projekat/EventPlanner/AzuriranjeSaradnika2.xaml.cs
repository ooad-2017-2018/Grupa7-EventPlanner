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
    public sealed partial class AzuriranjeSaradnika2 : Page
    {
        Baza baza;
        public AzuriranjeSaradnika2(Baza bazica)
        {
            this.InitializeComponent();
            baza = bazica;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool nadjeno = false;
            if (prva.Text.Length < 5) throw new Exception("Prekratak naziv");
            if (druga.Text.Length < 5) throw new Exception("Prekratka vrsta");
            for(int i = 0; i < baza.ListaSaradnika.Count(); i++)
            {
                if (treca.Text == baza.ListaSaradnika[i].Id.ToString()) nadjeno = true;
            }
            if (nadjeno == false) throw new Exception("Nepostojeci password saradnika");
            if (cetvrta.Text.Length < 5) throw new Exception("Prekratka adresa");
            if (textbox_KontaktInfo.Text.Length < 5) throw new Exception("Prekratak opis");
            if (textbox_OVama.Text.Length < 5) throw new Exception("Neodgovarajuci format broja kreditne kartice");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Izbornik));
        }
    }
}
