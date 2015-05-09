using CountDownLibrary;
using GUI;
using SimplePrinter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LongCountDown {
    class Program {
        private static Program program;
        static void Main(string[] args) {
            program = new Program();
        }

        private Gui gui;
        private Printer printer;
        private ICountDown countDown;

        public Program() {
            countDown = CountDownFactory.Create();
            countDown.Date.DateTime = new DateTime(2015, 09, 01);
            countDown.Date.Name = "Leaving";

            printer = new Printer(countDown);
            gui = new Gui(countDown);

        }
    }
}
