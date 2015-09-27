using System;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main windows form for the application.
  /// </summary>
  public partial class MainForm : Form {

    private MainForm() {
      // initialize
      InitializeComponent();

      // create forms
      _aboutForm = new AboutForm();
      _optionsForm = new OptionsForm();

      // hook up options changed event
      HookOptions();
    }

    /// <summary>
    ///   Creates a new singleton.
    /// </summary>
    public static MainForm Create() {
      // check singleton
      if (Singleton != null)
        return Singleton;

      // create singleton
      Singleton = new MainForm();

      // return
      return Singleton;
    }

    /// <summary>
    ///   Adds a message to the message box.
    /// </summary>
    private void AddMessage(string message) {
      messageBox.AppendText(message + '\n');
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void ExitApplication(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    ///   Hooks up on the options changed event.
    /// </summary>
    private void HookOptions() {
      _optionsForm.OptionsChanged += (sender, args) => {
        // check the udper
        if (Udper.Singleton.CanSend()) {
          // enable sending
          inputBox.Enabled = true;
          sendButton.Enabled = true;
        }
        else {
          // disable sending
          inputBox.Enabled = false;
          sendButton.Enabled = false;
        }
      };
    }

    /// <summary>
    ///   Enables and initialized the message box.
    /// </summary>
    private void InitMessageBox() {
      messageBox.TextAlign = HorizontalAlignment.Left;
      messageBox.Text = "";
      messageBox.Enabled = true;
    }

    /// <summary>
    ///   Restarts the application.
    /// </summary>
    private void RestartApplication(object sender, EventArgs e) {
      Application.Restart();
    }

    /// <summary>
    ///   Sends an input message.
    /// </summary>
    private void SendMessage(object sender, EventArgs e) {
      // check message box
      if (!messageBox.Enabled)
        InitMessageBox();

      // get udper
      var udper = Udper.Singleton;

      // get input
      var input = inputBox.Text;
      inputBox.Text = "";

      // tell udper to do it's thing
      udper.SendMessage(input);

      // add the message box
      AddMessage($"sending message \"{input}\" as {udper.Name} to {udper.Destination}");
    }

    /// <summary>
    ///   Shows the about form.
    /// </summary>
    private void ShowAbout(object sender, EventArgs e) {
      if (!_aboutForm.Visible)
        _aboutForm.Show(this);
    }

    /// <summary>
    ///   Shows the options form.
    /// </summary>
    private void ShowOptions(object sender, EventArgs e) {
      if (!_optionsForm.Visible)
        _optionsForm.Show(this);
    }

    /// <summary>
    ///   Main form singleton.
    /// </summary>
    public static MainForm Singleton { get; private set; }

    /// <summary>
    ///   The about form.
    /// </summary>
    private readonly AboutForm _aboutForm;

    /// <summary>
    ///   The options form.
    /// </summary>
    private readonly OptionsForm _optionsForm;

  }

}
