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

      // add message box text
      SetMessageBoxText();
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
    ///   Exits the application.
    /// </summary>
    private void ExitApplication(object sender, EventArgs e) {
      Application.Exit();
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
