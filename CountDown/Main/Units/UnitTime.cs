using CountDown.Domain.Api;
using System;
using Utilities.Extensions;

namespace CountDown.Domain {
    class UnitTime : IUnitTime {
        public event Action<IUnitTime> ValueChanged;
        private UnitConverter converter;       
        private double value = -1;
        private Date date;

        public UnitTime(Date date, UnitConverter converter) {
            this.date = date;
            this.converter = converter;
        }

        public void Update() {
            DateTime start = DateTime.Now;
            DateTime end = date.DateTime;

            double oldValue = value;
            value = Math.Round(converter.Convert(start, end), converter.Decimals);

            if (value < 0) {
                value = 0;
            }

            if (value != oldValue) {
                ValueChanged.NullSafeInvoke(this);
            }
        }

        public IUnitInfo Info {
            get {
                return converter;
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
