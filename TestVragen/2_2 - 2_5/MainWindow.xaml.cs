using System.Windows;

namespace _2._1
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

        private void NaamButton_Click(object sender, RoutedEventArgs e)
        {
            NaamLabel.Content = "Joachim";
        }

        private void HelloWorldButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello world");
        }

        private void GoobyeCruelWorldButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Goodbye cruel world");
        }
    }
}
