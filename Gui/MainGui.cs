using CountDown.Domain;
using CountDown.Domain.Api;
using System;
using System.Windows.Forms;
using Utilities.Extensions;

namespace CountDown.Gui {
    public class MainGui {
        public event Action Exit;
        private ICountDown countDown;

        private DisplayDataList data;
        private DateSelectionForm dateSelectionForm;
        private IconHandler iconHandler;
        private MainForm mainForm;
        private bool showMain;
        public MainGui(ICountDown countDown, bool showMain, IDateData dateData) {
            this.countDown = countDown;
            this.data = new DisplayDataList(countDown, dateData.MainUnit);
            this.showMain = showMain;

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
            if (showMain) {
                mainForm.Show();
            }
            else {
                iconHandler.Show();
            }
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
