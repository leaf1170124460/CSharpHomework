using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock myClock = new Alarm.Clock();
            myClock.AlarmEvent += ClockAlarm;
            myClock.TickEvent += ClockTick;
            myClock.SetAlarm(10, 12, 50);
            myClock.StartWork();
        }

        static public void ClockAlarm(object sender, AlarmEventArgs args)
        {
            Console.WriteLine("ALARM!");
            Console.WriteLine($"It's {args.Hour}:{args.Minute}:{args.Second} now.");
        }

        static public void ClockTick(object sender, TickEventArgs args)
        {
            Console.WriteLine($"Tick. It's {args.Hour}:{args.Minute}:{args.Second} now.");
        }
    }
}
