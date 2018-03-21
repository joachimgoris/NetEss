using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace _11_7
{
    internal abstract class Wekker
    {
        protected DateTime TijdNu;
        private const int AlarmDuur = 10;
        protected DispatcherTimer timer;


        protected int GetAlarmDuur()
        {
            return AlarmDuur;
        }

        
    }
}
