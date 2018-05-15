using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class UlazniPage : Page
    {
        public static Kontejnerska Kontejner = new Kontejnerska();
        
        public static UlazniPage ulaz;
     
        public UlazniPage()
        {
            this.InitializeComponent();
            ulaz = this;
        }

        private void dugmePrijaviSe_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RegistracijaSaradnika2));
        }

        private void prijavi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login1));
        }

        private void klijenti_Click(object sender, RoutedEventArgs e)
        {
            //RegistracijaKlijenta2 rk = new RegistracijaKlijenta2(baza);
            this.Frame.Navigate(typeof(RegistracijaKlijenta2));
        }
    }
}
