using System;
using System.Drawing;
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

      // add message box text
      SetMessageBoxText();

      // hook up options changed event
      HookOptions();

      // hook up to incoming messages
      HookIncomingMessage();
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
    ///   Adds a send message to the message box.
    /// </summary>
    private void AddReceiveMessage(string message) {
      messageBox.Invoke(new MethodInvoker(delegate {
        // add message
        messageBox.AppendText("received message ");
        messageBox.SelectionColor = Color.DarkBlue;
        messageBox.AppendText(message);
        messageBox.SelectionColor = Color.Empty;
        messageBox.AppendText("\n");
      }));
    }

    /// <summary>
    ///   Adds a send message to the message box.
    /// </summary>
    private void AddSendMessage(string message, string name, string destination) {
      // add message
      messageBox.AppendText("sending message ");
      messageBox.SelectionColor = Color.DarkBlue;
      messageBox.AppendText(message);
      messageBox.SelectionColor = Color.Empty;
      messageBox.AppendText("\n");

      // add info
      messageBox.SelectionIndent = 16;
      messageBox.AppendText("name: ");
      messageBox.SelectionColor = Color.DarkViolet;
      messageBox.AppendText(name);
      messageBox.SelectionColor = Color.Empty;
      messageBox.AppendText("\ndestination: ");
      messageBox.SelectionColor = Color.DarkViolet;
      messageBox.AppendText(destination);
      messageBox.SelectionColor = Color.Empty;
      messageBox.AppendText("\n");
      messageBox.SelectionIndent = 0;
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void ExitApplication(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    ///   Listen to incoming messages.
    /// </summary>
    private void HookIncomingMessage() {
      // get udper
      var udper = Udper.Singleton;

      // hook up
      udper.OnMessage += message => { AddReceiveMessage(message); };
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
      messageBox.Text = "";
      messageBox.SelectionAlignment = HorizontalAlignment.Left;
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

      // check input
      if (input == "")
        return;

      // tell udper to do it's thing
      udper.SendMessage(input);

      // add the message box
      AddSendMessage(input, udper.Name, udper.Destination.ToString());
    }

    /// <summary>
    ///   Set up message box text when it is disabled.
    /// </summary>
    private void SetMessageBoxText() {
      messageBox.Text = "";
      messageBox.SelectionAlignment = HorizontalAlignment.Center;

      messageBox.AppendText("\n\n\n\n\n\nconfigure the application in the options");
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
