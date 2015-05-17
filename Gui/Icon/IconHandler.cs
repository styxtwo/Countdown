using System;
using System.Windows.Forms;
using Utilities.Extensions;

namespace CountDown.Gui {
    public class IconHandler {
        public event Action Hide;
        public event Action Exit;
        private DisplayDataList data;
        private NotifyIconWrapper icon;
        private IconContextMenu menu;
        public IconHandler(DisplayDataList data) {
            this.data = data;

            menu = new IconContextMenu();
            icon = new NotifyIconWrapper(menu);

            AddObservers();
        }

        private void AddObservers() {
            icon.DoubleClick += HideIcon;
            data.CurrentDataChangedEvent += SelectedDataChangedEvent;
            menu.OpenClicked += HideIcon;
            menu.ExitClicked += ExitEvent; 
        }

        private void ClearObservers() {
            icon.DoubleClick -= HideIcon;
            data.CurrentDataChangedEvent -= SelectedDataChangedEvent;
            menu.OpenClicked -= HideIcon;
            menu.ExitClicked -= ExitEvent;
        }

        private void ExitEvent() {
            Exit.NullSafeInvoke();
        }

        public void Show() {
            icon.Show();
        }

        private void HideIcon() {
            icon.Hide();
            Hide.NullSafeInvoke();
        }

        void SelectedDataChangedEvent() {
            String text = data.Current().UnitValue + " " + data.Current().UnitName + " Remaining.";
            icon.ShowBalloon(text, "Countdown", ToolTipIcon.Info, 200);
        }

        internal void Dispose() {
            ClearObservers();
            Hide = null;
            Exit = null;
            icon.Dispose();
            menu.DisposeMenu();
        }
    }
}
