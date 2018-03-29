using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace _13_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            colorComboBox.SelectedIndex = 0;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem item = (ComboBoxItem) colorComboBox.SelectedItem;
            string selectedColor = Convert.ToString(item.Content);

            colorLabel.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(selectedColor));
            colorLabel.Background = (Brush) new BrushConverter().ConvertFromString(selectedColor);
        }

    }
}
