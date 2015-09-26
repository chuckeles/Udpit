using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main windows form for the application.
  /// </summary>
  public partial class MainForm : Form {

    public MainForm() {
      InitializeComponent();
    }

    /// <summary>
    /// Exits the application.
    /// </summary>
    private void ExitApplication(object sender, System.EventArgs e) {
      Application.Exit();
    }
  }

}
