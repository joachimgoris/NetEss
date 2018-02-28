using System;
using System.Windows;

namespace _4_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BerekenButton_Click(object sender, RoutedEventArgs e)
        {
            double straal = Convert.ToDouble(StraalTextBox.Text);
            double omtrek;
            double oppervlakte;
            double volume;

            omtrek = 2 * Math.PI * straal;
            oppervlakte = Math.PI * Math.Pow(straal, 2);
            volume = (4 * Math.PI / 3) * Math.Pow(straal, 3);

            OmtrekLabel.Content = omtrek;
            OppervlakteLabel.Content = oppervlakte;
            VolumeLabel.Content = volume;   
        }
    }
}
