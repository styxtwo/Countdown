using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities.Extensions;
using CountDown.Domain.Api;

namespace CountDown.Domain {
    class Date : IDate {
        public event Action DateChanged;
        public event Action NameChanged;

        public Date(IDateData data) {
            dateTime = data.DateTime;
            name = data.Name;
        } 

        private DateTime dateTime;
        public DateTime DateTime {
            get{
                return dateTime;
            }
            set {
                if (dateTime != value) {
                    dateTime = value;
                    DateChanged.NullSafeInvoke();
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
                    name = value;
                    NameChanged.NullSafeInvoke();
                }
            }
        }
    }
}
