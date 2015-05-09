using CountDownLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI {
    class DisplayData {
        public event Action DataChangedEvent;

        private IUnitTime unitTime;
        private IDate date;

        public String UnitValue { get; private set; }
        public String DateName { get; private set; }
        public String Date { get; private set; }

        public DisplayData(ICountDown countDown, Unit unit) {
            this.unitTime = countDown.RemainingTime(unit);
            this.date = countDown.Date;

            unitTime.Changed += Update;
            Update(unitTime);
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
            UnitValue = value + "\n" + unitTime.Info.UnitName;
        }

        public void Dispose() {
           unitTime.Changed -= Update;
        }
     }
}
