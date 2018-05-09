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
    public sealed partial class Main1 : Page
    {
        Baza bazica;
        public Main1(Baza baza)
        {
            this.InitializeComponent();
            bazica = baza;
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string password = druga.Text;
            if (password != bazica.Administrator.Sifra) throw new Exception("Netacan password!");
        }
    }
}
