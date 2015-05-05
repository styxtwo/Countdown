using CountDownLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI {
    class CountDownData {
        public event Action DataChangedEvent;

        private ICountDown countDown;
        private UnitType unitType;

        public String UnitValue { get; private set; }
        public String DateName { get; private set; }
        public String Date { get; private set; }
        public String Fact { get; private set; }

        public CountDownData(ICountDown countDown, UnitType type) {
            DataChangedEvent += delegate { };

            this.countDown = countDown;
            this.unitType = type;

            countDown.GetValue(unitType).Changed += Update;
            Update(countDown.GetValue(unitType));
        }

        public void Update(IValue value) {
            UnitValue = value.Value + "\n" + value.Unit.Name;
            DateName = countDown.Date.Name;
            Date = countDown.Date.DateTime.ToShortDateString();
            Fact = value.Unit.GetFunFact();

            DataChangedEvent();
        }

        public void Dispose() {
            countDown.GetValue(unitType).Changed -= Update;
        }

    }
}
