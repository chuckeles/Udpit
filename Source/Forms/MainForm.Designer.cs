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
      this._fileMenu = new System.Windows.Forms.ToolStripMenuItem();
      this._restartButton = new System.Windows.Forms.ToolStripMenuItem();
      this._exitButton = new System.Windows.Forms.ToolStripMenuItem();
      this._statusBar = new System.Windows.Forms.StatusStrip();
      this._tabContainer = new System.Windows.Forms.TabControl();
      this._tabLog = new System.Windows.Forms.TabPage();
      this._logBox = new System.Windows.Forms.RichTextBox();
      this._tabSend = new System.Windows.Forms.TabPage();
      this._sendContainer = new System.Windows.Forms.TableLayoutPanel();
      this._sendInputGroup = new System.Windows.Forms.GroupBox();
      this._sendInputBox = new System.Windows.Forms.TextBox();
      this._sendFileGroup = new System.Windows.Forms.GroupBox();
      this._sendFileContainer = new System.Windows.Forms.TableLayoutPanel();
      this._sendFileButton = new System.Windows.Forms.Button();
      this._sendFileRemoveButton = new System.Windows.Forms.Button();
      this._sendFileLabel = new System.Windows.Forms.Label();
      this._sendFileName = new System.Windows.Forms.Label();
      this._sendActionsGroup = new System.Windows.Forms.GroupBox();
      this._sendActionsContainer = new System.Windows.Forms.TableLayoutPanel();
      this._sendButton = new System.Windows.Forms.Button();
      this._sendCancelButton = new System.Windows.Forms.Button();
      this._tabReceive = new System.Windows.Forms.TabPage();
      this._receiveGroup = new System.Windows.Forms.GroupBox();
      this._receiveActionsContainer = new System.Windows.Forms.TableLayoutPanel();
      this._receiveListenButton = new System.Windows.Forms.Button();
      this._receiveStopButton = new System.Windows.Forms.Button();
      this._tabOptions = new System.Windows.Forms.TabPage();
      this._optionsContainer = new System.Windows.Forms.TableLayoutPanel();
      this._sendingGroup = new System.Windows.Forms.GroupBox();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this._sendingPortLabel = new System.Windows.Forms.Label();
      this._sendingAddressLabel = new System.Windows.Forms.Label();
      this._sendingAddressBox = new System.Windows.Forms.TextBox();
      this._sendingPortBox = new System.Windows.Forms.NumericUpDown();
      this._sendingSizeLabel = new System.Windows.Forms.Label();
      this._sendingSizeBox = new System.Windows.Forms.NumericUpDown();
      this._sendingErrorLabel = new System.Windows.Forms.Label();
      this._sendingErrorCheckBox = new System.Windows.Forms.CheckBox();
      this._optionsGroup = new System.Windows.Forms.GroupBox();
      this._optionsInputContainer = new System.Windows.Forms.TableLayoutPanel();
      this._optionsPortLabel = new System.Windows.Forms.Label();
      this._optionsNameLabel = new System.Windows.Forms.Label();
      this._optionsNameBox = new System.Windows.Forms.TextBox();
      this._optionsPortBox = new System.Windows.Forms.NumericUpDown();
      this._optionsActionsGroup = new System.Windows.Forms.GroupBox();
      this._optionsActionsContainer = new System.Windows.Forms.TableLayoutPanel();
      this._optionsSaveButton = new System.Windows.Forms.Button();
      this._optionsCancelButton = new System.Windows.Forms.Button();
      this._mainMenu.SuspendLayout();
      this._tabContainer.SuspendLayout();
      this._tabLog.SuspendLayout();
      this._tabSend.SuspendLayout();
      this._sendContainer.SuspendLayout();
      this._sendInputGroup.SuspendLayout();
      this._sendFileGroup.SuspendLayout();
      this._sendFileContainer.SuspendLayout();
      this._sendActionsGroup.SuspendLayout();
      this._sendActionsContainer.SuspendLayout();
      this._tabReceive.SuspendLayout();
      this._receiveGroup.SuspendLayout();
      this._receiveActionsContainer.SuspendLayout();
      this._tabOptions.SuspendLayout();
      this._optionsContainer.SuspendLayout();
      this._sendingGroup.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this._sendingPortBox)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this._sendingSizeBox)).BeginInit();
      this._optionsGroup.SuspendLayout();
      this._optionsInputContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this._optionsPortBox)).BeginInit();
      this._optionsActionsGroup.SuspendLayout();
      this._optionsActionsContainer.SuspendLayout();
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
      this._restartButton.Size = new System.Drawing.Size(151, 22);
      this._restartButton.Text = "Restart";
      this._restartButton.Click += new System.EventHandler(this.Restart);
      // 
      // _exitButton
      // 
      this._exitButton.Name = "_exitButton";
      this._exitButton.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this._exitButton.Size = new System.Drawing.Size(151, 22);
      this._exitButton.Text = "Exit";
      this._exitButton.Click += new System.EventHandler(this.Exit);
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
      // _logBox
      // 
      this._logBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._logBox.Location = new System.Drawing.Point(3, 3);
      this._logBox.Name = "_logBox";
      this._logBox.ReadOnly = true;
      this._logBox.Size = new System.Drawing.Size(270, 383);
      this._logBox.TabIndex = 0;
      this._logBox.Text = "";
      // 
      // _tabSend
      // 
      this._tabSend.Controls.Add(this._sendContainer);
      this._tabSend.Location = new System.Drawing.Point(4, 22);
      this._tabSend.Name = "_tabSend";
      this._tabSend.Padding = new System.Windows.Forms.Padding(3);
      this._tabSend.Size = new System.Drawing.Size(276, 389);
      this._tabSend.TabIndex = 1;
      this._tabSend.Text = "Send";
      this._tabSend.UseVisualStyleBackColor = true;
      // 
      // _sendContainer
      // 
      this._sendContainer.ColumnCount = 1;
      this._sendContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this._sendContainer.Controls.Add(this._sendInputGroup, 0, 0);
      this._sendContainer.Controls.Add(this._sendFileGroup, 0, 1);
      this._sendContainer.Controls.Add(this._sendActionsGroup, 0, 2);
      this._sendContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendContainer.Location = new System.Drawing.Point(3, 3);
      this._sendContainer.Name = "_sendContainer";
      this._sendContainer.RowCount = 3;
      this._sendContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this._sendContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this._sendContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this._sendContainer.Size = new System.Drawing.Size(270, 383);
      this._sendContainer.TabIndex = 0;
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
      // _sendInputBox
      // 
      this._sendInputBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendInputBox.Location = new System.Drawing.Point(3, 16);
      this._sendInputBox.Multiline = true;
      this._sendInputBox.Name = "_sendInputBox";
      this._sendInputBox.Size = new System.Drawing.Size(258, 128);
      this._sendInputBox.TabIndex = 0;
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
      // _sendFileContainer
      // 
      this._sendFileContainer.ColumnCount = 2;
      this._sendFileContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendFileContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._sendFileContainer.Controls.Add(this._sendFileButton, 0, 2);
      this._sendFileContainer.Controls.Add(this._sendFileRemoveButton, 1, 2);
      this._sendFileContainer.Controls.Add(this._sendFileLabel, 0, 0);
      this._sendFileContainer.Controls.Add(this._sendFileName, 1, 0);
      this._sendFileContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendFileContainer.Location = new System.Drawing.Point(3, 16);
      this._sendFileContainer.Name = "_sendFileContainer";
      this._sendFileContainer.RowCount = 3;
      this._sendFileContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._sendFileContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this._sendFileContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
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
      this._sendFileRemoveButton.Enabled = false;
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
      this._sendFileLabel.Size = new System.Drawing.Size(123, 13);
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
      this._sendFileName.Size = new System.Drawing.Size(123, 13);
      this._sendFileName.TabIndex = 1;
      this._sendFileName.Text = "file.txt";
      this._sendFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
      this._sendActionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._sendActionsContainer.Size = new System.Drawing.Size(258, 52);
      this._sendActionsContainer.TabIndex = 0;
      // 
      // _sendButton
      // 
      this._sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._sendButton.Enabled = false;
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
      this._sendCancelButton.Enabled = false;
      this._sendCancelButton.Location = new System.Drawing.Point(132, 26);
      this._sendCancelButton.Name = "_sendCancelButton";
      this._sendCancelButton.Size = new System.Drawing.Size(123, 23);
      this._sendCancelButton.TabIndex = 1;
      this._sendCancelButton.Text = "Cancel";
      this._sendCancelButton.UseVisualStyleBackColor = true;
      // 
      // _tabReceive
      // 
      this._tabReceive.Controls.Add(this._receiveGroup);
      this._tabReceive.Location = new System.Drawing.Point(4, 22);
      this._tabReceive.Name = "_tabReceive";
      this._tabReceive.Size = new System.Drawing.Size(276, 389);
      this._tabReceive.TabIndex = 2;
      this._tabReceive.Text = "Receive";
      this._tabReceive.UseVisualStyleBackColor = true;
      // 
      // _receiveGroup
      // 
      this._receiveGroup.Controls.Add(this._receiveActionsContainer);
      this._receiveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this._receiveGroup.Location = new System.Drawing.Point(0, 0);
      this._receiveGroup.Name = "_receiveGroup";
      this._receiveGroup.Size = new System.Drawing.Size(276, 389);
      this._receiveGroup.TabIndex = 0;
      this._receiveGroup.TabStop = false;
      this._receiveGroup.Text = "Actions";
      // 
      // _receiveActionsContainer
      // 
      this._receiveActionsContainer.ColumnCount = 1;
      this._receiveActionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this._receiveActionsContainer.Controls.Add(this._receiveListenButton, 0, 0);
      this._receiveActionsContainer.Controls.Add(this._receiveStopButton, 0, 1);
      this._receiveActionsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._receiveActionsContainer.Location = new System.Drawing.Point(3, 16);
      this._receiveActionsContainer.Name = "_receiveActionsContainer";
      this._receiveActionsContainer.RowCount = 3;
      this._receiveActionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._receiveActionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._receiveActionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this._receiveActionsContainer.Size = new System.Drawing.Size(270, 370);
      this._receiveActionsContainer.TabIndex = 0;
      // 
      // _receiveListenButton
      // 
      this._receiveListenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._receiveListenButton.Location = new System.Drawing.Point(3, 3);
      this._receiveListenButton.Name = "_receiveListenButton";
      this._receiveListenButton.Size = new System.Drawing.Size(264, 23);
      this._receiveListenButton.TabIndex = 0;
      this._receiveListenButton.Text = "Listen";
      this._receiveListenButton.UseVisualStyleBackColor = true;
      // 
      // _receiveStopButton
      // 
      this._receiveStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._receiveStopButton.Enabled = false;
      this._receiveStopButton.Location = new System.Drawing.Point(3, 32);
      this._receiveStopButton.Name = "_receiveStopButton";
      this._receiveStopButton.Size = new System.Drawing.Size(264, 23);
      this._receiveStopButton.TabIndex = 1;
      this._receiveStopButton.Text = "Stop";
      this._receiveStopButton.UseVisualStyleBackColor = true;
      // 
      // _tabOptions
      // 
      this._tabOptions.Controls.Add(this._optionsContainer);
      this._tabOptions.Location = new System.Drawing.Point(4, 22);
      this._tabOptions.Name = "_tabOptions";
      this._tabOptions.Size = new System.Drawing.Size(276, 389);
      this._tabOptions.TabIndex = 3;
      this._tabOptions.Text = "Options";
      this._tabOptions.UseVisualStyleBackColor = true;
      // 
      // _optionsContainer
      // 
      this._optionsContainer.ColumnCount = 1;
      this._optionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this._optionsContainer.Controls.Add(this._sendingGroup, 0, 1);
      this._optionsContainer.Controls.Add(this._optionsGroup, 0, 0);
      this._optionsContainer.Controls.Add(this._optionsActionsGroup, 0, 2);
      this._optionsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsContainer.Location = new System.Drawing.Point(0, 0);
      this._optionsContainer.Name = "_optionsContainer";
      this._optionsContainer.RowCount = 3;
      this._optionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this._optionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
      this._optionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this._optionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this._optionsContainer.Size = new System.Drawing.Size(276, 389);
      this._optionsContainer.TabIndex = 0;
      // 
      // _sendingGroup
      // 
      this._sendingGroup.Controls.Add(this.tableLayoutPanel1);
      this._sendingGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingGroup.Location = new System.Drawing.Point(3, 158);
      this._sendingGroup.Name = "_sendingGroup";
      this._sendingGroup.Size = new System.Drawing.Size(270, 149);
      this._sendingGroup.TabIndex = 3;
      this._sendingGroup.TabStop = false;
      this._sendingGroup.Text = "Sending";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel1.Controls.Add(this._sendingPortLabel, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this._sendingAddressLabel, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this._sendingAddressBox, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this._sendingPortBox, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this._sendingSizeLabel, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this._sendingSizeBox, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this._sendingErrorLabel, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this._sendingErrorCheckBox, 1, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 130);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // _sendingPortLabel
      // 
      this._sendingPortLabel.AutoSize = true;
      this._sendingPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingPortLabel.Location = new System.Drawing.Point(3, 26);
      this._sendingPortLabel.Name = "_sendingPortLabel";
      this._sendingPortLabel.Size = new System.Drawing.Size(73, 26);
      this._sendingPortLabel.TabIndex = 2;
      this._sendingPortLabel.Text = "Port";
      this._sendingPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // _sendingAddressLabel
      // 
      this._sendingAddressLabel.AutoSize = true;
      this._sendingAddressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingAddressLabel.Location = new System.Drawing.Point(3, 0);
      this._sendingAddressLabel.Name = "_sendingAddressLabel";
      this._sendingAddressLabel.Size = new System.Drawing.Size(73, 26);
      this._sendingAddressLabel.TabIndex = 0;
      this._sendingAddressLabel.Text = "Address";
      this._sendingAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // _sendingAddressBox
      // 
      this._sendingAddressBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingAddressBox.Location = new System.Drawing.Point(82, 3);
      this._sendingAddressBox.Name = "_sendingAddressBox";
      this._sendingAddressBox.Size = new System.Drawing.Size(179, 20);
      this._sendingAddressBox.TabIndex = 1;
      this._sendingAddressBox.TextChanged += new System.EventHandler(this.OptionChanged);
      // 
      // _sendingPortBox
      // 
      this._sendingPortBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingPortBox.Location = new System.Drawing.Point(82, 29);
      this._sendingPortBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this._sendingPortBox.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
      this._sendingPortBox.Name = "_sendingPortBox";
      this._sendingPortBox.Size = new System.Drawing.Size(179, 20);
      this._sendingPortBox.TabIndex = 3;
      this._sendingPortBox.Value = new decimal(new int[] {
            6994,
            0,
            0,
            0});
      this._sendingPortBox.ValueChanged += new System.EventHandler(this.OptionChanged);
      // 
      // _sendingSizeLabel
      // 
      this._sendingSizeLabel.AutoSize = true;
      this._sendingSizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingSizeLabel.Location = new System.Drawing.Point(3, 52);
      this._sendingSizeLabel.Name = "_sendingSizeLabel";
      this._sendingSizeLabel.Size = new System.Drawing.Size(73, 26);
      this._sendingSizeLabel.TabIndex = 4;
      this._sendingSizeLabel.Text = "Max Part Size";
      this._sendingSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // _sendingSizeBox
      // 
      this._sendingSizeBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingSizeBox.Location = new System.Drawing.Point(82, 55);
      this._sendingSizeBox.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
      this._sendingSizeBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this._sendingSizeBox.Name = "_sendingSizeBox";
      this._sendingSizeBox.Size = new System.Drawing.Size(179, 20);
      this._sendingSizeBox.TabIndex = 5;
      this._sendingSizeBox.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this._sendingSizeBox.ValueChanged += new System.EventHandler(this.OptionChanged);
      // 
      // _sendingErrorLabel
      // 
      this._sendingErrorLabel.AutoSize = true;
      this._sendingErrorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingErrorLabel.Location = new System.Drawing.Point(3, 78);
      this._sendingErrorLabel.Name = "_sendingErrorLabel";
      this._sendingErrorLabel.Size = new System.Drawing.Size(73, 20);
      this._sendingErrorLabel.TabIndex = 6;
      this._sendingErrorLabel.Text = "Corrupt";
      this._sendingErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // _sendingErrorCheckBox
      // 
      this._sendingErrorCheckBox.AutoSize = true;
      this._sendingErrorCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._sendingErrorCheckBox.Location = new System.Drawing.Point(82, 81);
      this._sendingErrorCheckBox.Name = "_sendingErrorCheckBox";
      this._sendingErrorCheckBox.Size = new System.Drawing.Size(179, 14);
      this._sendingErrorCheckBox.TabIndex = 7;
      this._sendingErrorCheckBox.UseVisualStyleBackColor = true;
      this._sendingErrorCheckBox.CheckedChanged += new System.EventHandler(this.OptionChanged);
      // 
      // _optionsGroup
      // 
      this._optionsGroup.Controls.Add(this._optionsInputContainer);
      this._optionsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsGroup.Location = new System.Drawing.Point(3, 3);
      this._optionsGroup.Name = "_optionsGroup";
      this._optionsGroup.Size = new System.Drawing.Size(270, 149);
      this._optionsGroup.TabIndex = 0;
      this._optionsGroup.TabStop = false;
      this._optionsGroup.Text = "Options";
      // 
      // _optionsInputContainer
      // 
      this._optionsInputContainer.ColumnCount = 2;
      this._optionsInputContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this._optionsInputContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this._optionsInputContainer.Controls.Add(this._optionsPortLabel, 0, 1);
      this._optionsInputContainer.Controls.Add(this._optionsNameLabel, 0, 0);
      this._optionsInputContainer.Controls.Add(this._optionsNameBox, 1, 0);
      this._optionsInputContainer.Controls.Add(this._optionsPortBox, 1, 1);
      this._optionsInputContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsInputContainer.Location = new System.Drawing.Point(3, 16);
      this._optionsInputContainer.Name = "_optionsInputContainer";
      this._optionsInputContainer.RowCount = 3;
      this._optionsInputContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._optionsInputContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._optionsInputContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this._optionsInputContainer.Size = new System.Drawing.Size(264, 130);
      this._optionsInputContainer.TabIndex = 0;
      // 
      // _optionsPortLabel
      // 
      this._optionsPortLabel.AutoSize = true;
      this._optionsPortLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsPortLabel.Location = new System.Drawing.Point(3, 26);
      this._optionsPortLabel.Name = "_optionsPortLabel";
      this._optionsPortLabel.Size = new System.Drawing.Size(73, 26);
      this._optionsPortLabel.TabIndex = 2;
      this._optionsPortLabel.Text = "Port";
      this._optionsPortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // _optionsNameLabel
      // 
      this._optionsNameLabel.AutoSize = true;
      this._optionsNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsNameLabel.Location = new System.Drawing.Point(3, 0);
      this._optionsNameLabel.Name = "_optionsNameLabel";
      this._optionsNameLabel.Size = new System.Drawing.Size(73, 26);
      this._optionsNameLabel.TabIndex = 0;
      this._optionsNameLabel.Text = "Name";
      this._optionsNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // _optionsNameBox
      // 
      this._optionsNameBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsNameBox.Location = new System.Drawing.Point(82, 3);
      this._optionsNameBox.Name = "_optionsNameBox";
      this._optionsNameBox.Size = new System.Drawing.Size(179, 20);
      this._optionsNameBox.TabIndex = 1;
      this._optionsNameBox.TextChanged += new System.EventHandler(this.OptionChanged);
      // 
      // _optionsPortBox
      // 
      this._optionsPortBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsPortBox.Location = new System.Drawing.Point(82, 29);
      this._optionsPortBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
      this._optionsPortBox.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
      this._optionsPortBox.Name = "_optionsPortBox";
      this._optionsPortBox.Size = new System.Drawing.Size(179, 20);
      this._optionsPortBox.TabIndex = 3;
      this._optionsPortBox.Value = new decimal(new int[] {
            6994,
            0,
            0,
            0});
      this._optionsPortBox.ValueChanged += new System.EventHandler(this.OptionChanged);
      // 
      // _optionsActionsGroup
      // 
      this._optionsActionsGroup.Controls.Add(this._optionsActionsContainer);
      this._optionsActionsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsActionsGroup.Location = new System.Drawing.Point(3, 313);
      this._optionsActionsGroup.Name = "_optionsActionsGroup";
      this._optionsActionsGroup.Size = new System.Drawing.Size(270, 73);
      this._optionsActionsGroup.TabIndex = 1;
      this._optionsActionsGroup.TabStop = false;
      this._optionsActionsGroup.Text = "Actions";
      // 
      // _optionsActionsContainer
      // 
      this._optionsActionsContainer.ColumnCount = 2;
      this._optionsActionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._optionsActionsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this._optionsActionsContainer.Controls.Add(this._optionsSaveButton, 0, 0);
      this._optionsActionsContainer.Controls.Add(this._optionsCancelButton, 1, 0);
      this._optionsActionsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this._optionsActionsContainer.Location = new System.Drawing.Point(3, 16);
      this._optionsActionsContainer.Name = "_optionsActionsContainer";
      this._optionsActionsContainer.RowCount = 1;
      this._optionsActionsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this._optionsActionsContainer.Size = new System.Drawing.Size(264, 54);
      this._optionsActionsContainer.TabIndex = 0;
      // 
      // _optionsSaveButton
      // 
      this._optionsSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._optionsSaveButton.Enabled = false;
      this._optionsSaveButton.Location = new System.Drawing.Point(3, 28);
      this._optionsSaveButton.Name = "_optionsSaveButton";
      this._optionsSaveButton.Size = new System.Drawing.Size(126, 23);
      this._optionsSaveButton.TabIndex = 0;
      this._optionsSaveButton.Text = "Save";
      this._optionsSaveButton.UseVisualStyleBackColor = true;
      this._optionsSaveButton.Click += new System.EventHandler(this.Save);
      // 
      // _optionsCancelButton
      // 
      this._optionsCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this._optionsCancelButton.Enabled = false;
      this._optionsCancelButton.Location = new System.Drawing.Point(135, 28);
      this._optionsCancelButton.Name = "_optionsCancelButton";
      this._optionsCancelButton.Size = new System.Drawing.Size(126, 23);
      this._optionsCancelButton.TabIndex = 1;
      this._optionsCancelButton.Text = "Cancel";
      this._optionsCancelButton.UseVisualStyleBackColor = true;
      this._optionsCancelButton.Click += new System.EventHandler(this.Cancel);
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
      this.MinimumSize = new System.Drawing.Size(300, 500);
      this.Name = "MainForm";
      this.ShowIcon = false;
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "Udpit";
      this._mainMenu.ResumeLayout(false);
      this._mainMenu.PerformLayout();
      this._tabContainer.ResumeLayout(false);
      this._tabLog.ResumeLayout(false);
      this._tabSend.ResumeLayout(false);
      this._sendContainer.ResumeLayout(false);
      this._sendInputGroup.ResumeLayout(false);
      this._sendInputGroup.PerformLayout();
      this._sendFileGroup.ResumeLayout(false);
      this._sendFileContainer.ResumeLayout(false);
      this._sendFileContainer.PerformLayout();
      this._sendActionsGroup.ResumeLayout(false);
      this._sendActionsContainer.ResumeLayout(false);
      this._tabReceive.ResumeLayout(false);
      this._receiveGroup.ResumeLayout(false);
      this._receiveActionsContainer.ResumeLayout(false);
      this._tabOptions.ResumeLayout(false);
      this._optionsContainer.ResumeLayout(false);
      this._sendingGroup.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this._sendingPortBox)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this._sendingSizeBox)).EndInit();
      this._optionsGroup.ResumeLayout(false);
      this._optionsInputContainer.ResumeLayout(false);
      this._optionsInputContainer.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this._optionsPortBox)).EndInit();
      this._optionsActionsGroup.ResumeLayout(false);
      this._optionsActionsContainer.ResumeLayout(false);
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
    private System.Windows.Forms.TableLayoutPanel _sendContainer;
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
    private System.Windows.Forms.GroupBox _receiveGroup;
    private System.Windows.Forms.TableLayoutPanel _receiveActionsContainer;
    private System.Windows.Forms.Button _receiveListenButton;
    private System.Windows.Forms.Button _receiveStopButton;
    private System.Windows.Forms.TableLayoutPanel _optionsContainer;
    private System.Windows.Forms.GroupBox _optionsGroup;
    private System.Windows.Forms.GroupBox _optionsActionsGroup;
    private System.Windows.Forms.TableLayoutPanel _optionsInputContainer;
    private System.Windows.Forms.Label _optionsNameLabel;
    private System.Windows.Forms.TextBox _optionsNameBox;
    private System.Windows.Forms.Label _optionsPortLabel;
    private System.Windows.Forms.TableLayoutPanel _optionsActionsContainer;
    private System.Windows.Forms.Button _optionsSaveButton;
    private System.Windows.Forms.Button _optionsCancelButton;
    private System.Windows.Forms.NumericUpDown _optionsPortBox;
    private System.Windows.Forms.RichTextBox _logBox;
    private System.Windows.Forms.GroupBox _sendingGroup;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label _sendingPortLabel;
    private System.Windows.Forms.Label _sendingAddressLabel;
    private System.Windows.Forms.TextBox _sendingAddressBox;
    private System.Windows.Forms.NumericUpDown _sendingPortBox;
    private System.Windows.Forms.Label _sendingSizeLabel;
    private System.Windows.Forms.NumericUpDown _sendingSizeBox;
    private System.Windows.Forms.Label _sendingErrorLabel;
    private System.Windows.Forms.CheckBox _sendingErrorCheckBox;
  }
}