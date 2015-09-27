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
      this.ErrorCheckbox = new System.Windows.Forms.CheckBox();
      this.DestinationBox = new System.Windows.Forms.TextBox();
      this.fragmentLabel = new System.Windows.Forms.Label();
      this.FragmentBox = new System.Windows.Forms.NumericUpDown();
      this.tooltip = new System.Windows.Forms.ToolTip(this.components);
      this.NameBox = new System.Windows.Forms.TextBox();
      this.nameLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.FragmentBox)).BeginInit();
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
      // ErrorCheckbox
      // 
      this.ErrorCheckbox.AutoSize = true;
      this.ErrorCheckbox.Location = new System.Drawing.Point(76, 117);
      this.ErrorCheckbox.Name = "ErrorCheckbox";
      this.ErrorCheckbox.Size = new System.Drawing.Size(15, 14);
      this.ErrorCheckbox.TabIndex = 3;
      this.tooltip.SetToolTip(this.ErrorCheckbox, "send error fragments (for testing)");
      this.ErrorCheckbox.UseVisualStyleBackColor = true;
      // 
      // DestinationBox
      // 
      this.DestinationBox.Location = new System.Drawing.Point(76, 47);
      this.DestinationBox.Name = "DestinationBox";
      this.DestinationBox.Size = new System.Drawing.Size(116, 20);
      this.DestinationBox.TabIndex = 4;
      this.tooltip.SetToolTip(this.DestinationBox, "an IP address to send the messages to");
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
      // FragmentBox
      // 
      this.FragmentBox.Location = new System.Drawing.Point(76, 82);
      this.FragmentBox.Name = "FragmentBox";
      this.FragmentBox.Size = new System.Drawing.Size(116, 20);
      this.FragmentBox.TabIndex = 6;
      this.tooltip.SetToolTip(this.FragmentBox, "maximum size of a fragment");
      // 
      // NameBox
      // 
      this.NameBox.Location = new System.Drawing.Point(76, 12);
      this.NameBox.Name = "NameBox";
      this.NameBox.Size = new System.Drawing.Size(116, 20);
      this.NameBox.TabIndex = 8;
      this.tooltip.SetToolTip(this.NameBox, "your name");
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
      this.Controls.Add(this.NameBox);
      this.Controls.Add(this.nameLabel);
      this.Controls.Add(this.FragmentBox);
      this.Controls.Add(this.fragmentLabel);
      this.Controls.Add(this.DestinationBox);
      this.Controls.Add(this.ErrorCheckbox);
      this.Controls.Add(this.errorLabel);
      this.Controls.Add(this.destinationLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "OptionsForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "options";
      ((System.ComponentModel.ISupportInitialize)(this.FragmentBox)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label destinationLabel;
    private System.Windows.Forms.Label errorLabel;
    private System.Windows.Forms.Label fragmentLabel;
    private System.Windows.Forms.ToolTip tooltip;
    private System.Windows.Forms.Label nameLabel;
    public System.Windows.Forms.TextBox NameBox;
    public System.Windows.Forms.TextBox DestinationBox;
    public System.Windows.Forms.NumericUpDown FragmentBox;
    public System.Windows.Forms.CheckBox ErrorCheckbox;
  }
}