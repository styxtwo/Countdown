using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    class Poller{
        private static double MINIMUM_INTERVAL = 100;
        private Unit unit;
        private Action poll;
        private Timer timer = new Timer();
        public Poller(Unit unit, Action poll) {
            this.unit = unit;
            this.poll = poll;

            timer.Elapsed += Update;
            SetInterval();
        }

        private void SetInterval() {
            timer.Interval = unit.TimerInterval / Math.Pow(10, unit.Decimals);
            if (timer.Interval < MINIMUM_INTERVAL) {
                timer.Interval = MINIMUM_INTERVAL;
            }
        }
        
        public void Update(object source, ElapsedEventArgs e) {
            poll();
        }

        public void Start() {
            timer.Start();
        }

        public void Stop() {
            timer.Stop();
        }

        public bool IsRunning {
            get {
                return timer.Enabled;
            }
        }
    }
}
