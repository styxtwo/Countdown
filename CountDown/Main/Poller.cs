﻿using System;
using System.Timers;
using Utilities.Extensions;

namespace CountDown.Domain {
    class Poller{
        private static double MINIMUM_INTERVAL = 100;
        public event Action Poll;
        private Timer timer = new Timer();
        public Poller() {
            timer.Elapsed += Update;
            SetInterval(MINIMUM_INTERVAL);
            timer.Start();
        }

        public void SetInterval(double interval) {
            timer.Interval = interval;
        }

        private void Update(object source, ElapsedEventArgs e) {
            if (Poll != null) {
                Poll.NullSafeInvoke();
            }
        }
    }
}
