using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public class Weeks : IConverter {
        public double Convert(TimeSpan timeSpan) {
            return timeSpan.TotalDays / 7;
        }

        public string Unit() {
            return "Weeks";
        }
    }
}
