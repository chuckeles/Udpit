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
      this.destinationLabel = new System.Windows.Forms.Label();
      this.destinationTextBox = new System.Windows.Forms.TextBox();
      this.settingsGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // settingsGroupBox
      // 
      this.settingsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.settingsGroupBox.Controls.Add(this.destinationTextBox);
      this.settingsGroupBox.Controls.Add(this.destinationLabel);
      this.settingsGroupBox.Location = new System.Drawing.Point(13, 12);
      this.settingsGroupBox.Name = "settingsGroupBox";
      this.settingsGroupBox.Size = new System.Drawing.Size(259, 101);
      this.settingsGroupBox.TabIndex = 0;
      this.settingsGroupBox.TabStop = false;
      this.settingsGroupBox.Text = "Settings";
      // 
      // destinationLabel
      // 
      this.destinationLabel.AutoSize = true;
      this.destinationLabel.Location = new System.Drawing.Point(6, 22);
      this.destinationLabel.Name = "destinationLabel";
      this.destinationLabel.Size = new System.Drawing.Size(60, 13);
      this.destinationLabel.TabIndex = 0;
      this.destinationLabel.Text = "Destination";
      // 
      // destinationTextBox
      // 
      this.destinationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.destinationTextBox.Location = new System.Drawing.Point(72, 19);
      this.destinationTextBox.Name = "destinationTextBox";
      this.destinationTextBox.Size = new System.Drawing.Size(181, 20);
      this.destinationTextBox.TabIndex = 1;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.settingsGroupBox);
      this.MinimumSize = new System.Drawing.Size(300, 300);
      this.Name = "MainForm";
      this.Text = "Udpit";
      this.settingsGroupBox.ResumeLayout(false);
      this.settingsGroupBox.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox settingsGroupBox;
    private System.Windows.Forms.Label destinationLabel;
    private System.Windows.Forms.TextBox destinationTextBox;
  }
}