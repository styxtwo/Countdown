using CountDown.Domain;
using CountDown.Gui;
using SimplePrinter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CountDown.Domain.Api;
using XMLPersistence;

namespace CountDown.Main {
    class Program {
        private static Program program;
        static void Main(string[] args) {
            program = new Program();
        }

        private MainGui gui;
        private Printer printer;
        private ICountDown countDown;
        private Persistance xmlPersistance;

        public Program() {
            xmlPersistance = new Persistance();

            countDown = CountDownFactory.Create(xmlPersistance.Data);

            xmlPersistance.UpdateOnChange(countDown);
            printer = new Printer(countDown);
            gui = new MainGui(countDown);

        }
    }
}
