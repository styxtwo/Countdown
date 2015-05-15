using System;

namespace CountDown.Domain {
    class Days : UnitConverter {
        public override double Convert(DateTime start, DateTime end) {
            return (end - start).TotalDays;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Days"; }
        }
    }
}
