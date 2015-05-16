using System;

namespace CountDown.Domain {
    //https://en.wikipedia.org/wiki/Jiffy_%28time%29
    class Jiffies : UnitConverter {
        private UnitConverter seconds = new Seconds();
        public override double Convert(DateTime start, DateTime end) {
            return seconds.Convert(start, end) * 60;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Jiffies"; }
        }
    }
}
