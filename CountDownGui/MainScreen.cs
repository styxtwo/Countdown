using CountDownLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public partial class MainScreen : Form {
        public MainScreen() {
            InitializeComponent();
        }

        public void Update(ICountDown countDown) {
            IConverter converter = new ElephantGestations();
            double elapsedTime = converter.Convert(countDown.TimeLeft);
            this.Time.Text = Math.Round(elapsedTime) + " " + converter.Unit();
            this.EventName.Text = countDown.Name;
            this.Date.Text = countDown.Date.ToShortDateString();
        }
    }
}
