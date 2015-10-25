using System;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   The main windows form for the application.
  /// </summary>
  public partial class MainForm : Form {

    public MainForm() {
      // initialize
      InitializeComponent();

      // hook to the message center
      MessageCenter.Singleton.Changed += UpdateMessageList;
    }

    /// <summary>
    ///   Exits the application.
    /// </summary>
    private void ExitApplication(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    ///   Restarts the application.
    /// </summary>
    private void RestartApplication(object sender, EventArgs e) {
      Application.Restart();
    }

    /// <summary>
    ///   Shows the message form.
    /// </summary>
    private void ShowMessageForm(object sender, EventArgs e) {
      new MessageForm().Show(this);
    }

    /// <summary>
    ///   Shows the new message modal dialog.
    /// </summary>
    private void ShowNewMessageForm(object sender, EventArgs e) {
      var dialog = new NewMessageForm();
      dialog.ShowDialog(this);
      dialog.Dispose();
    }

    /// <summary>
    ///   Shows the options modal dialog.
    /// </summary>
    private void ShowOptionsForm(object sender, EventArgs e) {
      var dialog = new OptionsForm();
      dialog.ShowDialog(this);
      dialog.Dispose();
    }

    /// <summary>
    ///   Updates the message list.
    /// </summary>
    private void UpdateMessageList() {
      Invoke(new MethodInvoker(() => {
        // clear items
        messageList.Items.Clear();

        // iterate messages
        foreach (var message in MessageCenter.Singleton.Messages) {
          // add a list item
          messageList.Items.Add(
            new ListViewItem(new[]
            {"" + message.Value.Id[0] + message.Value.Id[1], message.Value.RemoteName, message.Value.Status.ToString()}));
        }
      }));
    }

  }

}
