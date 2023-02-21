namespace DevBoxX.Ui.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbToolsList = new System.Windows.Forms.Label();
            this.lvToolsList = new System.Windows.Forms.ListBox();
            this.plTools = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbToolsList
            // 
            this.lbToolsList.AccessibleName = "tools list";
            this.lbToolsList.AutoSize = true;
            this.lbToolsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbToolsList.Location = new System.Drawing.Point(0, 0);
            this.lbToolsList.Name = "lbToolsList";
            this.lbToolsList.Size = new System.Drawing.Size(44, 13);
            this.lbToolsList.TabIndex = 0;
            this.lbToolsList.Text = "tools list";
            // 
            // lvToolsList
            // 
            this.lvToolsList.AccessibleName = "tools list";
            this.lvToolsList.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvToolsList.FormattingEnabled = true;
            this.lvToolsList.Location = new System.Drawing.Point(44, 0);
            this.lvToolsList.Name = "lvToolsList";
            this.lvToolsList.Size = new System.Drawing.Size(120, 450);
            this.lvToolsList.Sorted = true;
            this.lvToolsList.TabIndex = 1;
            this.lvToolsList.SelectedIndexChanged += new System.EventHandler(this.lvToolsList_SelectedIndexChanged);
            // 
            // plTools
            // 
            this.plTools.Dock = System.Windows.Forms.DockStyle.Right;
            this.plTools.Location = new System.Drawing.Point(600, 0);
            this.plTools.Name = "plTools";
            this.plTools.Size = new System.Drawing.Size(200, 450);
            this.plTools.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AccessibleName = "dev boxX";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plTools);
            this.Controls.Add(this.lvToolsList);
            this.Controls.Add(this.lbToolsList);
            this.Name = "MainForm";
            this.Text = "dev boxX";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbToolsList;
        private System.Windows.Forms.ListBox lvToolsList;
        private System.Windows.Forms.Panel plTools;
    }
}