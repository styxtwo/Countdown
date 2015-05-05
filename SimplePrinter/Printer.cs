using CountDownLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimplePrinter {
    public class Printer {
        private ICountDown countDown;
        public Printer(ICountDown countDown) {
            this.countDown = countDown;
            countDown.GetValue(UnitType.Seconds).Changed += Print;
            //countDown.GetValue(UnitType.Weeks).Changed += Print;
            //countDown.GetValue(UnitType.Minutes).Changed += Print;
        }

        public void Print(IValue value) {
            System.Diagnostics.Debug.WriteLine(countDown.Date.Name + " in " + value.Value + " " + value.Unit.Name);
            //System.Diagnostics.Debug.WriteLine(unit.GetFunFact());
        }
    }
}
