using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class ElephantGestationPeriods : UnitInfo {
        private double gestationPeriodInDays = 670;
        public override double Convert(DateTime start, DateTime end) {
            return (end - start).TotalDays / gestationPeriodInDays;
        }

        public override int Decimals {
            get { return 2; }
        }

        public override string UnitName {
            get { return "Elephant Gestation Periods"; }
        }
    }
}

