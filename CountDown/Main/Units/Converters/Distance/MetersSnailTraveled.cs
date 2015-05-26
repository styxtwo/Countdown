using System;

namespace CountDown.Domain {
    class MetersSnailTraveled : UnitConverter {
        //The World Almanac and Book of Facts 1999. New Jersey: Primedia, 1998: 572 (Garden snail)
        private readonly static double M_PER_SECONDS = 0.013; 
        private UnitConverter seconds = new Seconds();
        public override double Convert(DateTime start, DateTime end) {
            return seconds.Convert(start, end) * M_PER_SECONDS;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Meters snail can travel"; }
        }
    }
}

