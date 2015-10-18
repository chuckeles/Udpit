namespace Udpit {
  partial class OptionsForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsForm));
      this.cancelButton = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.nameBox = new System.Windows.Forms.TextBox();
      this.nameLabel = new System.Windows.Forms.Label();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      this.portBox = new System.Windows.Forms.NumericUpDown();
      this.portLabel = new System.Windows.Forms.Label();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.portBox)).BeginInit();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(215, 223);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 26);
      this.cancelButton.TabIndex = 4;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // saveButton
      // 
      this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveButton.Location = new System.Drawing.Point(113, 223);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(96, 26);
      this.saveButton.TabIndex = 3;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.Save);
      // 
      // nameBox
      // 
      this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.nameBox.Location = new System.Drawing.Point(113, 21);
      this.nameBox.Name = "nameBox";
      this.nameBox.Size = new System.Drawing.Size(177, 20);
      this.nameBox.TabIndex = 0;
      this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateName);
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(72, 24);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(35, 13);
      this.nameLabel.TabIndex = 5;
      this.nameLabel.Text = "Name";
      this.toolTip.SetToolTip(this.nameLabel, "Your name");
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // portBox
      // 
      this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.portBox.Location = new System.Drawing.Point(113, 47);
      this.portBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.portBox.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
      this.portBox.Name = "portBox";
      this.portBox.Size = new System.Drawing.Size(177, 20);
      this.portBox.TabIndex = 1;
      this.portBox.Value = new decimal(new int[] {
            56994,
            0,
            0,
            0});
      // 
      // portLabel
      // 
      this.portLabel.AutoSize = true;
      this.portLabel.Location = new System.Drawing.Point(81, 49);
      this.portLabel.Name = "portLabel";
      this.portLabel.Size = new System.Drawing.Size(26, 13);
      this.portLabel.TabIndex = 6;
      this.portLabel.Text = "Port";
      this.toolTip.SetToolTip(this.portLabel, "Port on which to communicate");
      // 
      // OptionsForm
      // 
      this.AcceptButton = this.saveButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(334, 261);
      this.Controls.Add(this.portBox);
      this.Controls.Add(this.portLabel);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.nameBox);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.cancelButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Options";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.portBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private System.Windows.Forms.NumericUpDown portBox;
    private System.Windows.Forms.Label portLabel;
    private System.Windows.Forms.ToolTip toolTip;
  }
}