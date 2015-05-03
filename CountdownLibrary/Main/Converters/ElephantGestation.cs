using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public class ElephantGestations : IConverter {
        private double gestationPeriodInDays = 670;
        public double Convert(TimeSpan timeSpan) {
            return timeSpan.TotalDays / gestationPeriodInDays;
        }

        public string Unit() {
            return "Elephant Gestation Periods";
        }
    }
}
