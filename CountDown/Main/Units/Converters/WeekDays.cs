﻿using System;

namespace CountDown.Domain {
    class WeekDays : UnitConverter {
        public override double Convert(DateTime start, DateTime end) {
            double weekDays = 1 + ((end - start).TotalDays * 5 -
                (start.DayOfWeek - end.DayOfWeek) * 2) / 7;

            if (end.DayOfWeek == DayOfWeek.Saturday) weekDays--;
            if (start.DayOfWeek == DayOfWeek.Sunday) weekDays--;

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
