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
    }

    /// <summary>
    ///   Save the options.
    /// </summary>
    private void Save(object sender, EventArgs e) {
      // check the options
      if (nameBox.Text != "" && sendPortBox.Value != receivePortBox.Value) {
        // save
        Options.Name = nameBox.Text;
        Options.SendPort = (int) sendPortBox.Value;
        Options.ReceivePort = (int) receivePortBox.Value;

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

    /// <summary>
    ///   Validates the send port box and shows an error.
    /// </summary>
    private void ValidateSendPort(object sender, CancelEventArgs e) {
      // check against the other port
      if (sendPortBox.Value == receivePortBox.Value) {
        // show an error
        errorProvider.SetError(sendPortBox, "The ports can't be the same");
      }
      else {
        // the port is fine
        errorProvider.SetError(sendPortBox, "");
      }
    }

    /// <summary>
    ///   Validates the receive port box and shows an error.
    /// </summary>
    private void ValidateReceivePort(object sender, CancelEventArgs e) {
      // check against the other port
      if (receivePortBox.Value == sendPortBox.Value) {
        // show an error
        errorProvider.SetError(receivePortBox, "The ports can't be the same");
      }
      else {
        // the port is fine
        errorProvider.SetError(receivePortBox, "");
      }
    }
  }

}
