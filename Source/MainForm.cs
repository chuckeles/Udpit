using System;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main windows form for the application.
  /// </summary>
  public partial class MainForm : Form {

    private MainForm() {
      InitializeComponent();
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
    ///   Restarts the application.
    /// </summary>
    private void RestartApplication(object sender, EventArgs e) {
      Application.Restart();
    }

    /// <summary>
    ///   Main form singleton.
    /// </summary>
    public static MainForm Singleton { get; private set; }

  }

}
