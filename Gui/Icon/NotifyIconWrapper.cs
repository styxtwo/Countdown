using System;
using System.Windows.Forms;
using Utilities.Extensions;

namespace CountDown.Gui {
    class NotifyIconWrapper {
        public event Action DoubleClick;
        private NotifyIcon icon;
        private ContextMenu menu;
        public NotifyIconWrapper(ContextMenu menu) {
            this.menu = menu;
        }

        public void Show() {
            if (icon != null) {
                return;
            }
            Create();
        }

        private void Create() {
            icon = new NotifyIcon();
            icon.DoubleClick += DoubleClickEvent;
            icon.Icon = Gui.Properties.Resources.CountDownIcon;
            icon.ContextMenu = menu;
            icon.Visible = true;
        }

        public void Hide() {
            DisposeIcon();
        }

        private void DisposeIcon() {
            if (icon == null) {
                return;
            }
            icon.Visible = false;
            icon.Dispose();
            icon.DoubleClick -= DoubleClickEvent;
            icon.ContextMenu = null;
            icon = null;
        }

        public void ShowBalloon(string text, string title, ToolTipIcon tooltipIcon, int duration) {
            if (icon == null) {
                return;
            }            
            icon.BalloonTipText = text;
            icon.BalloonTipTitle = title;
            icon.BalloonTipIcon = tooltipIcon;
            icon.ShowBalloonTip(duration);
        }

        private void DoubleClickEvent(object sender, EventArgs e) {
            DoubleClick.NullSafeInvoke();
        }

        public void Dispose() {
            DisposeIcon();
            DoubleClick = null;
        }
    }
}
