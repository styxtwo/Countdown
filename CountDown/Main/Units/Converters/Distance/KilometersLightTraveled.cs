using System;

namespace CountDown.Domain {
    class KilometersLightTraveled : UnitConverter {
        private double KM_PER_SECONDS = 299792; 
        private UnitConverter seconds = new Seconds();
        public override double Convert(DateTime start, DateTime end) {
            return seconds.Convert(start, end) * KM_PER_SECONDS;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Kilometers light can travel"; }
        }
    }
}

