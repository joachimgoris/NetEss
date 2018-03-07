using System;
using System.Windows;

namespace _6_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rdm = new Random();
        private double getal;
        private double som;
        private int teller;
        public MainWindow()
        {
            InitializeComponent();
            getal = rdm.Next(200,400);
            som = getal;
            teller = 1;
            resultaatLabel.Content = getal;
            somLabel.Content = som;
        }

        
        private void geefCijferButton_Click(object sender, RoutedEventArgs e)
        {
            getal = rdm.Next(200, 400);
            som += getal;
            resultaatLabel.Content = Convert.ToString(getal);
            gemiddeldeLabel.Content = Convert.ToString(som / teller);
            somLabel.Content = Convert.ToString(som);
            teller++;
        }
    }
}
