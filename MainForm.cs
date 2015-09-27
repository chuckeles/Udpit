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
      AboutForm = new AboutForm();
      OptionsForm = new OptionsForm();
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
      if (!AboutForm.Visible)
        AboutForm.Show(this);
    }

    /// <summary>
    ///   Shows the options form.
    /// </summary>
    private void ShowOptions(object sender, EventArgs e) {
      if (!OptionsForm.Visible)
        OptionsForm.Show(this);
    }

    /// <summary>
    ///   Main form singleton.
    /// </summary>
    public static MainForm Singleton { get; private set; }

    /// <summary>
    ///   The about form.
    /// </summary>
    public readonly AboutForm AboutForm;

    /// <summary>
    ///   The options form.
    /// </summary>
    public readonly OptionsForm OptionsForm;

  }

}
