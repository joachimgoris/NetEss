using System;
using System.Windows;

namespace SliderDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private bool initialized;
        public MainWindow()
        {
            InitializeComponent();
            initialized = true;
        }

        private void ValueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (initialized == true)
                ValueTextBox.Text = Convert.ToString(ValueSlider.Value);
        }
    }
}
