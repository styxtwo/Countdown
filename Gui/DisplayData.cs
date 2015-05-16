using CountDown.Domain;
using CountDown.Domain.Api;
using System;
using Utilities.Extensions;

namespace CountDown.Gui {
    public class DisplayData {
        public event Action DataChangedEvent;

        private IUnitTime unitTime;
        private IDate date;

        public String UnitValue { get; private set; }
        public String UnitName { get; private set; }
        public String DateName { get; private set; }
        public String Date { get; private set; }
        public Unit Unit { get; private set; }

        public DisplayData(ICountDown countDown, Unit unit) {
            this.Unit = unit;
            this.unitTime = countDown.RemainingTime(unit);
            this.date = countDown.Date;

            Setup();
            unitTime.ValueChanged += Update;
            Update(unitTime);
        }

        public void Setup() {
            UnitName = unitTime.Info.UnitName;
        }

        public void Update(IUnitTime unitTime) {
            ParseUnitValue(unitTime);
            DateName = date.Name;
            Date = date.DateTime.ToShortDateString();
            DataChangedEvent.NullSafeInvoke();
        }

        private void ParseUnitValue(IUnitTime unitTime) {
            double value = unitTime.Value;
            if (value < 0) {
                value = 0;
            }
            UnitValue = value.ToString();
        }

        public void Dispose() {
           unitTime.ValueChanged -= Update;
        }
     }
}
