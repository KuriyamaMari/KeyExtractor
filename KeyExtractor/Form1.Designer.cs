namespace KeyExtractor
{
    partial class Form1
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
      this.buttonExtractKeys = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.comboBoxMode = new System.Windows.Forms.ComboBox();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // buttonExtractKeys
      // 
      this.buttonExtractKeys.Location = new System.Drawing.Point(172, 7);
      this.buttonExtractKeys.Name = "buttonExtractKeys";
      this.buttonExtractKeys.Size = new System.Drawing.Size(75, 21);
      this.buttonExtractKeys.TabIndex = 1;
      this.buttonExtractKeys.Text = "Extract Keys";
      this.buttonExtractKeys.UseVisualStyleBackColor = true;
      this.buttonExtractKeys.Click += new System.EventHandler(this.buttonExtractKeys_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 33);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(283, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
      this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
      // 
      // comboBoxMode
      // 
      this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBoxMode.FormattingEnabled = true;
      this.comboBoxMode.Items.AddRange(new object[] {
            "Classic",
            "ASF"});
      this.comboBoxMode.Location = new System.Drawing.Point(41, 7);
      this.comboBoxMode.Name = "comboBoxMode";
      this.comboBoxMode.Size = new System.Drawing.Size(85, 20);
      this.comboBoxMode.TabIndex = 3;
      this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(283, 55);
      this.Controls.Add(this.comboBoxMode);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.buttonExtractKeys);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "Key extractor";
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonExtractKeys;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox comboBoxMode;
    }
}

