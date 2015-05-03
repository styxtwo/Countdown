using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Date : IDate {
        public DateTime DateTime { get; set; }
        public String Name { get; set; }
        public TimeSpan TimeLeft {
            get {
                return DateTime - DateTime.Now;
            }
        }
    }
}
