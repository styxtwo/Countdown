namespace GUI {
    partial class MainScreen {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Date = new System.Windows.Forms.Label();
            this.UnitValue = new System.Windows.Forms.Label();
            this.DateName = new System.Windows.Forms.Label();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoSize = true;
            this.layoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Controls.Add(this.Date, 0, 2);
            this.layoutPanel.Controls.Add(this.UnitValue, 0, 1);
            this.layoutPanel.Controls.Add(this.DateName, 0, 0);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.16049F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.83951F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(207, 182);
            this.layoutPanel.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Date.AutoSize = true;
            this.Date.Location = new System.Drawing.Point(176, 162);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(28, 13);
            this.Date.TabIndex = 3;
            this.Date.Text = "date";
            // 
            // UnitValue
            // 
            this.UnitValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnitValue.AutoSize = true;
            this.UnitValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitValue.ForeColor = System.Drawing.Color.Crimson;
            this.UnitValue.Location = new System.Drawing.Point(89, 44);
            this.UnitValue.Name = "UnitValue";
            this.UnitValue.Size = new System.Drawing.Size(29, 32);
            this.UnitValue.TabIndex = 0;
            this.UnitValue.Text = "0";
            this.UnitValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DateName
            // 
            this.DateName.AutoSize = true;
            this.DateName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.DateName.Location = new System.Drawing.Point(3, 0);
            this.DateName.Name = "DateName";
            this.DateName.Size = new System.Drawing.Size(94, 21);
            this.DateName.TabIndex = 4;
            this.DateName.Text = "Event Name";
            this.DateName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem2,
            this.menuItem3});
            this.menuItem1.Text = "Edit";
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 0;
            this.menuItem2.Text = "New";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.Text = "Options";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 182);
            this.Controls.Add(this.layoutPanel);
            this.Menu = this.mainMenu1;
            this.Name = "MainScreen";
            this.Text = "Countdown";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.Label UnitValue;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label DateName;
    }
}

