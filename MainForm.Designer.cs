namespace Udpit {
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
      this.settingsGroupBox = new System.Windows.Forms.GroupBox();
      this.SuspendLayout();
      // 
      // settingsGroupBox
      // 
      this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.settingsGroupBox.Location = new System.Drawing.Point(13, 12);
      this.settingsGroupBox.Name = "settingsGroupBox";
      this.settingsGroupBox.Size = new System.Drawing.Size(259, 101);
      this.settingsGroupBox.TabIndex = 0;
      this.settingsGroupBox.TabStop = false;
      this.settingsGroupBox.Text = "Settings";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.settingsGroupBox);
      this.Name = "MainForm";
      this.Text = "Udpit";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox settingsGroupBox;
  }
}