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
using Utilities.Extensions;

namespace CountDown.Gui {
    public partial class MainForm : Form {
        private delegate void UpdateCallback();
        public event Action ClosedEvent;

        private DisplayDataList dataList;
        private DateSelectionForm selectionScreen;

        public MainForm(DisplayDataList dataList, DateSelectionForm selectionScreen) {
            InitializeComponent();
            CustomInit();

            this.selectionScreen = selectionScreen;
            this.dataList = dataList;

            dataList.SelectedDataChangedEvent += DataChangedEvent;
            DataChangedEvent();
        }


        private void CustomInit() {
            MinimizeBox = false;
            MaximizeBox = false;
            this.FormClosing += MainScreen_Closing;
        }

        void DataChangedEvent() {
            if (this.InvokeRequired) {
                UpdateCallback d = new UpdateCallback(DataChangedEvent);
                this.Invoke(d);
                return;
            }
            this.UnitValue.Text = dataList.Selected().UnitValue;
            this.UnitName.Text = dataList.Selected().UnitName;
        }

        private void MainScreen_Closing(object sender, FormClosingEventArgs e) {
            if (e.CloseReason == CloseReason.UserClosing) {
                e.Cancel = true;
                Hide();
                ClosedEvent.NullSafeInvoke();
            }
        }

        private void Previous_Click(object sender, EventArgs e) {
            dataList.Previous();
        }

        private void Next_Click(object sender, EventArgs e) {
            dataList.Next();
        }

        private void Random_Click(object sender, EventArgs e) {
            dataList.Random();
        }

        private void Options_Click(object sender, EventArgs e) {
            selectionScreen.Show();
        }
    }
}
