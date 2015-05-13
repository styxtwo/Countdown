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
    public partial class DateSelectionScreen : Form {
        private ICountDown countDown;
        public DateSelectionScreen(ICountDown countDown) {
            InitializeComponent();
            this.countDown = countDown;
            dateTimePicker.Value = countDown.Date.DateTime;
            nameTextBox.Text = countDown.Date.Name;
        }

        private void OkButton_Click(object sender, EventArgs e) {
            countDown.Date.DateTime = dateTimePicker.Value;
            countDown.Date.Name = nameTextBox.Text; 
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
