using System.ComponentModel;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   Allows to set the name.
  /// </summary>
  public partial class OptionsForm : Form {

    public OptionsForm() {
      // initialize
      InitializeComponent();

      // get the current name
      nameBox.Text = Options.Name;
    }

    /// <summary>
    ///   Validates the name box and shows an error if it is empty.
    /// </summary>
    private void ValidateName(object sender, CancelEventArgs e) {
      // check if the name is empty
      if (nameBox.Text == "") {
        // show an error
        errorProvider.SetError(nameBox, "The name is empty");
      }
      else {
        // the name is fine
        errorProvider.SetError(nameBox, "");
      }
    }

    /// <summary>
    /// Save the name to the options.
    /// </summary>
    private void SaveName(object sender, System.EventArgs e) {
      // check the name
      if (nameBox.Text != "") {
        // save
        Options.Name = nameBox.Text;

        // set dialog result
        DialogResult = DialogResult.OK;
      }
    }
  }

}
