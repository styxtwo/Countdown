using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CountDownLibrary {
    class RemainingTime {
        private IDictionary<Unit, UnitTime> unitTimes = new Dictionary<Unit, UnitTime>();
        private Poller poller;

        public RemainingTime(Date date) {
            poller = new Poller();
            poller.Poll += Update;
            AddUnits(date);
        }

        private void AddUnits(Date date) {
            AddUnitTime(date, Unit.Seconds, new Seconds());
            AddUnitTime(date, Unit.Minutes, new Minutes());
            AddUnitTime(date, Unit.WorkingHours, new WorkingHours());
            AddUnitTime(date, Unit.WeekDays, new WeekDays());
            AddUnitTime(date, Unit.Days, new Days());
            AddUnitTime(date, Unit.Weeks, new Weeks());
            AddUnitTime(date, Unit.ElephantGestationPeriods, new ElephantGestationPeriods());
        }

        private void AddUnitTime(Date date, Unit unit, UnitInfo info) {
            unitTimes.Add(unit, new UnitTime(date, info));
        } 

        public void Update() {
            foreach (UnitTime time in unitTimes.Values) {
                time.Update();
            }
        }

        public IUnitTime InUnit(Unit unit) {
            UnitTime time;
            unitTimes.TryGetValue(unit, out time);
            if (time == null) {
                throw (new ArgumentException("No Object available for this unit. This should not happen."));
            }
            return time;
        }
    }
}