using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    class Value : IValue {
        private Action<IValue> changed;
        private double value = -1;
        private Poller poller;
        private Unit unit;
        private Date date;

        public Value(Unit unit, Date date) {
            this.date = date;
            this.unit = unit;
            poller = new Poller(unit, Update);
        }

        public void Update() {
            double oldValue = value;
            value = Math.Round(unit.Convert(date), unit.Decimals);
            if (value < 0) {
                value = 0;
            }
            if (value != oldValue) {
                oldValue = value;
                changed.Invoke(this);
            }
        }

        public IUnit Unit {
            get { return unit; }
        }

        double IValue.Value {
            get {
                Update();
                return value; 
            }
        }

        public event Action<IValue> Changed {
            add {
                changed += value;
                if (!poller.IsRunning) {
                    poller.Start();
                    Update();
                }
            }
            remove {
                changed -= value;
                if (changed == null) {
                    poller.Stop();
                }
            }
        }
    }
}
