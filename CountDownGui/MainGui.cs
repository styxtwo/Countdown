using CountDownLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public class MainGui {
        private IDate countDown;
        private MainScreen mainScreen;
        public MainGui(IDate  countDown) {
            this.countDown = countDown;
        }
        
        [STAThread]
        public void Start() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainScreen = new MainScreen();
            mainScreen.Update(countDown);
            Application.Run(mainScreen);
        }
    }
}
