using System.Windows;

namespace Hello_Button
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hallo");
        }

        private void StraatButton_OnClick(object sender, RoutedEventArgs e)
        {
            StraatLabel.Content = "Sint-Sebastiaanstraat";
            StraatTextBox.Text = "Sint-Sebastiaanstraat";
        }
    }
}
