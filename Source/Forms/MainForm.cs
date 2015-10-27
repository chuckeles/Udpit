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
      _logBox.AppendText($"[{DateTime.Now.ToShortTimeString()}] {message}");
    }

  }

}
