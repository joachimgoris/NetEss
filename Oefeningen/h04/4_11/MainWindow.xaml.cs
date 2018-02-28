using System;
using System.Windows;

namespace _4_11
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
            int nummer = Convert.ToInt16(NummerTextBox.Text);
            if (nummer > 0 && nummer < 255)
            {
                string binary = Convert.ToString(nummer, 2);
                BinairLabel.Content = binary;
            }
            else
            {
                BinairLabel.Content = "NAN";
            }
        }
    }
}
