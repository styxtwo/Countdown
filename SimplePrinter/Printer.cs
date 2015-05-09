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
            countDown.RemainingTime(Unit.Seconds).Changed += Print;
            //countDown.GetValue(UnitType.Weeks).Changed += Print;
        }

        public void Print(IUnitTime value) {
            System.Diagnostics.Debug.WriteLine(countDown.Date.Name + " in " + value.Value + " " + value.Info.UnitName);
        }
    }
}
