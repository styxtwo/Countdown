using CountDown.Domain.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDown.Gui {
    public partial class DateSelectionForm : Form {
        private ICountDown countDown;
        public DateSelectionForm(ICountDown countDown) {
            InitializeComponent();
            CustomInit();
            this.countDown = countDown;
            dateTimePicker.Value = countDown.Date.DateTime;
            nameTextBox.Text = countDown.Date.Name;
        }
        private void CustomInit() {
            MinimizeBox = false;
            MaximizeBox = false;
        }

        private void OkButton_Click(object sender, EventArgs e) {
            countDown.Date.DateTime = dateTimePicker.Value;
            countDown.Date.Name = nameTextBox.Text;
            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.Hide();
        }
    }
}
