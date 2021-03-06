﻿using System;

namespace CountDown.Domain {
    class WorkingHours : UnitConverter{
        private static readonly int WORKING_HOURS_IN_DAY = 8;

        private UnitConverter weekDays = new WeekDays();

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
