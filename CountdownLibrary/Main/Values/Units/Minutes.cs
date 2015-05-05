using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Minutes : Unit {
        public override double Convert(Date date) {
            return date.TimeLeft.TotalMinutes;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string Name {
            get { return "Minutes"; }
        }

        public override double TimerInterval {
            get { return TimeConstants.MS_IN_SECOND; }
        }

        public override UnitType UnitType {
            get { return UnitType.Minutes; }
        }

        public override String[] FunFacts {
            get {
                String[] facts = { "An hour contains 60 minutes.",
                           "A minute on rare occasions has 59 or 61 seconds, a consequence of leap seconds."};
                return facts;
            }
        }
    }
}
