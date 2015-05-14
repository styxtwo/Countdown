using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.Extensions;

namespace CountDown.Gui {
    class IconContextMenu : ContextMenu {
        public event Action OpenClicked;
        public event Action ExitClicked;

        private MenuItem open;
        private MenuItem exit;
        public IconContextMenu() {
            open = new MenuItem("Open");
            exit = new MenuItem("Exit");

            MenuItems.Add(open);
            MenuItems.Add(exit);

            open.Click += open_Click;
            exit.Click += exit_Click;
        }

        private void open_Click(object sender, EventArgs e) {
            OpenClicked.NullSafeInvoke();
        }

        private void exit_Click(object sender, EventArgs e) {
            ExitClicked.NullSafeInvoke();
        }

        public void DisposeMenu() {
            open.Click -= open_Click;
            exit.Click -= exit_Click;
            this.Dispose();
        }
    }
}
