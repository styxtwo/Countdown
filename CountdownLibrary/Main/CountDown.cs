using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    class CountDown : ICountDown {
        private Date date;
        private Values converters;
        public CountDown() {
            date = new Date();
            converters = new Values(date);
        }

        public IValue GetValue(UnitType type) {
            return converters.GetValue(type);
        }

        public IDate Date {
            get {
                return date; 
            }
        }
    }
}
