using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main application form.
  /// </summary>
  public partial class MainForm : Form {

    public MainForm() {
      // initialize
      InitializeComponent();

      // hook up the log
      Log.Singleton.MessageLogged += (sender, message) => {
        if (_logBox.InvokeRequired)
          _logBox.Invoke(new MethodInvoker(() => WriteToLog(message, false)));
        else
          WriteToLog(message, false);
      };
      Log.Singleton.ErrorLogged += (sender, message) => {
        if (_logBox.InvokeRequired)
          _logBox.Invoke(new MethodInvoker(() => WriteToLog(message, true)));
        else
          WriteToLog(message, true);
      };

      // hook up the listening event
      Transmitter.Singleton.StoppedListening += UpdateListening;

      // hook up the state changed event
      MessageCenter.Singleton.StatusChanged += UpdateStatus;

      // hook up the progress event
      MessageCenter.Singleton.ProgressChanged += UpdateProgress;

      // log the start
      Log.Singleton.LogMessage("Udpit has started");

      // log the option tip
      Log.Singleton.LogMessage("Go to the <Options> and set things up");

      // set option inputs
      SetOptionInputs();
    }

    /// <summary>
    /// Update shown progress.
    /// </summary>
    private void UpdateProgress(object sender, KeyValuePair<ushort, ushort> progress) {
      _statusBar.Invoke(new MethodInvoker(() => {
        _statusProgressBar.Maximum = progress.Value;
        _statusProgressBar.Value = progress.Key;
      }));
    }

    /// <summary>
    /// Update shown status.
    /// </summary>
    private void UpdateStatus(object sender, MessageStatus status) {
      _statusBar.Invoke(new MethodInvoker(() => _statusLabel.Text = status.ToString()));
    }

    /// <summary>
    ///   Cancels modifying options.
    /// </summary>
    private void Cancel(object sender, EventArgs e) {
      // reset inputs
      SetOptionInputs();

      // disable buttons
      _optionsSaveButton.Enabled = false;
      _optionsCancelButton.Enabled = false;
    }

    /// <summary>
    ///   Cancel sending a message and reset inputs.
    /// </summary>
    private void CancelSending(object sender, EventArgs e) {
      // reset input box
      _sendInputBox.Enabled = true;
      _sendInputBox.Text = "";

      // remove input file
      _file = "";
      _sendFileName.Text = "<none>";

      // reset file buttons
      _sendFileButton.Enabled = true;
      _sendFileRemoveButton.Enabled = false;
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void Exit(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    ///   Start listening.
    /// </summary>
    private void Listen(object sender, EventArgs e) {
      // tell the transmitter
      Transmitter.Singleton.Listen(false);

      // flip buttons
      _receiveListenButton.Enabled = false;
      _receiveStopButton.Enabled = true;

      // go to the log tab
      _tabContainer.SelectTab(_tabLog);
    }

    /// <summary>
    ///   Checks the option inputs and enables / disables buttons.
    /// </summary>
    private void OptionChanged(object sender, EventArgs e) {
      // compare names
      var namesEqual = _optionsNameBox.Text.Equals(Options.Name);

      // compare ports
      var portsEqual = _optionsPortBox.Value == Options.Port;

      // compare remote address
      IPAddress addr;
      var addrEqual = IPAddress.TryParse(_sendingAddressBox.Text, out addr) && addr.Equals(Options.Remote.Address);

      // compare remote port
      var remotePortsEqual = _sendingPortBox.Value == Options.Remote.Port;

      // compare max size
      var sizesEqual = _sendingSizeBox.Value == Options.MaxPartSize;

      // compare corrupt
      var corruptsEqual = _sendingErrorCheckBox.Checked == Options.SendCorrupt;

      // compare miss
      var losesEqual = _sendingLoseChackbox.Checked == Options.LoseFragments;

      // update buttons
      if (namesEqual && portsEqual && addrEqual && remotePortsEqual && sizesEqual && corruptsEqual && losesEqual) {
        _optionsSaveButton.Enabled = false;
        _optionsCancelButton.Enabled = false;
      }
      else {
        _optionsSaveButton.Enabled = true;
        _optionsCancelButton.Enabled = true;
      }
    }

    /// <summary>
    ///   Removes the selected file.
    /// </summary>
    private void RemoveFile(object sender, EventArgs e) {
      // reset file
      _file = "";

      // enable input
      _sendInputBox.Enabled = true;

      // flip buttons
      _sendFileButton.Enabled = true;
      _sendFileRemoveButton.Enabled = false;

      // update label
      _sendFileName.Text = "<none>";

      // reset send buttons
      SendTextChanged(this, EventArgs.Empty);
    }

    /// <summary>
    ///   Restarts the application.
    /// </summary>
    private void Restart(object sender, EventArgs e) {
      Application.Restart();
    }

    /// <summary>
    ///   Saves the options.
    /// </summary>
    private void Save(object sender, EventArgs e) {
      // save options
      Options.Name = _optionsNameBox.Text;
      Options.Port = (int) _optionsPortBox.Value;

      // save remote
      IPAddress addr;
      if (IPAddress.TryParse(_sendingAddressBox.Text, out addr))
        Options.Remote = new IPEndPoint(addr, (int) _sendingPortBox.Value);

      // save max size
      Options.MaxPartSize = (ushort) _sendingSizeBox.Value;

      // save corrupt
      Options.SendCorrupt = _sendingErrorCheckBox.Checked;

      // save lose
      Options.LoseFragments = _sendingLoseChackbox.Checked;

      // reset inputs
      SetOptionInputs();

      // disable buttons
      _optionsSaveButton.Enabled = false;
      _optionsCancelButton.Enabled = false;

      // log
      Log.Singleton.LogMessage("Options changed");
    }

    /// <summary>
    ///   Selects a file to send.
    /// </summary>
    private void SelectFile(object sender, EventArgs e) {
      // show an open file dialog
      var dialog = new OpenFileDialog();
      var result = dialog.ShowDialog(this);

      if (result == DialogResult.OK) {
        // get the file
        _file = dialog.FileName;

        // disable input
        _sendInputBox.Enabled = false;

        // flip buttons
        _sendFileButton.Enabled = false;
        _sendFileRemoveButton.Enabled = true;

        // update label
        _sendFileName.Text = Path.GetFileName(_file);

        // enable send buttons
        _sendButton.Enabled = true;
        _sendCancelButton.Enabled = true;
      }
    }

    /// <summary>
    ///   Sends the message from the user input.
    /// </summary>
    private void Send(object sender, EventArgs e) {
      // check file
      if (!_file.Equals("")) {
        // delegate to the message center
        MessageCenter.Singleton.SendFileMessage(_file);
      }
      else {
        // delegate to the message center
        MessageCenter.Singleton.SendMessage(_sendInputBox.Text);
      }

      // reset input
      CancelSending(this, EventArgs.Empty);

      // switch to the log tab
      _tabContainer.SelectTab(_tabLog);
    }

    /// <summary>
    ///   Enables / disables send buttons based on send input.
    /// </summary>
    private void SendTextChanged(object sender, EventArgs e) {
      // check the input box
      if (_sendInputBox.Text.Equals("")) {
        // disable buttons
        _sendButton.Enabled = false;
        _sendCancelButton.Enabled = false;
      }
      else {
        // enable buttons
        _sendButton.Enabled = true;
        _sendCancelButton.Enabled = true;
      }
    }

    /// <summary>
    ///   Gets current options and updates inputs.
    /// </summary>
    private void SetOptionInputs() {
      // set name
      _optionsNameBox.Text = Options.Name;

      // set port
      _optionsPortBox.Value = Options.Port;

      // set remote address and port
      _sendingAddressBox.Text = Options.Remote.Address.ToString();
      _sendingPortBox.Value = Options.Remote.Port;

      // set max size
      _sendingSizeBox.Value = Options.MaxPartSize;

      // set corrupt
      _sendingErrorCheckBox.Checked = Options.SendCorrupt;

      // set lose
      _sendingLoseChackbox.Checked = Options.LoseFragments;
    }

    /// <summary>
    ///   Start listening.
    /// </summary>
    private void StopListening(object sender, EventArgs e) {
      // tell the transmitter
      Transmitter.Singleton.StopListening();

      // flip buttons
      _receiveListenButton.Enabled = true;
      _receiveStopButton.Enabled = false;
    }

    /// <summary>
    ///   Updates listening buttons when not listening.
    /// </summary>
    private void UpdateListening(object sender, EventArgs e) {
      // move to the GUI thread
      _receiveListenButton.Invoke(new MethodInvoker(() => _receiveListenButton.Enabled = true));
      _receiveStopButton.Invoke(new MethodInvoker(() => _receiveStopButton.Enabled = false));
    }

    /// <summary>
    ///   Logs messages.
    /// </summary>
    private void WriteToLog(string message, bool error) {
      // get time
      var time = DateTime.Now;

      // write the time
      _logBox.SelectionColor = Color.Chocolate;
      _logBox.AppendText($"[{time.Hour}:{time.Minute}:{time.Second}:{time.Millisecond}] ");

      // write the message
      _logBox.SelectionColor = error ? Color.Red : DefaultForeColor;
      foreach (var c in message) {
        // text in <...> is a different color
        if (c == '<')
          _logBox.SelectionColor = Color.BlueViolet;
        else if (c == '>')
          _logBox.SelectionColor = error ? Color.Red : DefaultForeColor;

        // append
        else
          _logBox.AppendText(c.ToString());
      }

      // end line
      _logBox.AppendText("\n");
    }

    /// <summary>
    ///   Selected file.
    /// </summary>
    private string _file = "";

  }

}
