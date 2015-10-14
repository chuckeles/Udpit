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
      this.sendPortBox = new System.Windows.Forms.NumericUpDown();
      this.receivePortBox = new System.Windows.Forms.NumericUpDown();
      this.sendPortLabel = new System.Windows.Forms.Label();
      this.receivePortLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.sendPortBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.receivePortBox)).BeginInit();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(215, 223);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 26);
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // saveButton
      // 
      this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveButton.Location = new System.Drawing.Point(113, 223);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(96, 26);
      this.saveButton.TabIndex = 0;
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
      this.nameBox.TabIndex = 2;
      this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateName);
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(72, 24);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(35, 13);
      this.nameLabel.TabIndex = 3;
      this.nameLabel.Text = "Name";
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // sendPortBox
      // 
      this.sendPortBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.sendPortBox.Location = new System.Drawing.Point(113, 47);
      this.sendPortBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.sendPortBox.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
      this.sendPortBox.Name = "sendPortBox";
      this.sendPortBox.Size = new System.Drawing.Size(177, 20);
      this.sendPortBox.TabIndex = 4;
      this.sendPortBox.Value = new decimal(new int[] {
            50694,
            0,
            0,
            0});
      this.sendPortBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateSendPort);
      // 
      // receivePortBox
      // 
      this.receivePortBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.receivePortBox.Location = new System.Drawing.Point(113, 73);
      this.receivePortBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.receivePortBox.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
      this.receivePortBox.Name = "receivePortBox";
      this.receivePortBox.Size = new System.Drawing.Size(177, 20);
      this.receivePortBox.TabIndex = 4;
      this.receivePortBox.Value = new decimal(new int[] {
            50695,
            0,
            0,
            0});
      this.receivePortBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateReceivePort);
      // 
      // sendPortLabel
      // 
      this.sendPortLabel.AutoSize = true;
      this.sendPortLabel.Location = new System.Drawing.Point(53, 49);
      this.sendPortLabel.Name = "sendPortLabel";
      this.sendPortLabel.Size = new System.Drawing.Size(54, 13);
      this.sendPortLabel.TabIndex = 3;
      this.sendPortLabel.Text = "Send Port";
      // 
      // receivePortLabel
      // 
      this.receivePortLabel.AutoSize = true;
      this.receivePortLabel.Location = new System.Drawing.Point(38, 75);
      this.receivePortLabel.Name = "receivePortLabel";
      this.receivePortLabel.Size = new System.Drawing.Size(69, 13);
      this.receivePortLabel.TabIndex = 3;
      this.receivePortLabel.Text = "Receive Port";
      // 
      // OptionsForm
      // 
      this.AcceptButton = this.saveButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(334, 261);
      this.Controls.Add(this.receivePortBox);
      this.Controls.Add(this.sendPortBox);
      this.Controls.Add(this.receivePortLabel);
      this.Controls.Add(this.sendPortLabel);
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
      ((System.ComponentModel.ISupportInitialize)(this.sendPortBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.receivePortBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.ErrorProvider errorProvider;
    private System.Windows.Forms.NumericUpDown sendPortBox;
    private System.Windows.Forms.NumericUpDown receivePortBox;
    private System.Windows.Forms.Label sendPortLabel;
    private System.Windows.Forms.Label receivePortLabel;
  }
}