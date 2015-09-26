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
      this.messageBox = new System.Windows.Forms.TextBox();
      this.inputBox = new System.Windows.Forms.TextBox();
      this.sendButton = new System.Windows.Forms.Button();
      this.toolbar = new System.Windows.Forms.ToolStrip();
      this.fileButton = new System.Windows.Forms.ToolStripDropDownButton();
      this.optionsButton = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
      this.fileSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.restartButton = new System.Windows.Forms.ToolStripMenuItem();
      this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
      this.toolbar.SuspendLayout();
      this.SuspendLayout();
      // 
      // messageBox
      // 
      this.messageBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.messageBox.Enabled = false;
      this.messageBox.Location = new System.Drawing.Point(12, 28);
      this.messageBox.Multiline = true;
      this.messageBox.Name = "messageBox";
      this.messageBox.ReadOnly = true;
      this.messageBox.Size = new System.Drawing.Size(260, 193);
      this.messageBox.TabIndex = 2;
      this.messageBox.TabStop = false;
      // 
      // inputBox
      // 
      this.inputBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.inputBox.Enabled = false;
      this.inputBox.Location = new System.Drawing.Point(12, 229);
      this.inputBox.Name = "inputBox";
      this.inputBox.Size = new System.Drawing.Size(202, 20);
      this.inputBox.TabIndex = 0;
      // 
      // sendButton
      // 
      this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.sendButton.Enabled = false;
      this.sendButton.Location = new System.Drawing.Point(220, 227);
      this.sendButton.Name = "sendButton";
      this.sendButton.Size = new System.Drawing.Size(52, 23);
      this.sendButton.TabIndex = 1;
      this.sendButton.Text = "send";
      this.sendButton.UseVisualStyleBackColor = true;
      // 
      // toolbar
      // 
      this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileButton});
      this.toolbar.Location = new System.Drawing.Point(0, 0);
      this.toolbar.Name = "toolbar";
      this.toolbar.Size = new System.Drawing.Size(284, 25);
      this.toolbar.TabIndex = 3;
      this.toolbar.Text = "toolbar";
      // 
      // fileButton
      // 
      this.fileButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsButton,
            this.aboutButton,
            this.fileSeparator,
            this.restartButton,
            this.exitButton});
      this.fileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.fileButton.Name = "fileButton";
      this.fileButton.Size = new System.Drawing.Size(36, 22);
      this.fileButton.Text = "file";
      // 
      // optionsButton
      // 
      this.optionsButton.Name = "optionsButton";
      this.optionsButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.optionsButton.Size = new System.Drawing.Size(157, 22);
      this.optionsButton.Text = "options";
      // 
      // aboutButton
      // 
      this.aboutButton.Name = "aboutButton";
      this.aboutButton.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.aboutButton.Size = new System.Drawing.Size(157, 22);
      this.aboutButton.Text = "about";
      this.aboutButton.Click += new System.EventHandler(this.ShowAbout);
      // 
      // fileSeparator
      // 
      this.fileSeparator.Name = "fileSeparator";
      this.fileSeparator.Size = new System.Drawing.Size(154, 6);
      // 
      // restartButton
      // 
      this.restartButton.Name = "restartButton";
      this.restartButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this.restartButton.Size = new System.Drawing.Size(157, 22);
      this.restartButton.Text = "restart";
      this.restartButton.Click += new System.EventHandler(this.RestartApplication);
      // 
      // exitButton
      // 
      this.exitButton.Name = "exitButton";
      this.exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitButton.Size = new System.Drawing.Size(157, 22);
      this.exitButton.Text = "exit";
      this.exitButton.Click += new System.EventHandler(this.ExitApplication);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 261);
      this.Controls.Add(this.toolbar);
      this.Controls.Add(this.sendButton);
      this.Controls.Add(this.inputBox);
      this.Controls.Add(this.messageBox);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(500, 500);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(300, 300);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "udpit";
      this.toolbar.ResumeLayout(false);
      this.toolbar.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox messageBox;
    private System.Windows.Forms.TextBox inputBox;
    private System.Windows.Forms.Button sendButton;
    private System.Windows.Forms.ToolStrip toolbar;
    private System.Windows.Forms.ToolStripDropDownButton fileButton;
    private System.Windows.Forms.ToolStripMenuItem exitButton;
    private System.Windows.Forms.ToolStripMenuItem restartButton;
    private System.Windows.Forms.ToolStripMenuItem optionsButton;
    private System.Windows.Forms.ToolStripMenuItem aboutButton;
    private System.Windows.Forms.ToolStripSeparator fileSeparator;
  }
}