using CountDown.Domain.Api;
using System;
using Utilities.Extensions;

namespace CountDown.Domain {
    class Date : IDate {
        public event Action DateChanged;
        public event Action NameChanged;
        public event Action MainUnitChanged;

        public Date(IDateData data) {
            dateTime = data.DateTime;
            name = data.Name;
            mainUnit = data.MainUnit;
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

        private Unit mainUnit;
        public Unit MainUnit {
            get {
                return mainUnit;
            }
            set {
                if (mainUnit != value) {
                    mainUnit = value;
                    MainUnitChanged.NullSafeInvoke();
                }
            }
        }
    }
}
