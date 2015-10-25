﻿namespace Udpit {
  partial class NewMessageForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessageForm));
      this.destinationAddressLabel = new System.Windows.Forms.Label();
      this.destinationPortLabel = new System.Windows.Forms.Label();
      this.maxSizeLabel = new System.Windows.Forms.Label();
      this.destinationPortBox = new System.Windows.Forms.NumericUpDown();
      this.maxSizeBox = new System.Windows.Forms.NumericUpDown();
      this.messageBox = new System.Windows.Forms.TextBox();
      this.cancelButton = new System.Windows.Forms.Button();
      this.createButton = new System.Windows.Forms.Button();
      this.fileButton = new System.Windows.Forms.Button();
      this.removeFileButton = new System.Windows.Forms.Button();
      this.destinationAddressBox = new System.Windows.Forms.TextBox();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.destinationPortBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.maxSizeBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // destinationAddressLabel
      // 
      this.destinationAddressLabel.AutoSize = true;
      this.destinationAddressLabel.Location = new System.Drawing.Point(50, 15);
      this.destinationAddressLabel.Name = "destinationAddressLabel";
      this.destinationAddressLabel.Size = new System.Drawing.Size(100, 13);
      this.destinationAddressLabel.TabIndex = 8;
      this.destinationAddressLabel.Text = "Destination address";
      this.toolTip.SetToolTip(this.destinationAddressLabel, "IP address to which to send the message");
      // 
      // destinationPortLabel
      // 
      this.destinationPortLabel.AutoSize = true;
      this.destinationPortLabel.Location = new System.Drawing.Point(69, 40);
      this.destinationPortLabel.Name = "destinationPortLabel";
      this.destinationPortLabel.Size = new System.Drawing.Size(81, 13);
      this.destinationPortLabel.TabIndex = 9;
      this.destinationPortLabel.Text = "Destination port";
      this.toolTip.SetToolTip(this.destinationPortLabel, "What port to send the message to");
      // 
      // maxSizeLabel
      // 
      this.maxSizeLabel.AutoSize = true;
      this.maxSizeLabel.Location = new System.Drawing.Point(34, 66);
      this.maxSizeLabel.Name = "maxSizeLabel";
      this.maxSizeLabel.Size = new System.Drawing.Size(116, 13);
      this.maxSizeLabel.TabIndex = 10;
      this.maxSizeLabel.Text = "Maximum fragment size";
      this.toolTip.SetToolTip(this.maxSizeLabel, "In bytes");
      // 
      // destinationPortBox
      // 
      this.destinationPortBox.Location = new System.Drawing.Point(156, 38);
      this.destinationPortBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this.destinationPortBox.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
      this.destinationPortBox.Name = "destinationPortBox";
      this.destinationPortBox.Size = new System.Drawing.Size(150, 20);
      this.destinationPortBox.TabIndex = 1;
      this.destinationPortBox.Value = new decimal(new int[] {
            56994,
            0,
            0,
            0});
      // 
      // maxSizeBox
      // 
      this.maxSizeBox.Location = new System.Drawing.Point(156, 64);
      this.maxSizeBox.Maximum = new decimal(new int[] {
            65400,
            0,
            0,
            0});
      this.maxSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.maxSizeBox.Name = "maxSizeBox";
      this.maxSizeBox.Size = new System.Drawing.Size(150, 20);
      this.maxSizeBox.TabIndex = 2;
      this.maxSizeBox.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      // 
      // messageBox
      // 
      this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.messageBox.Location = new System.Drawing.Point(12, 113);
      this.messageBox.Multiline = true;
      this.messageBox.Name = "messageBox";
      this.messageBox.Size = new System.Drawing.Size(310, 163);
      this.messageBox.TabIndex = 3;
      this.toolTip.SetToolTip(this.messageBox, "Message text");
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(237, 326);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(69, 23);
      this.cancelButton.TabIndex = 7;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // createButton
      // 
      this.createButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.createButton.Location = new System.Drawing.Point(156, 326);
      this.createButton.Name = "createButton";
      this.createButton.Size = new System.Drawing.Size(75, 23);
      this.createButton.TabIndex = 6;
      this.createButton.Text = "Create";
      this.createButton.UseVisualStyleBackColor = true;
      this.createButton.Click += new System.EventHandler(this.CreateMessage);
      // 
      // fileButton
      // 
      this.fileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.fileButton.Enabled = false;
      this.fileButton.Location = new System.Drawing.Point(12, 282);
      this.fileButton.Name = "fileButton";
      this.fileButton.Size = new System.Drawing.Size(75, 23);
      this.fileButton.TabIndex = 4;
      this.fileButton.Text = "Choose File";
      this.fileButton.UseVisualStyleBackColor = true;
      // 
      // removeFileButton
      // 
      this.removeFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.removeFileButton.Enabled = false;
      this.removeFileButton.Location = new System.Drawing.Point(93, 282);
      this.removeFileButton.Name = "removeFileButton";
      this.removeFileButton.Size = new System.Drawing.Size(57, 23);
      this.removeFileButton.TabIndex = 5;
      this.removeFileButton.Text = "Remove";
      this.removeFileButton.UseVisualStyleBackColor = true;
      // 
      // destinationAddressBox
      // 
      this.destinationAddressBox.Location = new System.Drawing.Point(156, 12);
      this.destinationAddressBox.Name = "destinationAddressBox";
      this.destinationAddressBox.Size = new System.Drawing.Size(150, 20);
      this.destinationAddressBox.TabIndex = 0;
      this.destinationAddressBox.Text = "127.0.0.1";
      this.destinationAddressBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateAddress);
      // 
      // errorProvider
      // 
      this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
      this.errorProvider.ContainerControl = this;
      this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
      // 
      // NewMessageForm
      // 
      this.AcceptButton = this.createButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(334, 361);
      this.Controls.Add(this.destinationAddressBox);
      this.Controls.Add(this.removeFileButton);
      this.Controls.Add(this.fileButton);
      this.Controls.Add(this.createButton);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.messageBox);
      this.Controls.Add(this.maxSizeBox);
      this.Controls.Add(this.destinationPortBox);
      this.Controls.Add(this.maxSizeLabel);
      this.Controls.Add(this.destinationPortLabel);
      this.Controls.Add(this.destinationAddressLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NewMessageForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "New Message";
      ((System.ComponentModel.ISupportInitialize)(this.destinationPortBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.maxSizeBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label destinationAddressLabel;
    private System.Windows.Forms.Label destinationPortLabel;
    private System.Windows.Forms.Label maxSizeLabel;
    private System.Windows.Forms.NumericUpDown destinationPortBox;
    private System.Windows.Forms.NumericUpDown maxSizeBox;
    private System.Windows.Forms.TextBox messageBox;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button createButton;
    private System.Windows.Forms.Button fileButton;
    private System.Windows.Forms.Button removeFileButton;
    private System.Windows.Forms.TextBox destinationAddressBox;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.ErrorProvider errorProvider;
  }
}