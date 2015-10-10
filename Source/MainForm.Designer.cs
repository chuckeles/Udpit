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
      this.toolbar = new System.Windows.Forms.ToolStrip();
      this.applicationButton = new System.Windows.Forms.ToolStripDropDownButton();
      this.restartButton = new System.Windows.Forms.ToolStripMenuItem();
      this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsButton = new System.Windows.Forms.ToolStripMenuItem();
      this.applicationSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.nameButton = new System.Windows.Forms.ToolStripMenuItem();
      this.messageButton = new System.Windows.Forms.ToolStripDropDownButton();
      this.newMessageButton = new System.Windows.Forms.ToolStripMenuItem();
      this.inProgressButton = new System.Windows.Forms.ToolStripMenuItem();
      this.archiveButton = new System.Windows.Forms.ToolStripMenuItem();
      this.toolbar.SuspendLayout();
      this.SuspendLayout();
      // 
      // toolbar
      // 
      this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationButton,
            this.messageButton});
      this.toolbar.Location = new System.Drawing.Point(0, 0);
      this.toolbar.Name = "toolbar";
      this.toolbar.Size = new System.Drawing.Size(384, 25);
      this.toolbar.TabIndex = 3;
      this.toolbar.Text = "toolbar";
      // 
      // applicationButton
      // 
      this.applicationButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsButton,
            this.applicationSeparator,
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
      this.restartButton.Size = new System.Drawing.Size(152, 22);
      this.restartButton.Text = "Restart";
      this.restartButton.ToolTipText = "Restart the application";
      this.restartButton.Click += new System.EventHandler(this.RestartApplication);
      // 
      // exitButton
      // 
      this.exitButton.Name = "exitButton";
      this.exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.exitButton.Size = new System.Drawing.Size(152, 22);
      this.exitButton.Text = "Exit";
      this.exitButton.ToolTipText = "Exit the application";
      this.exitButton.Click += new System.EventHandler(this.ExitApplication);
      // 
      // optionsButton
      // 
      this.optionsButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameButton});
      this.optionsButton.Name = "optionsButton";
      this.optionsButton.Size = new System.Drawing.Size(152, 22);
      this.optionsButton.Text = "Options";
      this.optionsButton.ToolTipText = "Application options";
      // 
      // applicationSeparator
      // 
      this.applicationSeparator.Name = "applicationSeparator";
      this.applicationSeparator.Size = new System.Drawing.Size(149, 6);
      // 
      // nameButton
      // 
      this.nameButton.Name = "nameButton";
      this.nameButton.Size = new System.Drawing.Size(152, 22);
      this.nameButton.Text = "Name";
      this.nameButton.ToolTipText = "Change the name";
      this.nameButton.Click += new System.EventHandler(this.ShowNameForm);
      // 
      // messageButton
      // 
      this.messageButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMessageButton,
            this.inProgressButton,
            this.archiveButton});
      this.messageButton.Name = "messageButton";
      this.messageButton.Size = new System.Drawing.Size(71, 22);
      this.messageButton.Text = "Messages";
      this.messageButton.ToolTipText = "Manage messages";
      // 
      // newMessageButton
      // 
      this.newMessageButton.Name = "newMessageButton";
      this.newMessageButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newMessageButton.Size = new System.Drawing.Size(152, 22);
      this.newMessageButton.Text = "New";
      this.newMessageButton.ToolTipText = "Create a new message";
      // 
      // inProgressButton
      // 
      this.inProgressButton.Name = "inProgressButton";
      this.inProgressButton.Size = new System.Drawing.Size(152, 22);
      this.inProgressButton.Text = "In Progress";
      this.inProgressButton.ToolTipText = "Show messages in progress";
      // 
      // archiveButton
      // 
      this.archiveButton.Name = "archiveButton";
      this.archiveButton.Size = new System.Drawing.Size(152, 22);
      this.archiveButton.Text = "Archive";
      this.archiveButton.ToolTipText = "Show the archive";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 461);
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
    private ToolStripMenuItem optionsButton;
    private ToolStripSeparator applicationSeparator;
    private ToolStripMenuItem nameButton;
    private ToolStripDropDownButton messageButton;
    private ToolStripMenuItem newMessageButton;
    private ToolStripMenuItem inProgressButton;
    private ToolStripMenuItem archiveButton;
  }
}