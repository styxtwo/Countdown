using System;

namespace CountDown.Domain {
    class Seconds : UnitConverter {
        public override double Convert(DateTime start, DateTime end) {
            return (end - start).TotalSeconds;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Seconds"; }
        }
    }
}
