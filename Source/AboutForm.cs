using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   A form showing information about the application.
  /// </summary>
  public partial class AboutForm : Form {

    public AboutForm() {
      InitializeComponent();
    }

    /// <summary>
    ///   Hide the form instead of closing it.
    /// </summary>
    private void OnClose(object sender, FormClosingEventArgs e) {
      if (e.CloseReason != CloseReason.UserClosing)
        return;

      e.Cancel = true;
      Hide();
    }

  }

}
