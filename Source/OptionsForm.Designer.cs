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
      this.destinationLabel = new System.Windows.Forms.Label();
      this.errorLabel = new System.Windows.Forms.Label();
      this.errorCheckbox = new System.Windows.Forms.CheckBox();
      this.destinationBox = new System.Windows.Forms.TextBox();
      this.fragmentLabel = new System.Windows.Forms.Label();
      this.fragmentBox = new System.Windows.Forms.NumericUpDown();
      this.tooltip = new System.Windows.Forms.ToolTip(this.components);
      this.nameBox = new System.Windows.Forms.TextBox();
      this.nameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.fragmentBox)).BeginInit();
      this.SuspendLayout();
      // 
      // destinationLabel
      // 
      this.destinationLabel.AutoSize = true;
      this.destinationLabel.Location = new System.Drawing.Point(12, 50);
      this.destinationLabel.Name = "destinationLabel";
      this.destinationLabel.Size = new System.Drawing.Size(58, 13);
      this.destinationLabel.TabIndex = 0;
      this.destinationLabel.Text = "destination";
      this.tooltip.SetToolTip(this.destinationLabel, "an IP address to send the messages to");
      // 
      // errorLabel
      // 
      this.errorLabel.AutoSize = true;
      this.errorLabel.Location = new System.Drawing.Point(12, 116);
      this.errorLabel.Name = "errorLabel";
      this.errorLabel.Size = new System.Drawing.Size(54, 13);
      this.errorLabel.TabIndex = 2;
      this.errorLabel.Text = "send error";
      this.tooltip.SetToolTip(this.errorLabel, "send error fragments (for testing)");
      // 
      // errorCheckbox
      // 
      this.errorCheckbox.AutoSize = true;
      this.errorCheckbox.Location = new System.Drawing.Point(76, 117);
      this.errorCheckbox.Name = "errorCheckbox";
      this.errorCheckbox.Size = new System.Drawing.Size(15, 14);
      this.errorCheckbox.TabIndex = 3;
      this.tooltip.SetToolTip(this.errorCheckbox, "send error fragments (for testing)");
      this.errorCheckbox.UseVisualStyleBackColor = true;
      // 
      // destinationBox
      // 
      this.destinationBox.Location = new System.Drawing.Point(76, 47);
      this.destinationBox.Name = "destinationBox";
      this.destinationBox.Size = new System.Drawing.Size(116, 20);
      this.destinationBox.TabIndex = 1;
      this.tooltip.SetToolTip(this.destinationBox, "an IP address to send the messages to");
      // 
      // fragmentLabel
      // 
      this.fragmentLabel.AutoSize = true;
      this.fragmentLabel.Location = new System.Drawing.Point(12, 84);
      this.fragmentLabel.Name = "fragmentLabel";
      this.fragmentLabel.Size = new System.Drawing.Size(47, 13);
      this.fragmentLabel.TabIndex = 5;
      this.fragmentLabel.Text = "max size";
      this.tooltip.SetToolTip(this.fragmentLabel, "maximum size of a fragment");
      // 
      // fragmentBox
      // 
      this.fragmentBox.Location = new System.Drawing.Point(76, 82);
      this.fragmentBox.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
      this.fragmentBox.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
      this.fragmentBox.Name = "fragmentBox";
      this.fragmentBox.Size = new System.Drawing.Size(116, 20);
      this.fragmentBox.TabIndex = 2;
      this.tooltip.SetToolTip(this.fragmentBox, "maximum size of a fragment");
      this.fragmentBox.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
      // 
      // nameBox
      // 
      this.nameBox.Location = new System.Drawing.Point(76, 12);
      this.nameBox.Name = "nameBox";
      this.nameBox.Size = new System.Drawing.Size(116, 20);
      this.nameBox.TabIndex = 0;
      this.tooltip.SetToolTip(this.nameBox, "your name");
      // 
      // nameLabel
      // 
      this.nameLabel.AutoSize = true;
      this.nameLabel.Location = new System.Drawing.Point(12, 15);
      this.nameLabel.Name = "nameLabel";
      this.nameLabel.Size = new System.Drawing.Size(33, 13);
      this.nameLabel.TabIndex = 7;
      this.nameLabel.Text = "name";
      this.tooltip.SetToolTip(this.nameLabel, "your name");
      // 
      // OptionsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(204, 143);
      this.Controls.Add(this.nameBox);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.fragmentBox);
      this.Controls.Add(this.fragmentLabel);
      this.Controls.Add(this.destinationBox);
      this.Controls.Add(this.errorCheckbox);
      this.Controls.Add(this.errorLabel);
      this.Controls.Add(this.destinationLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "options";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
      ((System.ComponentModel.ISupportInitialize)(this.fragmentBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label destinationLabel;
    private System.Windows.Forms.Label errorLabel;
    private System.Windows.Forms.Label fragmentLabel;
    private System.Windows.Forms.ToolTip tooltip;
    private System.Windows.Forms.Label nameLabel;
    private System.Windows.Forms.TextBox nameBox;
    private System.Windows.Forms.TextBox destinationBox;
    private System.Windows.Forms.NumericUpDown fragmentBox;
    private System.Windows.Forms.CheckBox errorCheckbox;
  }
}