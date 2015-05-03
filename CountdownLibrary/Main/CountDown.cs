using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class CountDown : ICountDown {
        public DateTime Date { get; set; }
        public String Name { get; set; }
        public TimeSpan TimeLeft {
            get {
                return Date - DateTime.Now;
            }
        }
    }
}
