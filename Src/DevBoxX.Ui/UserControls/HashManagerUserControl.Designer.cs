namespace DevBoxX.Ui.UserControls
{
    partial class HashManagerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbText = new System.Windows.Forms.Label();
            this.tbxText = new System.Windows.Forms.TextBox();
            this.lbHashAlgorithm = new System.Windows.Forms.Label();
            this.cbxHashAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnHash = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.tbxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AccessibleName = "text";
            this.lbText.AutoSize = true;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(24, 13);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "text";
            // 
            // tbxText
            // 
            this.tbxText.AccessibleName = "text";
            this.tbxText.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbxText.Location = new System.Drawing.Point(24, 0);
            this.tbxText.Name = "tbxText";
            this.tbxText.Size = new System.Drawing.Size(100, 20);
            this.tbxText.TabIndex = 1;
            // 
            // lbHashAlgorithm
            // 
            this.lbHashAlgorithm.AccessibleName = "Hash algorithm";
            this.lbHashAlgorithm.AutoSize = true;
            this.lbHashAlgorithm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbHashAlgorithm.Location = new System.Drawing.Point(124, 0);
            this.lbHashAlgorithm.Name = "lbHashAlgorithm";
            this.lbHashAlgorithm.Size = new System.Drawing.Size(77, 13);
            this.lbHashAlgorithm.TabIndex = 2;
            this.lbHashAlgorithm.Text = "Hash algorithm";
            // 
            // cbxHashAlgorithm
            // 
            this.cbxHashAlgorithm.AccessibleName = "Hash algorithm";
            this.cbxHashAlgorithm.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxHashAlgorithm.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxHashAlgorithm.FormattingEnabled = true;
            this.cbxHashAlgorithm.Location = new System.Drawing.Point(201, 0);
            this.cbxHashAlgorithm.Name = "cbxHashAlgorithm";
            this.cbxHashAlgorithm.Size = new System.Drawing.Size(121, 21);
            this.cbxHashAlgorithm.TabIndex = 3;
            // 
            // btnHash
            // 
            this.btnHash.AccessibleName = "hash";
            this.btnHash.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHash.Location = new System.Drawing.Point(322, 0);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(75, 150);
            this.btnHash.TabIndex = 4;
            this.btnHash.Text = "hash";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // lbResult
            // 
            this.lbResult.AccessibleName = "result";
            this.lbResult.AutoSize = true;
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbResult.Location = new System.Drawing.Point(118, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(32, 13);
            this.lbResult.TabIndex = 5;
            this.lbResult.Text = "result";
            // 
            // tbxResult
            // 
            this.tbxResult.AccessibleName = "result";
            this.tbxResult.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbxResult.Location = new System.Drawing.Point(18, 0);
            this.tbxResult.Name = "tbxResult";
            this.tbxResult.ReadOnly = true;
            this.tbxResult.Size = new System.Drawing.Size(100, 20);
            this.tbxResult.TabIndex = 6;
            // 
            // HashManagerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbxResult);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.cbxHashAlgorithm);
            this.Controls.Add(this.lbHashAlgorithm);
            this.Controls.Add(this.tbxText);
            this.Controls.Add(this.lbText);
            this.Name = "HashManagerUserControl";
            this.Load += new System.EventHandler(this.HashManagerUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbxText;
        private System.Windows.Forms.Label lbHashAlgorithm;
        private System.Windows.Forms.ComboBox cbxHashAlgorithm;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.TextBox tbxResult;
    }
}
