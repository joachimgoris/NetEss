using System;
using System.Windows;

namespace _4_9
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

        private void BerekenButton_OnClick(object sender, RoutedEventArgs e)
        {
            double ingeworpenBedrag = Convert.ToDouble(IngeworpenBedragTextBox.Text);
            double bedrag = ingeworpenBedrag - Convert.ToDouble(KostTextBox.Text);

            if (bedrag % 2 >= 1)
            {
                MessageBox.Show(Convert.ToString(Math.Floor(bedrag%2)));
                bedrag = bedrag - (Math.Floor(bedrag % 2) * 2);
                MessageBox.Show(Convert.ToString(bedrag));
            }
            else
            {

            }
        }
    }
}
