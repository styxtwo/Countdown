using CountDown.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountDown.Domain.Api;

namespace CountDown.Gui {
    public partial class MainScreen : Form {
        delegate void UpdateCallback();
        private DisplayDataList dataList;
        private DisplayData data;
        private ICountDown countDown;

        public MainScreen(DisplayDataList dataList, ICountDown countDown) {
            InitializeComponent();
            this.countDown = countDown;
            this.dataList = dataList;
            this.data = dataList.Current();
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
            this.UnitName.Text = data.UnitName;
        }

        private void Previous_Click(object sender, EventArgs e) {
            data = dataList.Previous();
            DataChanged();
        }

        private void Next_Click(object sender, EventArgs e) {
            data = dataList.Next();
            DataChanged();
        }

        private void Random_Click(object sender, EventArgs e) {
            data = dataList.Random();
            DataChanged();
        }

        private void Options_Click(object sender, EventArgs e) {
            DateSelectionScreen screen = new DateSelectionScreen(countDown);
            screen.ShowDialog();
        }
    }
}
