using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public class WeekDays : IConverter {
        public double Convert(TimeSpan timeSpan) {
            DateTime start = DateTime.Now;
            DateTime end = start + timeSpan;
            double weekDays = 1 + ((end - start).TotalDays * 5 -
                (start.DayOfWeek - end.DayOfWeek) * 2) / 7;

            if ((int)end.DayOfWeek == 6) weekDays--;
            if ((int)end.DayOfWeek == 0) weekDays--;

            return weekDays;
        }

        public string Unit() {
            return "Week Days";
        }
    }
}
