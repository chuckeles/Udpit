using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   Form with the application options.
  /// </summary>
  public partial class OptionsForm : Form {

    public OptionsForm() {
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
