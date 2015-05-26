using CountDown.Domain.Api;
using System;
using System.Collections.Generic;

namespace CountDown.Domain {
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
            AddUnitTime(date, Unit.Hours, new Hours());
            AddUnitTime(date, Unit.KilometersLightTraveled, new KilometersLightTraveled());
            AddUnitTime(date, Unit.MetersSnailTraveled, new MetersSnailTraveled());
            AddUnitTime(date, Unit.ISSOrbits, new ISSOrbits());
            AddUnitTime(date, Unit.TimesToWatchPulpFiction, new TimesToWatchPulpFiction());
            AddUnitTime(date, Unit.Jiffies, new Jiffies());
            AddUnitTime(date, Unit.HeartBeats, new HeartBeats());
            AddUnitTime(date, Unit.BabiesBorn, new BabiesBorn());
        }

        private void AddUnitTime(Date date, Unit unit, UnitConverter converter) {
            unitTimes.Add(unit, new UnitTime(date, converter));
        } 

        private void Update() {
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