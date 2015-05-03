using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    abstract class Converter : IConverter {
        private double oldValue = -1;
        private IDate date;
        private Timer timer = new Timer();

        public double Value { get; private set; }

        public Converter(IDate date) {
            this.date = date;
            timer.Elapsed += Update;
            timer.Interval = TimerInterval;            
        }

        public void Update(object source, ElapsedEventArgs e) {
            Value = Math.Round(Convert(date), Decimals);
            if (Value != oldValue) {
                Changed.Invoke(this);
                oldValue = Value;
            }
        }

        private Action<IConverter> changed;
        public Action<IConverter> Changed {
            get {
                return changed;
            }
            set {
                changed = value;
                if (changed == null) {
                    timer.Stop();
                }
                else {
                    timer.Start();
                    Update(this, null);
                }
            }
        }

        public abstract double Convert(IDate date);
        public abstract string Unit();
        public abstract int Decimals { get; }
        public abstract double TimerInterval { get; }
    }
}
