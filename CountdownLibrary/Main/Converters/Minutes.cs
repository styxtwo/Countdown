using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Minutes : Converter {
        public Minutes(IDate date)
            : base(date) {

        }
        public override double Convert(IDate date) {
            return date.TimeLeft.TotalMinutes;
        }

        public override string Unit() {
            return "Minutes";
        }

        public override int Decimals {
            get { return 2; }
        }

        public override double TimerInterval {
            get {
                return 500;
            }
        }
    }
}
