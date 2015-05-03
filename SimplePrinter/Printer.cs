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
        private IConverter calculator;
        public Printer(ICountDown countDown) {
            calculator = new Weeks();
            this.countDown = countDown;           
        }

        public void Start() {
            while (true) {
                Print();
                Thread.Sleep(1000);
            }
        }

        public void Print() {
            double elapsedTime = calculator.Convert(countDown.TimeLeft);
            System.Diagnostics.Debug.WriteLine(countDown.Name + " in " + Math.Floor(elapsedTime) + " " + calculator.Unit());
        }
    }
}
