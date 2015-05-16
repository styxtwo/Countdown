using System;

namespace CountDown.Domain {
    class BabiesBorn : UnitConverter {
        //data from http://www.ecology.com/birth-death-rates/
        private double BIRTHS_PER_DAY = 360000;
        private UnitConverter days = new Days();
        public override double Convert(DateTime start, DateTime end) {
            return days.Convert(start, end) * BIRTHS_PER_DAY;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Babies born"; }
        }
    }
}
