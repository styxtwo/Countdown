using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    public class Seconds : IConverter {
        public double Convert(TimeSpan timeSpan) {
            return timeSpan.TotalSeconds;
        }

        public string Unit() {
            return "Seconds";
        }
    }
}
