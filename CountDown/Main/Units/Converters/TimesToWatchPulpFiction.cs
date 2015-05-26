using System;

namespace CountDown.Domain {
    class TimesToWatchPulpFiction : UnitConverter {
        //running time 178 minutes.
        private readonly static double RUNNING_TIME_MINUTES = 178;
        private UnitConverter converter = new Minutes();
        public override double Convert(DateTime start, DateTime end) {
            return converter.Convert(start, end) / RUNNING_TIME_MINUTES;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Times you can watch Pulp Fiction"; }
        }
    }
}