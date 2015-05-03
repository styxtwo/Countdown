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
            countDown.AddObserver(ConverterType.Minutes, Print);
            countDown.AddObserver(ConverterType.Weeks, Print);
        }

        public void Print(IConverter converter) {
            System.Diagnostics.Debug.WriteLine(countDown.Date.Name + " in " + converter.Value + " " + converter.Unit());
        }
    }
}
