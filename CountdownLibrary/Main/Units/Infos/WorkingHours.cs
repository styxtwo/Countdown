using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class WorkingHours : UnitInfo{
        private static readonly int WORKING_HOURS_IN_DAY = 8;

        private UnitInfo weekDays = new WeekDays();

        public override double Convert(DateTime start, DateTime end) {
            return weekDays.Convert(start, end) * WORKING_HOURS_IN_DAY;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Working Hours"; }
        }
    }
}
