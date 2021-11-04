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

namespace WpfApp2
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

        private void dollarEqual_Click(object sender, RoutedEventArgs e)
        {
            double dollarrate = Convert.ToDouble(DollarRate.Text);
            double dollarsumrate = Convert.ToDouble(DollarSumRate.Text);
            double rubdollarsum = dollarrate * dollarsumrate;
            RubDollarSum.Text = Convert.ToString(rubdollarsum);
        }

        private void euroEqual_Click(object sender, RoutedEventArgs e)
        {
            double eurorate = Convert.ToDouble(EuroRate.Text);
            double eurosumrate = Convert.ToDouble(EuroSumRate.Text);
            double rubeurosum = eurorate * eurosumrate;
            RubEuroSum.Text = Convert.ToString(rubeurosum);
        }

        private void grivnaEqual_Click(object sender, RoutedEventArgs e)
        {
            double grirate = Convert.ToDouble(GrivnaRate.Text);
            double grisumrate = Convert.ToDouble(GrivnaSumRate.Text);
            double rubgrisum = grirate * grisumrate;
            RubGrivnaSum.Text = Convert.ToString(rubgrisum);
        }

        private void dramaEqual_Click(object sender, RoutedEventArgs e)
        {
            double drarate = Convert.ToDouble(DramaRate.Text);
            double drasumrate = Convert.ToDouble(DramaSumRate.Text);
            double rubdrasum = drarate * drasumrate;
            RubDramaSum.Text = Convert.ToString(rubdrasum);
        }

        private void mileEqual_Click(object sender, RoutedEventArgs e)
        {
            double milerate = Convert.ToDouble(MileRate.Text);
            double milesumrate = Convert.ToDouble(MileSumRate.Text);
            double milekmsum = milerate * milesumrate;
            KmMileSum.Text = Convert.ToString(milekmsum);
        }

        private void verstEqual_Click(object sender, RoutedEventArgs e)
        {
            double verrate = Convert.ToDouble(VerstRate.Text);
            double versumrate = Convert.ToDouble(VerstSumRate.Text);
            double verkmsum = verrate * versumrate;
            KmVerstSum.Text = Convert.ToString(verkmsum);
        }

        private void yardEqual_Click(object sender, RoutedEventArgs e)
        {
            double yardrate = Convert.ToDouble(YardRate.Text);
            double yardsumrate = Convert.ToDouble(YardSumRate.Text);
            double yardkmsum = yardrate * yardsumrate;
            KmYardSum.Text = Convert.ToString(yardkmsum);
        }

        private void feetEqual_Click(object sender, RoutedEventArgs e)
        {
            double feetrate = Convert.ToDouble(FeetRate.Text);
            double feetsumrate = Convert.ToDouble(FeetSumRate.Text);
            double feetkmsum = feetrate * feetsumrate;
            FeetKmSum.Text = Convert.ToString(feetkmsum);
        }
    }
}
