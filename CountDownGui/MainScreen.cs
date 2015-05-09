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
        delegate void UpdateCallback();
        private DisplayData data;
        
        public MainScreen(ICountDown countDown) {
            InitializeComponent();
            data = new DisplayData(countDown, Unit.Minutes);
            data.DataChangedEvent += DataChanged;
            DataChanged();
        }

        void DataChanged() {
            if (this.InvokeRequired) {
                UpdateCallback d = new UpdateCallback(DataChanged);
                this.Invoke(d);
                return;
            }
            this.UnitValue.Text = data.UnitValue;
            this.Date.Text = data.Date;
        }
    }
}
