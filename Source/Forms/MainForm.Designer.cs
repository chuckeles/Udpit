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
      this._logBox = new System.Windows.Forms.TextBox();
      this._sendTableContainer = new System.Windows.Forms.TableLayoutPanel();
      this._sendInputGroup = new System.Windows.Forms.GroupBox();
      this._sendFileGroup = new System.Windows.Forms.GroupBox();
      this._sendActionsGroup = new System.Windows.Forms.GroupBox();
      this._sendInputBox = new System.Windows.Forms.TextBox();
      this._sendFileContainer = new System.Windows.Forms.TableLayoutPanel();
      this._sendFileButton = new System.Windows.Forms.Button();
      this._sendFileRemoveButton = new System.Windows.Forms.Button();
      this._sendFileLabel = new System.Windows.Forms.Label();
      this._sendFileName = new System.Windows.Forms.Label();
      this._sendActionsContainer = new System.Windows.Forms.TableLayoutPanel();
      this._sendButton = new System.Windows.Forms.Button();
      this._sendCancelButton = new System.Windows.Forms.Button();
      this._mainMenu.SuspendLayout();
      this._tabContainer.SuspendLayout();
      this._tabLog.SuspendLayout();
      this._tabSend.SuspendLayout();
      this._sendTableContainer.SuspendLayout();
      this._sendInputGroup.SuspendLayout();
      this._sendFileGroup.SuspendLayout();
      this._sendActionsGroup.SuspendLayout();
      this._sendFileContainer.SuspendLayout();
      this._sendActionsContainer.SuspendLayout();
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
      this._tabLog.Controls.Add(this._logBox);
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
      this._tabSend.Controls.Add(this._sendTableContainer);
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
      // _logBox
      // 
      this._logBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._logBox.Location = new System.Drawing.Point(3, 3);
      this._logBox.Multiline = true;
      this._logBox.Name = "_logBox";
      this._logBox.ReadOnly = true;
      this._logBox.Size = new System.Drawing.Size(270, 383);
      this._logBox.TabIndex = 0;
      // 
      // _sendTableContainer
      // 
      this._sendTableContainer.ColumnCount = 1;
      this._sendTableContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this._sendTableContainer.Controls.Add(this._sendInputGroup, 0, 0);
      this._sendTableContainer.Controls.Add(this._sendFileGroup, 0, 1);
      this._sendTableContainer.Controls.Add(this._sendActionsGroup, 0, 2);
      this._sendTableContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendTableContainer.Location = new System.Drawing.Point(3, 3);
      this._sendTableContainer.Name = "_sendTableContainer";
      this._sendTableContainer.RowCount = 3;
      this._sendTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this._sendTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this._sendTableContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this._sendTableContainer.Size = new System.Drawing.Size(270, 383);
      this._sendTableContainer.TabIndex = 0;
      // 
      // _sendInputGroup
      // 
      this._sendInputGroup.Controls.Add(this._sendInputBox);
      this._sendInputGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendInputGroup.Location = new System.Drawing.Point(3, 3);
      this._sendInputGroup.Name = "_sendInputGroup";
      this._sendInputGroup.Size = new System.Drawing.Size(264, 147);
      this._sendInputGroup.TabIndex = 0;
      this._sendInputGroup.TabStop = false;
      this._sendInputGroup.Text = "Input Text";
      // 
      // _sendFileGroup
      // 
      this._sendFileGroup.Controls.Add(this._sendFileContainer);
      this._sendFileGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendFileGroup.Location = new System.Drawing.Point(3, 156);
      this._sendFileGroup.Name = "_sendFileGroup";
      this._sendFileGroup.Size = new System.Drawing.Size(264, 147);
      this._sendFileGroup.TabIndex = 1;
      this._sendFileGroup.TabStop = false;
      this._sendFileGroup.Text = "Input File";
      // 
      // _sendActionsGroup
      // 
      this._sendActionsGroup.Controls.Add(this._sendActionsContainer);
      this._sendActionsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendActionsGroup.Location = new System.Drawing.Point(3, 309);
      this._sendActionsGroup.Name = "_sendActionsGroup";
      this._sendActionsGroup.Size = new System.Drawing.Size(264, 71);
      this._sendActionsGroup.TabIndex = 2;
      this._sendActionsGroup.TabStop = false;
      this._sendActionsGroup.Text = "Actions";
      // 
      // _sendInputBox
      // 
      this._sendInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendInputBox.Location = new System.Drawing.Point(3, 16);
      this._sendInputBox.Multiline = true;
      this._sendInputBox.Name = "_sendInputBox";
      this._sendInputBox.Size = new System.Drawing.Size(258, 128);
      this._sendInputBox.TabIndex = 0;
      // 
      // _sendFileContainer
      // 
      this._sendFileContainer.ColumnCount = 2;
      this._sendFileContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendFileContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendFileContainer.Controls.Add(this._sendFileButton, 0, 1);
      this._sendFileContainer.Controls.Add(this._sendFileRemoveButton, 1, 1);
      this._sendFileContainer.Controls.Add(this._sendFileLabel, 0, 0);
      this._sendFileContainer.Controls.Add(this._sendFileName, 1, 0);
      this._sendFileContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendFileContainer.Location = new System.Drawing.Point(3, 16);
      this._sendFileContainer.Name = "_sendFileContainer";
      this._sendFileContainer.RowCount = 2;
      this._sendFileContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendFileContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendFileContainer.Size = new System.Drawing.Size(258, 128);
      this._sendFileContainer.TabIndex = 0;
      // 
      // _sendFileButton
      // 
      this._sendFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._sendFileButton.Location = new System.Drawing.Point(3, 102);
      this._sendFileButton.Name = "_sendFileButton";
      this._sendFileButton.Size = new System.Drawing.Size(123, 23);
      this._sendFileButton.TabIndex = 2;
      this._sendFileButton.Text = "Select";
      this._sendFileButton.UseVisualStyleBackColor = true;
      // 
      // _sendFileRemoveButton
      // 
      this._sendFileRemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._sendFileRemoveButton.Location = new System.Drawing.Point(132, 102);
      this._sendFileRemoveButton.Name = "_sendFileRemoveButton";
      this._sendFileRemoveButton.Size = new System.Drawing.Size(123, 23);
      this._sendFileRemoveButton.TabIndex = 3;
      this._sendFileRemoveButton.Text = "Remove";
      this._sendFileRemoveButton.UseVisualStyleBackColor = true;
      // 
      // _sendFileLabel
      // 
      this._sendFileLabel.AutoSize = true;
      this._sendFileLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendFileLabel.Location = new System.Drawing.Point(3, 0);
      this._sendFileLabel.Name = "_sendFileLabel";
      this._sendFileLabel.Size = new System.Drawing.Size(123, 64);
      this._sendFileLabel.TabIndex = 0;
      this._sendFileLabel.Text = "Selected file:";
      this._sendFileLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // _sendFileName
      // 
      this._sendFileName.AutoSize = true;
      this._sendFileName.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendFileName.Location = new System.Drawing.Point(132, 0);
      this._sendFileName.Name = "_sendFileName";
      this._sendFileName.Size = new System.Drawing.Size(123, 64);
      this._sendFileName.TabIndex = 1;
      this._sendFileName.Text = "file.txt";
      this._sendFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // _sendActionsContainer
      // 
      this._sendActionsContainer.ColumnCount = 2;
      this._sendActionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendActionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendActionsContainer.Controls.Add(this._sendButton, 0, 0);
      this._sendActionsContainer.Controls.Add(this._sendCancelButton, 1, 0);
      this._sendActionsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendActionsContainer.Location = new System.Drawing.Point(3, 16);
      this._sendActionsContainer.Name = "_sendActionsContainer";
      this._sendActionsContainer.RowCount = 1;
      this._sendActionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendActionsContainer.Size = new System.Drawing.Size(258, 52);
      this._sendActionsContainer.TabIndex = 0;
      // 
      // _sendButton
      // 
      this._sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._sendButton.Location = new System.Drawing.Point(3, 26);
      this._sendButton.Name = "_sendButton";
      this._sendButton.Size = new System.Drawing.Size(123, 23);
      this._sendButton.TabIndex = 0;
      this._sendButton.Text = "Send";
      this._sendButton.UseVisualStyleBackColor = true;
      // 
      // _sendCancelButton
      // 
      this._sendCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._sendCancelButton.Location = new System.Drawing.Point(132, 26);
      this._sendCancelButton.Name = "_sendCancelButton";
      this._sendCancelButton.Size = new System.Drawing.Size(123, 23);
      this._sendCancelButton.TabIndex = 1;
      this._sendCancelButton.Text = "Cancel";
      this._sendCancelButton.UseVisualStyleBackColor = true;
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
      this._tabLog.ResumeLayout(false);
      this._tabLog.PerformLayout();
      this._tabSend.ResumeLayout(false);
      this._sendTableContainer.ResumeLayout(false);
      this._sendInputGroup.ResumeLayout(false);
      this._sendInputGroup.PerformLayout();
      this._sendFileGroup.ResumeLayout(false);
      this._sendActionsGroup.ResumeLayout(false);
      this._sendFileContainer.ResumeLayout(false);
      this._sendFileContainer.PerformLayout();
      this._sendActionsContainer.ResumeLayout(false);
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
    private System.Windows.Forms.TextBox _logBox;
    private System.Windows.Forms.TableLayoutPanel _sendTableContainer;
    private System.Windows.Forms.GroupBox _sendInputGroup;
    private System.Windows.Forms.GroupBox _sendFileGroup;
    private System.Windows.Forms.GroupBox _sendActionsGroup;
    private System.Windows.Forms.TextBox _sendInputBox;
    private System.Windows.Forms.TableLayoutPanel _sendFileContainer;
    private System.Windows.Forms.Button _sendFileButton;
    private System.Windows.Forms.Button _sendFileRemoveButton;
    private System.Windows.Forms.Label _sendFileLabel;
    private System.Windows.Forms.Label _sendFileName;
    private System.Windows.Forms.TableLayoutPanel _sendActionsContainer;
    private System.Windows.Forms.Button _sendButton;
    private System.Windows.Forms.Button _sendCancelButton;
  }
}