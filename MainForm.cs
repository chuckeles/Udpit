using System;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main windows form for the application.
  /// </summary>
  public partial class MainForm : Form {

    public MainForm() {
      // check singleton
      if (Singleton != null) {
        Dispose();
        return;
      }

      // initialize
      InitializeComponent();

      // set singleton
      Singleton = this;

      // create forms
      _aboutForm = new AboutForm();
      _optionsForm = new OptionsForm();
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void ExitApplication(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    ///   Restarts the application.
    /// </summary>
    private void RestartApplication(object sender, EventArgs e) {
      Application.Restart();
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
    /// Main form singleton.
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
