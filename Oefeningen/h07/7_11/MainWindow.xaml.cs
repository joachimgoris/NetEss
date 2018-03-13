using System;
using System.Windows;

namespace _7_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Random Rdm1 = new Random(5000);
        public static  Random Rdm2 = new Random(5000);
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RandomButton1_Click(object sender, RoutedEventArgs e)
        {
            RandomLabel1.Content = Convert.ToDouble(Rdm1.Next());
        }

        private void RandomButton2_Click(object sender, RoutedEventArgs e)
        {
            RandomLabel2.Content = Convert.ToDouble(Rdm2.Next());
        }
    }
}
