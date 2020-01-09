using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CompitiVacanzeTepsit
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Calcola_Click(object sender, RoutedEventArgs e)
        {
            int min;
            int max;
            int a = int.Parse(txt_numero1.Text);
            int b = int.Parse(txt_numero2.Text);
            if(a<b)
            {
                min = a;
                max = b;
            }
            else
            {
                 min = b;
                 max = a;
            }
            double media = (a + b) / 2;
            lbl_risposta.Content = $"il massimo è {max} il minimo è {min} la media è {media}";
        }

        private void btn_pulisci_Click(object sender, RoutedEventArgs e)
        {
            txt_numero1.Clear();
            txt_numero2.Clear();
            lbl_risposta.Content="";
        }
    }
}
