using CountDown.Domain;
using CountDown.Domain.Api;
using CountDown.Gui;
using SimplePrinter;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using XMLPersistence;

namespace CountDown.Main {
    class Program {
        private static Program program;
        static void Main(string[] args) {
            program = new Program(args);
        }
        private bool showGui;
        private MainGui gui;
        private Printer printer;
        private ICountDown countDown;
        private Persistance xmlPersistance;

        public Program(string[] args) {
            if (args.Contains("installer")) {
                Process.Start(Application.ExecutablePath, "after_install");
                return;
            }
            if (args.Contains("after_install")) {
                showGui = true;
            }
            Start();
        }

        private void Start() {
            xmlPersistance = new Persistance();
            countDown = CountDownFactory.Create(xmlPersistance.Data);
            printer = new Printer(countDown);
            gui = new MainGui(countDown, showGui);

            xmlPersistance.UpdateOnChange(countDown);
            gui.Exit += Dispose;

            Thread guiThread = new Thread(gui.Start);
            guiThread.Start();
        }

        public void Dispose() {
            gui.Dispose();
            printer.Dispose();
            xmlPersistance.Dispose();
        }
    }
}
