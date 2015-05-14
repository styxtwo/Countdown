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
using System.Drawing;
using System.ComponentModel;
using Microsoft.Win32;

namespace CountDown.Main {
    class Program {
        private static Program program;
        static void Main(string[] args) {
            program = new Program(args);
        }

        private MainGui gui;
        private Printer printer;
        private ICountDown countDown;
        private Persistance xmlPersistance;

        public Program(string[] args) {
            if (!args.Any() || args[0] != "debug") {
                AddRegistryKey();
            }
            Start();
        }

        private void Start() {
            xmlPersistance = new Persistance();
            countDown = CountDownFactory.Create(xmlPersistance.Data);
            printer = new Printer(countDown);
            gui = new MainGui(countDown);

            xmlPersistance.UpdateOnChange(countDown);
            gui.Exit += Dispose;

            Thread guiThread = new Thread(gui.Start);
            guiThread.Start();
        }

        private void AddRegistryKey() {
            String keyLocation = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            String appLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            RegistryKey key = Registry.CurrentUser.OpenSubKey(keyLocation, true);
            key.SetValue("LongTermCountDown", appLocation);
        }

        public void Dispose() {
            gui.Dispose();
            printer.Dispose();
            xmlPersistance.Dispose();
        }
    }
}
