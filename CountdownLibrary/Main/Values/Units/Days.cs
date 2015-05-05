using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Days : Unit {
        private String[]
            funFacts = { "",
                           ""};

        public override double Convert(Date date) {
            return date.TimeLeft.TotalDays;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string Name {
            get { return "Days"; }
        }

        public override double TimerInterval {
            get { return TimeConstants.MS_IN_HOUR; }
        }

        public override UnitType UnitType {
            get { return UnitType.Days; }
        }

        public override String[] FunFacts {
            get {
                String[] facts = { "",
                           ""};
                return facts;
            }
        }
    }
}
