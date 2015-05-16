namespace CountDown.Gui {
    partial class MainForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Random = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Previous = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.UnitValue = new System.Windows.Forms.Label();
            this.UnitName = new System.Windows.Forms.Label();
            this.layoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoSize = true;
            this.layoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.layoutPanel.ColumnCount = 1;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutPanel.Controls.Add(this.panel1, 0, 2);
            this.layoutPanel.Controls.Add(this.UnitValue, 0, 0);
            this.layoutPanel.Controls.Add(this.UnitName, 0, 1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.16049F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(213, 119);
            this.layoutPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Random);
            this.panel1.Controls.Add(this.Options);
            this.panel1.Controls.Add(this.Previous);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 50);
            this.panel1.TabIndex = 4;
            // 
            // Random
            // 
            this.Random.Location = new System.Drawing.Point(156, 3);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(45, 45);
            this.Random.TabIndex = 8;
            this.Random.Text = "R";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.Click += new System.EventHandler(this.Random_Click);
            // 
            // Options
            // 
            this.Options.Location = new System.Drawing.Point(3, 3);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(45, 45);
            this.Options.TabIndex = 7;
            this.Options.Text = "Date";
            this.Options.UseVisualStyleBackColor = true;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            // 
            // Previous
            // 
            this.Previous.Location = new System.Drawing.Point(54, 3);
            this.Previous.Name = "Previous";
            this.Previous.Size = new System.Drawing.Size(45, 45);
            this.Previous.TabIndex = 6;
            this.Previous.Text = "<-";
            this.Previous.UseVisualStyleBackColor = true;
            this.Previous.Click += new System.EventHandler(this.Previous_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(105, 3);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(45, 45);
            this.Next.TabIndex = 5;
            this.Next.Text = "->";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // UnitValue
            // 
            this.UnitValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnitValue.AutoSize = true;
            this.UnitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitValue.ForeColor = System.Drawing.Color.OliveDrab;
            this.UnitValue.Location = new System.Drawing.Point(67, 6);
            this.UnitValue.Name = "UnitValue";
            this.UnitValue.Size = new System.Drawing.Size(79, 29);
            this.UnitValue.TabIndex = 0;
            this.UnitValue.Text = "label1";
            // 
            // UnitName
            // 
            this.UnitName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UnitName.AutoSize = true;
            this.UnitName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitName.Location = new System.Drawing.Point(86, 41);
            this.UnitName.Name = "UnitName";
            this.UnitName.Size = new System.Drawing.Size(41, 13);
            this.UnitName.TabIndex = 1;
            this.UnitName.Text = "label2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 119);
            this.Controls.Add(this.layoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private System.Windows.Forms.Label UnitValue;
        private System.Windows.Forms.Label UnitName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Random;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Button Previous;
        private System.Windows.Forms.Button Next;
    }
}

