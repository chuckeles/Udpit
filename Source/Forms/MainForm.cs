using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main application form.
  /// </summary>
  public partial class MainForm : Form {

    public MainForm() {
      InitializeComponent();
    }

    /// <summary>
    /// Exits the application.
    /// </summary>
    private void Exit(object sender, System.EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    /// Restarts the application.
    /// </summary>
    private void Restart(object sender, System.EventArgs e) {
      Application.Restart();
    }
  }

}
