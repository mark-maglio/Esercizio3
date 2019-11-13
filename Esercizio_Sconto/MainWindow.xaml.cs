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

namespace Esercizio_Sconto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnCalcola_Click(object sender, RoutedEventArgs e)
        {
            double importo = double.Parse(txtImporto.Text);
            double perSconto = double.Parse(txtPercSconto.Text);
            double sconto = (importo / 100) * perSconto;
            txtSconto.Text = sconto.ToString();
            double iva = double.Parse(txtPercIva.Text);
            double importonetto = importo - sconto;
            double ivaP = importonetto * iva / 100;
            TxtIva.Text = ivaP.ToString();
            double importototale = importo - sconto + ivaP;
            txtLordo.Text = importototale.ToString();
        }
    }
}
