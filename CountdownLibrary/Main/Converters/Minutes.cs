using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public class Minutes : IConverter {
        public double Convert(TimeSpan timeSpan) {
            return timeSpan.TotalMinutes;
        }

        public string Unit() {
            return "Minutes";
        }
    }
}
