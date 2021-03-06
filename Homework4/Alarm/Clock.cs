﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Alarm
{
    class Clock
    {
        public event AlarmEventHandler AlarmEvent;
        public event TickEventHandler TickEvent;
        private int alarmHour;
        private int alarmMinute;
        private int alarmSecond;

        //设置闹钟时间
        public void SetAlarm(int alarmHour, int alarmMinute, int alarmSecond)
        {
            this.alarmHour = alarmHour;
            this.alarmMinute = alarmMinute;
            this.alarmSecond = alarmSecond;
        }

        //开始工作
        public void StartWork()
        {
            //事件为空直接退出
            if (TickEvent == null || AlarmEvent == null)
            {
                return;
            }

            while (true)
            {
                int hour=DateTime.Now.Hour;
                int minute= DateTime.Now.Minute;
                int second = DateTime.Now.Second;
                Tick(hour, minute, second);
                if (hour == this.alarmHour && minute == this.alarmMinute && second == this.alarmSecond)
                {
                    Alarm(hour, minute, second);
                }
                Thread.Sleep(1000);
            }
        }

        //响铃
        public void Alarm(int hour,int minute,int second)
        {
            AlarmEventArgs args = new AlarmEventArgs() { Hour = hour, Minute = minute, Second = second };
            AlarmEvent(this, args);
        }

        //滴答
        public void Tick(int hour, int minute, int second)
        {
            TickEventArgs args = new TickEventArgs() { Hour = hour, Minute = minute, Second = second };
            TickEvent(this, args);
        }
    }
}
