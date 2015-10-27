using System;
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
    /// Gets current options and updates inputs.
    /// </summary>
    private void SetOptionInputs() {
      // set name
      _optionsNameBox.Text = Options.Name;

      // set port
      _optionsPortBox.Text = Options.Port.ToString();
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void Exit(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    ///   Restarts the application.
    /// </summary>
    private void Restart(object sender, EventArgs e) {
      Application.Restart();
    }

    /// <summary>
    ///   Logs messages.
    /// </summary>
    private void WriteToLog(object sender, string message) {
      _logBox.AppendText($"[{DateTime.Now.ToShortTimeString()}] {message}\n");
    }

    /// <summary>
    /// Checks the option inputs and enables / disables buttons.
    /// </summary>
    private void OptionChanged(object sender, EventArgs e) {
      // compare names
      var namesEqual = _optionsNameBox.Text == Options.Name;

      // compare ports
      var portsEqual = _optionsPortBox.Text == Options.Port.ToString();

      // update buttons
      if (namesEqual && portsEqual) {
        _optionsSaveButton.Enabled = false;
        _optionsCancelButton.Enabled = false;
      }
      else {
        _optionsSaveButton.Enabled = true;
        _optionsCancelButton.Enabled = true;
      }
    }

    /// <summary>
    /// Cancels modifying options.
    /// </summary>
    private void Cancel(object sender, EventArgs e) {
      // reset inputs
      SetOptionInputs();

      // disable buttons
      _optionsSaveButton.Enabled = false;
      _optionsCancelButton.Enabled = false;
    }

    /// <summary>
    /// Saves the options.
    /// </summary>
    private void Save(object sender, EventArgs e) {
      // save options
      Options.Name = _optionsNameBox.Text;
      Options.Port = int.Parse(_optionsPortBox.Text);

      // reset inputs
      SetOptionInputs();

      // disable buttons
      _optionsSaveButton.Enabled = false;
      _optionsCancelButton.Enabled = false;

      // log
      Log.Singleton.LogMessage("Options changed");
    }
  }

}
