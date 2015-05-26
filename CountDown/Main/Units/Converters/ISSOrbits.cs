using System;

namespace CountDown.Domain {
    class ISSOrbits : UnitConverter {
        //15.54 orbits per day
        //https://en.wikipedia.org/wiki/International_Space_Station
        private readonly static double MINUTES_PER_ORBIT = 92.66;
        private UnitConverter converter = new Minutes();
        public override double Convert(DateTime start, DateTime end) {
            return converter.Convert(start, end) / MINUTES_PER_ORBIT;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Times The ISS can orbit earth"; }
        }
    }
}