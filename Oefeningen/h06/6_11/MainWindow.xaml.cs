using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _6_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        private DateTime time;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0,0,1);
            time = DateTime.Now;
            digitalClockLabel.Content = time.Hour + ":" + time.Minute + ":" + time.Second;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            analogClockCanvas.Children.Clear();
            time = DateTime.Now;
            digitalClockLabel.Content = time.Hour + ":" + time.Minute + ":" + time.Second;
            DrawArrows();
        }

        private void DrawArrows()
        {
            time = DateTime.Now;
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            double hourRadian = time.Hour * 360 / 12 * Math.PI / 180;
            double minRadian = time.Minute * 360 / 60 * Math.PI/180;
            double secRadian = time.Second * 360 / 60 * Math.PI / 180;

            double hourEndPointX = 30 * Math.Sin(hourRadian);
            double hourEndPointY = 30 * Math.Cos(hourRadian);

            double minuteEndPointX = 20 * Math.Sin(minRadian);
            double minuteEndPointY = 20 * Math.Cos(minRadian);

            double secondEndPointX = 10 * Math.Sin(secRadian);
            double secondEndPointY = 10 * Math.Cos(secRadian);

            Line lineHour = new Line();
            Line lineMinute = new Line();
            Line lineSecond = new Line();

            lineHour.X1 = 50;
            lineHour.Y1 = 50;
            lineHour.X2 = hourEndPointX;
            lineHour.Y2 = hourEndPointY;
            lineHour.Stroke = brush;
            lineHour.StrokeThickness = 1;

            lineMinute.X1 = 50;
            lineMinute.Y1 = 50;
            lineMinute.X2 = minuteEndPointX;
            lineMinute.Y2 = minuteEndPointY;
            lineMinute.Stroke = brush;
            lineMinute.StrokeThickness = 1;

            lineSecond.X1 = 50;
            lineSecond.Y1 = 50;
            lineSecond.X2 = secondEndPointX;
            lineSecond.Y2 = secondEndPointY;
            lineSecond.Stroke = brush;
            lineSecond.StrokeThickness = 1;
            
            analogClockCanvas.Children.Add(lineHour);
            analogClockCanvas.Children.Add(lineMinute);
            analogClockCanvas.Children.Add(lineSecond);
        }
    }
}
