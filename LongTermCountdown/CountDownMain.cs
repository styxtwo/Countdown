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
    class CountDownMain {
        private MainGui gui;
        private Printer printer;
        private ICountDown countDown;

        public CountDownMain() {
            countDown = CountDownFactory.Create();
            countDown.Date.DateTime =  new DateTime(2015, 09, 01);
            countDown.Date.Name = "WEDDING";

            printer = new Printer(countDown);

            //gui = new MainGui(countDown);
            //Start(gui.Start);
            while (true) {
            }
        }

        public void Start(Action action, Boolean isBackground = false) {
            Thread thread = new Thread(new ThreadStart(action));
            thread.IsBackground = isBackground;
            thread.Start();
        }
    }
}
