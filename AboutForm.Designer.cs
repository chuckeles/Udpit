namespace Udpit {
  partial class AboutForm {
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
      this.aboutBox = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // aboutBox
      // 
      this.aboutBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.aboutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.aboutBox.Location = new System.Drawing.Point(12, 12);
      this.aboutBox.Name = "aboutBox";
      this.aboutBox.ReadOnly = true;
      this.aboutBox.Size = new System.Drawing.Size(160, 137);
      this.aboutBox.TabIndex = 0;
      this.aboutBox.TabStop = false;
      this.aboutBox.Text = "Udpit is a simple chatting application communicating over the UDP protocol.\n\nSour" +
    "ce code is on Github: https://github.com/chuckeles/Udpit.";
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(184, 161);
      this.Controls.Add(this.aboutBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutForm";
      this.Text = "about";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.RichTextBox aboutBox;
  }
}