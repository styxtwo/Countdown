﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Weeks : Unit {
        private String[]
            funFacts = { "",
                           ""};

        public override double Convert(Date date) {
            return date.TimeLeft.TotalDays / 7;
        }

        public override int Decimals {
            get { return 2; }
        }

        public override string Name {
            get { return "Weeks"; }
        }

        public override double TimerInterval {
            get { return TimeConstants.MS_IN_HOUR; }
        }

        public override UnitType UnitType {
            get { return UnitType.Weeks; }
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
