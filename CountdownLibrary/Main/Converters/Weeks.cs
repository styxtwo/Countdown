using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Weeks : Converter {
        public Weeks(IDate date)
            : base(date) {

        }

        public override double Convert(IDate date) {
            return date.TimeLeft.TotalDays / 7;
        }

        public override string Unit() {
            return "Weeks";
        }

        public override int Decimals {
            get { return 0; }
        }

        public override double TimerInterval {
            get {
                return 86400000;
            }
        }
    }
}
