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
      this._mainMenu = new System.Windows.Forms.MenuStrip();
      this._statusBar = new System.Windows.Forms.StatusStrip();
      this._fileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this._restartButton = new System.Windows.Forms.ToolStripMenuItem();
      this._exitButton = new System.Windows.Forms.ToolStripMenuItem();
      this._tabContainer = new System.Windows.Forms.TabControl();
      this._tabLog = new System.Windows.Forms.TabPage();
      this._tabSend = new System.Windows.Forms.TabPage();
      this._tabReceive = new System.Windows.Forms.TabPage();
      this._tabOptions = new System.Windows.Forms.TabPage();
      this._mainMenu.SuspendLayout();
      this._tabContainer.SuspendLayout();
      this.SuspendLayout();
      // 
      // _mainMenu
      // 
      this._mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenu});
      this._mainMenu.Location = new System.Drawing.Point(0, 0);
      this._mainMenu.Name = "_mainMenu";
      this._mainMenu.Size = new System.Drawing.Size(284, 24);
      this._mainMenu.TabIndex = 0;
      this._mainMenu.Text = "Main Menu";
      // 
      // _statusBar
      // 
      this._statusBar.Location = new System.Drawing.Point(0, 439);
      this._statusBar.Name = "_statusBar";
      this._statusBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
      this._statusBar.Size = new System.Drawing.Size(284, 22);
      this._statusBar.TabIndex = 2;
      this._statusBar.Text = "Status Bar";
      // 
      // _fileMenu
      // 
      this._fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._restartButton,
            this._exitButton});
      this._fileMenu.Name = "_fileMenu";
      this._fileMenu.Size = new System.Drawing.Size(37, 20);
      this._fileMenu.Text = "File";
      // 
      // _restartButton
      // 
      this._restartButton.Name = "_restartButton";
      this._restartButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this._restartButton.Size = new System.Drawing.Size(152, 22);
      this._restartButton.Text = "Restart";
      this._restartButton.Click += new System.EventHandler(this.Restart);
      // 
      // _exitButton
      // 
      this._exitButton.Name = "_exitButton";
      this._exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this._exitButton.Size = new System.Drawing.Size(152, 22);
      this._exitButton.Text = "Exit";
      this._exitButton.Click += new System.EventHandler(this.Exit);
      // 
      // _tabContainer
      // 
      this._tabContainer.Controls.Add(this._tabLog);
      this._tabContainer.Controls.Add(this._tabSend);
      this._tabContainer.Controls.Add(this._tabReceive);
      this._tabContainer.Controls.Add(this._tabOptions);
      this._tabContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._tabContainer.Location = new System.Drawing.Point(0, 24);
      this._tabContainer.Name = "_tabContainer";
      this._tabContainer.SelectedIndex = 0;
      this._tabContainer.Size = new System.Drawing.Size(284, 415);
      this._tabContainer.TabIndex = 1;
      // 
      // _tabLog
      // 
      this._tabLog.Location = new System.Drawing.Point(4, 22);
      this._tabLog.Name = "_tabLog";
      this._tabLog.Padding = new System.Windows.Forms.Padding(3);
      this._tabLog.Size = new System.Drawing.Size(276, 389);
      this._tabLog.TabIndex = 0;
      this._tabLog.Text = "Log";
      this._tabLog.UseVisualStyleBackColor = true;
      // 
      // _tabSend
      // 
      this._tabSend.Location = new System.Drawing.Point(4, 22);
      this._tabSend.Name = "_tabSend";
      this._tabSend.Padding = new System.Windows.Forms.Padding(3);
      this._tabSend.Size = new System.Drawing.Size(276, 389);
      this._tabSend.TabIndex = 1;
      this._tabSend.Text = "Send";
      this._tabSend.UseVisualStyleBackColor = true;
      // 
      // _tabReceive
      // 
      this._tabReceive.Location = new System.Drawing.Point(4, 22);
      this._tabReceive.Name = "_tabReceive";
      this._tabReceive.Size = new System.Drawing.Size(276, 389);
      this._tabReceive.TabIndex = 2;
      this._tabReceive.Text = "Receive";
      this._tabReceive.UseVisualStyleBackColor = true;
      // 
      // _tabOptions
      // 
      this._tabOptions.Location = new System.Drawing.Point(4, 22);
      this._tabOptions.Name = "_tabOptions";
      this._tabOptions.Size = new System.Drawing.Size(276, 389);
      this._tabOptions.TabIndex = 3;
      this._tabOptions.Text = "Options";
      this._tabOptions.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 461);
      this.Controls.Add(this._tabContainer);
      this.Controls.Add(this._statusBar);
      this.Controls.Add(this._mainMenu);
      this.MainMenuStrip = this._mainMenu;
      this.MinimumSize = new System.Drawing.Size(300, 300);
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "Udpit";
      this._mainMenu.ResumeLayout(false);
      this._mainMenu.PerformLayout();
      this._tabContainer.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip _mainMenu;
    private System.Windows.Forms.StatusStrip _statusBar;
    private System.Windows.Forms.ToolStripMenuItem _fileMenu;
    private System.Windows.Forms.ToolStripMenuItem _restartButton;
    private System.Windows.Forms.ToolStripMenuItem _exitButton;
    private System.Windows.Forms.TabControl _tabContainer;
    private System.Windows.Forms.TabPage _tabLog;
    private System.Windows.Forms.TabPage _tabSend;
    private System.Windows.Forms.TabPage _tabReceive;
    private System.Windows.Forms.TabPage _tabOptions;
  }
}