using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    class CountDown : ICountDown {
        private Date date;
        private RemainingTime remainingTime;
        public CountDown() {
            date = new Date();
            remainingTime = new RemainingTime(date);
        }

        public IUnitTime RemainingTime(Unit unit) {
            return remainingTime.InUnit(unit);
        }
        
        public IDate Date {
            get {
                return date; 
            }
        }
    }
}
