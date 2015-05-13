using CountDown.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountDown.Domain.Api;
using System.Drawing;

namespace CountDown.Gui {
    public class MainGui {
        private ICountDown countDown;
        private DisplayDataList data;
        public MainGui(ICountDown countDown) {
            this.countDown = countDown;
            this.data = new DisplayDataList(countDown);
            Start();
        }
        
        [STAThread]
        private void Start() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen(data, countDown));
        }
    }
}
