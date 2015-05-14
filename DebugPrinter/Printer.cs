using CountDown.Domain;
using CountDown.Domain.Api;
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
            countDown.RemainingTime(Unit.Weeks).ValueChanged += Print;
        }

        public void Print(IUnitTime value) {
            System.Diagnostics.Debug.WriteLine(countDown.Date.Name + " in " + value.Value + " " + value.Info.UnitName);
        }

        public void Dispose() {
            countDown.RemainingTime(Unit.Weeks).ValueChanged -= Print;
        }
    }
}
