using System;
using System.Drawing;
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
      Log.Singleton.MessageLogged += WriteToLog;

      // log the start
      Log.Singleton.LogMessage("Udpit has started");

      // set option inputs
      SetOptionInputs();
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
      _sendInputBox.Text = "";

      // TODO: Reset input file
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void Exit(object sender, EventArgs e) {
      Application.Exit();
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

      // update buttons
      if (namesEqual && portsEqual && addrEqual && remotePortsEqual && sizesEqual && corruptsEqual) {
        _optionsSaveButton.Enabled = false;
        _optionsCancelButton.Enabled = false;
      }
      else {
        _optionsSaveButton.Enabled = true;
        _optionsCancelButton.Enabled = true;
      }
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

      // reset inputs
      SetOptionInputs();

      // disable buttons
      _optionsSaveButton.Enabled = false;
      _optionsCancelButton.Enabled = false;

      // log
      Log.Singleton.LogMessage("Options changed");
    }

    /// <summary>
    ///   Sends the message from the user input.
    /// </summary>
    private void Send(object sender, EventArgs e) {
      // delegate to the message center
      MessageCenter.Singleton.SendMessage(_sendInputBox.Text);

      // reset input
      _sendInputBox.Text = "";

      // TODO: Switch to the log tab
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
    }

    /// <summary>
    ///   Logs messages.
    /// </summary>
    private void WriteToLog(object sender, string message) {
      // get time
      var time = DateTime.Now;

      // write the time
      _logBox.SelectionColor = Color.Chocolate;
      _logBox.AppendText($"[{time.Hour}:{time.Minute}:{time.Second}:{time.Millisecond}] ");

      // write the message
      _logBox.SelectionColor = DefaultForeColor;
      _logBox.AppendText(message);

      // end line
      _logBox.AppendText("\n");
    }

  }

}
