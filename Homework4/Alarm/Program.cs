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
            Clock myClock = new Clock();
            myClock.AlarmEvent += ClockAlarm;          //注册响铃方法 
            myClock.TickEvent += ClockTick;            //注册滴答方法
            myClock.SetAlarm(11, 7, 10); 
            myClock.StartWork();
        }

        //响铃具体方法
        static public void ClockAlarm(object sender, AlarmEventArgs args)
        {
            Console.WriteLine($"ALARM! It's {args.Hour}:{args.Minute}:{args.Second} now!");
        }

        //滴答具体方法
        static public void ClockTick(object sender, TickEventArgs args)
        {
            Console.WriteLine($"Tick. It's {args.Hour}:{args.Minute}:{args.Second} now.");
        }
    }
}
