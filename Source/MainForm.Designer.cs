using System.Windows.Forms;

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
      this.components = new System.ComponentModel.Container();
      this.toolbar = new System.Windows.Forms.ToolStrip();
      this.applicationButton = new System.Windows.Forms.ToolStripDropDownButton();
      this.restartButton = new System.Windows.Forms.ToolStripMenuItem();
      this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsButton = new System.Windows.Forms.ToolStripDropDownButton();
      this.nameButton = new System.Windows.Forms.ToolStripMenuItem();
      this.tooltip = new System.Windows.Forms.ToolTip(this.components);
      this.newMessageButton = new System.Windows.Forms.Button();
      this.toolbar.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolbar
      // 
      this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationButton,
            this.optionsButton});
      this.toolbar.Location = new System.Drawing.Point(0, 0);
      this.toolbar.Name = "toolbar";
      this.toolbar.Size = new System.Drawing.Size(384, 25);
      this.toolbar.TabIndex = 3;
      this.toolbar.Text = "toolbar";
      // 
      // applicationButton
      // 
      this.applicationButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartButton,
            this.exitButton});
      this.applicationButton.Name = "applicationButton";
      this.applicationButton.Size = new System.Drawing.Size(81, 22);
      this.applicationButton.Text = "Application";
      this.applicationButton.ToolTipText = "Application menu";
      // 
      // restartButton
      // 
      this.restartButton.Name = "restartButton";
      this.restartButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this.restartButton.Size = new System.Drawing.Size(151, 22);
      this.restartButton.Text = "Restart";
      this.restartButton.ToolTipText = "Restart the application";
      this.restartButton.Click += new System.EventHandler(this.RestartApplication);
      // 
      // exitButton
      // 
      this.exitButton.Name = "exitButton";
      this.exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitButton.Size = new System.Drawing.Size(151, 22);
      this.exitButton.Text = "Exit";
      this.exitButton.ToolTipText = "Exit the application";
      this.exitButton.Click += new System.EventHandler(this.ExitApplication);
      // 
      // optionsButton
      // 
      this.optionsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameButton});
      this.optionsButton.Name = "optionsButton";
      this.optionsButton.Size = new System.Drawing.Size(62, 22);
      this.optionsButton.Text = "Options";
      this.optionsButton.ToolTipText = "Messaging Options";
      // 
      // nameButton
      // 
      this.nameButton.Name = "nameButton";
      this.nameButton.Size = new System.Drawing.Size(106, 22);
      this.nameButton.Text = "Name";
      this.nameButton.Click += new System.EventHandler(this.ShowNameForm);
      // 
      // newMessageButton
      // 
      this.newMessageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.newMessageButton.Location = new System.Drawing.Point(12, 423);
      this.newMessageButton.Name = "newMessageButton";
      this.newMessageButton.Size = new System.Drawing.Size(360, 26);
      this.newMessageButton.TabIndex = 0;
      this.newMessageButton.Text = "New Message";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 461);
      this.Controls.Add(this.newMessageButton);
      this.Controls.Add(this.toolbar);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(600, 800);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(300, 300);
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Udpit";
      this.toolbar.ResumeLayout(false);
      this.toolbar.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ToolStrip toolbar;
    private System.Windows.Forms.ToolStripDropDownButton applicationButton;
    private System.Windows.Forms.ToolStripMenuItem exitButton;
    private System.Windows.Forms.ToolStripMenuItem restartButton;
    private System.Windows.Forms.ToolTip tooltip;
    private Button newMessageButton;
    private ToolStripDropDownButton optionsButton;
    private ToolStripMenuItem nameButton;
  }
}