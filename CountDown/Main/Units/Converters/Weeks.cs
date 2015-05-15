using System;

namespace CountDown.Domain {
    class Weeks : UnitConverter {
        public override double Convert(DateTime start, DateTime end) {
            return (end - start).TotalDays / 7;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Weeks"; }
        }
    }
}
