using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDown.Domain {
    class WeekDays : UnitConverter {
        public override double Convert(DateTime start, DateTime end) {
            double weekDays = 1 + ((end - start).TotalDays * 5 -
                (start.DayOfWeek - end.DayOfWeek) * 2) / 7;

            if ((int)end.DayOfWeek == 6) weekDays--;
            if ((int)end.DayOfWeek == 0) weekDays--;

            return weekDays;
        }

        public override int Decimals {
            get { return 0; }
        }

        public override string UnitName {
            get { return "Week Days"; }
        }
    }
}
