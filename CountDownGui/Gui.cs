using CountDownLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public class Gui {
        private ICountDown countDown;
        private MainScreen mainScreen;
        public Gui(ICountDown countDown) {
            this.countDown = countDown;
            Init();
            mainScreen = new MainScreen(countDown);
            Start();
        }
        [STAThread]
        private void Init() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        }

        [STAThread]
        private void Start() {
            Application.Run(mainScreen);
        }
    }
}
