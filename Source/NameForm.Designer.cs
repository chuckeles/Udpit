namespace Udpit {
  partial class NameForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameForm));
      this.cancelButton = new System.Windows.Forms.Button();
      this.saveButton = new System.Windows.Forms.Button();
      this.nameBox = new System.Windows.Forms.TextBox();
      this.nameLabel = new System.Windows.Forms.Label();
      this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.cancelButton.Location = new System.Drawing.Point(165, 73);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 26);
      this.cancelButton.TabIndex = 1;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      // 
      // saveButton
      // 
      this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.saveButton.Location = new System.Drawing.Point(63, 73);
      this.saveButton.Name = "saveButton";
      this.saveButton.Size = new System.Drawing.Size(96, 26);
      this.saveButton.TabIndex = 0;
      this.saveButton.Text = "Save";
      this.saveButton.UseVisualStyleBackColor = true;
      this.saveButton.Click += new System.EventHandler(this.SaveName);
      // 
      // nameBox
      // 
      this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.nameBox.Location = new System.Drawing.Point(63, 21);
      this.nameBox.Name = "nameBox";
      this.nameBox.Size = new System.Drawing.Size(177, 20);
      this.nameBox.TabIndex = 2;
      this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateName);
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(22, 24);
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
      // NameForm
      // 
      this.AcceptButton = this.saveButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.cancelButton;
      this.ClientSize = new System.Drawing.Size(284, 111);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.nameBox);
      this.Controls.Add(this.saveButton);
      this.Controls.Add(this.cancelButton);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "NameForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Name";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Button saveButton;
    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.ErrorProvider errorProvider;
  }
}