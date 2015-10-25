using System;
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

      // get the current port
      portBox.Text = Options.Port.ToString();
    }

    /// <summary>
    ///   Save the options.
    /// </summary>
    private void Save(object sender, EventArgs e) {
      // check the options
      if (nameBox.Text != "") {
        // save
        Options.Name = nameBox.Text;
        Options.Port = (int) portBox.Value;

        // tell sender and receiver to update ports
        Sender.Singleton.UpdatePort();
        Receiver.Singleton.UpdatePort();

        // set dialog result
        DialogResult = DialogResult.OK;
      }
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

  }

}
