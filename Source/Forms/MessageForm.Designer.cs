namespace Udpit {
  partial class MessageForm {
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
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.consoleBox = new System.Windows.Forms.TextBox();
      this.errorCheckBox = new System.Windows.Forms.CheckBox();
      this.closeButton = new System.Windows.Forms.Button();
      this.deleteButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // progressBar
      // 
      this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.progressBar.Location = new System.Drawing.Point(12, 12);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(360, 23);
      this.progressBar.TabIndex = 0;
      // 
      // consoleBox
      // 
      this.consoleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.consoleBox.Location = new System.Drawing.Point(12, 41);
      this.consoleBox.Multiline = true;
      this.consoleBox.Name = "consoleBox";
      this.consoleBox.ReadOnly = true;
      this.consoleBox.Size = new System.Drawing.Size(360, 379);
      this.consoleBox.TabIndex = 1;
      // 
      // errorCheckBox
      // 
      this.errorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.errorCheckBox.AutoSize = true;
      this.errorCheckBox.Location = new System.Drawing.Point(12, 430);
      this.errorCheckBox.Name = "errorCheckBox";
      this.errorCheckBox.Size = new System.Drawing.Size(148, 17);
      this.errorCheckBox.TabIndex = 2;
      this.errorCheckBox.Text = "Send corrupted fragments";
      this.errorCheckBox.UseVisualStyleBackColor = true;
      // 
      // closeButton
      // 
      this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.closeButton.Location = new System.Drawing.Point(297, 426);
      this.closeButton.Name = "closeButton";
      this.closeButton.Size = new System.Drawing.Size(75, 23);
      this.closeButton.TabIndex = 3;
      this.closeButton.Text = "Close";
      this.closeButton.UseVisualStyleBackColor = true;
      // 
      // deleteButton
      // 
      this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.deleteButton.Location = new System.Drawing.Point(216, 426);
      this.deleteButton.Name = "deleteButton";
      this.deleteButton.Size = new System.Drawing.Size(75, 23);
      this.deleteButton.TabIndex = 3;
      this.deleteButton.Text = "Delete";
      this.deleteButton.UseVisualStyleBackColor = true;
      // 
      // MessageForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 461);
      this.Controls.Add(this.deleteButton);
      this.Controls.Add(this.closeButton);
      this.Controls.Add(this.errorCheckBox);
      this.Controls.Add(this.consoleBox);
      this.Controls.Add(this.progressBar);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(600, 800);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(400, 300);
      this.Name = "MessageForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Message Information";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ProgressBar progressBar;
    private System.Windows.Forms.TextBox consoleBox;
    private System.Windows.Forms.CheckBox errorCheckBox;
    private System.Windows.Forms.Button closeButton;
    private System.Windows.Forms.Button deleteButton;
  }
}