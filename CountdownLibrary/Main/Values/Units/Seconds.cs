using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Seconds : Unit {
        public override double Convert(Date date) {
            return date.TimeLeft.TotalSeconds;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string Name {
            get { return "Seconds"; }
        }

        public override double TimerInterval {
            get { return TimeConstants.MS_IN_SECOND / 10; }
        }

        public override UnitType UnitType {
            get { return UnitType.Seconds; }
        }

        public override String[] FunFacts {
            get {
                String[] facts = { "" };
                return facts;
            }
        }
    }
}
