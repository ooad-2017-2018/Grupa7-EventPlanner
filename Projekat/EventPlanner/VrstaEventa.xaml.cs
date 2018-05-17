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
    public sealed partial class VrstaEventa : Page
    {
        public static VrstaEventa ulaz;
        public VrstaEventa()
        {
            this.InitializeComponent();
            ulaz = this;
        }

        private void dugmeizlaz_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(UlazniPage));
        }

        private void dugmePrijaviSe_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VrstaEventa));
        }

        private void dugmeobrisi_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VrstaEventa));
        }

        private void dugmeazuriraj_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RodjendanObjekti));
        }

        private void dugme_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(VrstaEventa));
        }
    }
}
