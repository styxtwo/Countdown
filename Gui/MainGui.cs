using CountDown.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountDown.Domain.Api;
using System.Drawing;
using Utilities.Extensions;
using System.Threading;

namespace CountDown.Gui {
    public class MainGui {
        public event Action Exit;
        private ICountDown countDown;

        private DisplayDataList data;
        private DateSelectionForm dateSelectionForm;
        private IconHandler iconHandler;
        private MainForm mainForm;
        public MainGui(ICountDown countDown) {
            this.countDown = countDown;
            this.data = new DisplayDataList(countDown, Unit.Days);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            iconHandler = new IconHandler(data);
            dateSelectionForm = new DateSelectionForm(countDown);
            mainForm = new MainForm(data, dateSelectionForm);
            
            mainForm.ClosedEvent += MainFormClosed;
            iconHandler.Hide += IconClosed;
            iconHandler.Exit += ExitEvent;
        }

        [STAThread]
        public void Start() {
            iconHandler.Show();
            Application.Run();
        }

        private void IconClosed() {
            mainForm.Show();
        }

        private void MainFormClosed() {
            iconHandler.Show();
        }

        private void ExitEvent() {
            Exit.NullSafeInvoke();
        }

        public void Dispose() {
            Exit = null;
            mainForm.ClosedEvent -= MainFormClosed;
            iconHandler.Hide -= IconClosed;
            iconHandler.Exit -= ExitEvent;

            data.Dispose();
            dateSelectionForm.Dispose();
            iconHandler.Dispose();
            mainForm.Dispose();
            Application.Exit();
        }
    }
}
