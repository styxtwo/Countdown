using System;

namespace CountDown.Domain {
    class HeartBeats : UnitConverter {
        //Average heartbeat of 70 per minute
        private UnitConverter minutes = new Minutes();
        public override double Convert(DateTime start, DateTime end) {
            return minutes.Convert(start, end) * 70;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Heartbeats"; }
        }
    }
}
