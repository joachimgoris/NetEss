using System;
using System.Windows;

namespace _11_7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Wekker w = new Wekker();
        public MainWindow()
        {
            main = this;
            
            w.timer.Tick += w.Timer_Tick;
            w.Start_Timer();
            
        }

        internal static MainWindow main;

        internal string TijdLabel
        {
            get => tijdLabel.Content.ToString();
            set { Dispatcher.Invoke(() => { tijdLabel.Content = value; }); }
        }

        internal string TijdTextbox
        {
            get => tijdTextbox.Text;
            set { Dispatcher.Invoke(() => { tijdTextbox.Text = value; }); }
        }

        private void alarmButton_Click(object sender, RoutedEventArgs e)
        {
            w.BeepAlarm();
        }
    }
}
