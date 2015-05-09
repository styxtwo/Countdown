using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDownLibrary {
    class Date : IDate {
        public event Action DateChanged;
        public event Action NameChanged;

        private DateTime dateTime;
        public DateTime DateTime {
            get{
                return dateTime;
            }
            set {
                if (dateTime != value) {
                    DateChanged.NullSafeInvoke();
                    dateTime = value;
                }
            }
        }

        private String name;
        public String Name {
            get {
                return name;
            }
            set {
                if (name != value) {
                    NameChanged.NullSafeInvoke();
                    name = value;
                }
            }
        }
    }
}
