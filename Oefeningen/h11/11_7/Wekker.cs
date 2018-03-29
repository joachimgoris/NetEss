using System;
using System.Media;
using System.Windows.Threading;

namespace _11_7
{
    internal class Wekker
    {
        protected DateTime TijdNu = DateTime.Now;
        private const int AlarmDuur = 10;
        private DateTime StartAlarm;
        public DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer AlarmTimer = new DispatcherTimer();

        public void Start_Timer()
        {
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        protected int GetAlarmDuur()
        {
            return AlarmDuur;
        }

        public void Timer_Tick(object sender, EventArgs e)
        {
            TijdNu = DateTime.Now;
            MainWindow.main.TijdLabel = (TijdNu.Hour+" "+TijdNu.Minute+" "+TijdNu.Second);
        }

        public void BeepAlarm(int hour, int minute, int second)
        {
            if (TijdNu.Hour.Equals(hour) && TijdNu.Minute.Equals(minute) && TijdNu.Second.Equals(second))
            {
                AlarmTimer.Interval = new TimeSpan(0, 0, 0, 0, 500);
                AlarmTimer.Tick += Beep;
                AlarmTimer.Start();
                StartAlarm = TijdNu;
            }
        }

        public void Beep(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            if (TijdNu.Second.Equals(StartAlarm.Second + AlarmDuur))
            {
                AlarmTimer.Stop();
            }
            
        }
    }
}
