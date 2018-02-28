using System;
using System.Windows;

namespace _4_11
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

        private void BerekenButton_OnClick(object sender, RoutedEventArgs e)
        {
            int number = Convert.ToInt32(NumberTextBox.Text);
            if (number > 0 && number < 256)
            {
                BinairLabel.Content = BerekenBinair(number);
            }
            else
            {
                BinairLabel.Content = "NAN";
            }
        }

        private static string BerekenBinair(int number)
        {
            string binary = string.Empty;

            while (number>0)
            {
                int remainder = number % 2;
                number = number / 2;
                binary = remainder + binary; 
            }
            

            return binary;
        }
    }
}
