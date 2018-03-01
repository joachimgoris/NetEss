using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Oval_Shape
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private Ellipse ellipse;

        public MainWindow()
        {
            InitializeComponent();

            VertSlider.Minimum = 0;
            VertSlider.Maximum = paperCanvas.Height;

            HorizSlider.Minimum = 0;
            HorizSlider.Maximum = paperCanvas.Width;

            vertLabel.Content = Convert.ToString(VertSlider.Value);
            horizLabel.Content = Convert.ToString(HorizSlider.Value);

            CreateEllipse();

            VertSlider.ValueChanged += vertSlider_ValueChanged;
            HorizSlider.ValueChanged += horizSlider_ValueChanged;
        }

        private void vertSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int vertical = Convert.ToInt32(VertSlider.Value);
            vertLabel.Content = Convert.ToString(vertical);
            UpdateEllipse();
        }

        private void horizSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int horizontal = Convert.ToInt32(HorizSlider.Value);
            horizLabel.Content = Convert.ToString(horizontal);
            UpdateEllipse();
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Width = HorizSlider.Value;
            ellipse.Height = VertSlider.Value;
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.Fill = new SolidColorBrush(Colors.Blue);
            ellipse.Margin = new Thickness(0, 0, 0, 0);
            paperCanvas.Children.Add(ellipse);
        }

        private void UpdateEllipse()
        {
            ellipse.Width = HorizSlider.Value;
            ellipse.Height = VertSlider.Value;
        }
    }
}
