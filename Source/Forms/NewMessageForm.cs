using System;
using System.ComponentModel;
using System.Net;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   Allows the user to create a new message.
  /// </summary>
  public partial class NewMessageForm : Form {

    public NewMessageForm() {
      InitializeComponent();
    }

    /// <summary>
    ///   Creates the requested message.
    /// </summary>
    private void CreateMessage(object sender, EventArgs e) {
      // check address
      IPAddress address;
      if (!IPAddress.TryParse(destinationAddressBox.Text, out address)) {
        // wrong format
        return;
      }

      // create a message
      MessageCenter.Singleton.CreateMessage(new IPEndPoint(address, (int) destinationPortBox.Value),
                                            messageBox.Text,
                                            (ushort) maxSizeBox.Value);

      // set dialog result
      DialogResult = DialogResult.OK;
    }

    /// <summary>
    ///   Validates the destination address and shows an error.
    /// </summary>
    private void ValidateAddress(object sender, CancelEventArgs e) {
      // check the address box
      IPAddress address;
      if (IPAddress.TryParse(destinationAddressBox.Text, out address)) {
        // cool, no error
        errorProvider.SetError(destinationAddressBox, "");

        // update the text in the box
        destinationAddressBox.Text = address.ToString();
      }
      else {
        // wrong format
        errorProvider.SetError(destinationAddressBox, "Enter a correct IP address");
      }
    }

  }

}
