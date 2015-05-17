using System;
using System.Drawing;
using System.Windows.Forms;
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
            UpdateSelected();
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
            this.UnitValue.Text = dataList.Current().UnitValue;
            this.UnitName.Text = dataList.Current().UnitName;
        }

        public void UpdateSelected() {
            if (dataList.Current().IsSelected()) {
                SelectButton.Checked = true;
                UnitValue.ForeColor = Color.Orange;
                return;
            }
            SelectButton.Checked = false;
            UnitValue.ForeColor = Color.OliveDrab;
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
            UpdateSelected();
        }

        private void Next_Click(object sender, EventArgs e) {
            dataList.Next();
            UpdateSelected();
        }

        private void Random_Click(object sender, EventArgs e) {
            dataList.Random();
            UpdateSelected();
        }

        private void Options_Click(object sender, EventArgs e) {
            selectionScreen.Show();
        }

        private void SelectButton_Clicked(object sender, EventArgs e) {
            dataList.Current().Select();
            UpdateSelected();
        }
    }
}
