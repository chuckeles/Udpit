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
