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
      this._mainMenu.SuspendLayout();
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
      this._statusBar.Size = new System.Drawing.Size(284, 22);
      this._statusBar.TabIndex = 1;
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 461);
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
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip _mainMenu;
    private System.Windows.Forms.StatusStrip _statusBar;
    private System.Windows.Forms.ToolStripMenuItem _fileMenu;
    private System.Windows.Forms.ToolStripMenuItem _restartButton;
    private System.Windows.Forms.ToolStripMenuItem _exitButton;
  }
}