using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class UnitTime : IUnitTime {
        public event Action<IUnitTime> Changed;
        private UnitInfo info;       
        private double value;
        private Date date;

        public UnitTime(Date date, UnitInfo info) {
            this.date = date;
            this.info = info;
        }

        public void Update() {
            DateTime start = DateTime.Now;
            DateTime end = date.DateTime;

            double oldValue = value;
            value = Math.Round(info.Convert(start, end), info.Decimals);

            if (value != oldValue) {
                Changed.NullSafeInvoke(this);
            }
        }

        public IUnitInfo Info {
            get {
                return info;
            }
        }
        public double Value {
            get {
                Update();
                return value;
            }
        }
    }
}
