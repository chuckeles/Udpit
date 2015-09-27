using System;
using System.Windows.Forms;

namespace Udpit {

  /// <summary>
  ///   Form with the application options.
  /// </summary>
  public partial class OptionsForm : Form {

    public OptionsForm() {
      // initialize component
      InitializeComponent();

      // hook up udper
      HookUdper();

      // set up options updated event
      SetUpdateEvent();
    }

    /// <summary>
    ///   Hooks options inputs to the udper options.
    /// </summary>
    private void HookUdper() {
      // get udper
      var udper = Udper.Singleton;

      // set default input values
      nameBox.Text = udper.Name;
      destinationBox.Text = udper.Destination.ToString();
      fragmentBox.Value = udper.MaxFragment;
      errorCheckbox.Checked = udper.SendError;

      // hook up
      nameBox.TextChanged += (sender, args) => { udper.Name = nameBox.Text; };
      destinationBox.TextChanged += (sender, args) => { udper.SetDestination(destinationBox.Text); };
      fragmentBox.ValueChanged += (sender, args) => { udper.MaxFragment = fragmentBox.Value; };
      errorCheckbox.CheckedChanged += (sender, args) => { udper.SendError = errorCheckbox.Checked; };
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

    /// <summary>
    ///   Sets up a master event fired when any option changes.
    /// </summary>
    private void SetUpdateEvent() {
      EventHandler eventHandler = (sender, args) => { OptionsChanged?.Invoke(sender, args); };
      nameBox.TextChanged += eventHandler;
      destinationBox.TextChanged += eventHandler;
      fragmentBox.ValueChanged += eventHandler;
      errorCheckbox.CheckedChanged += eventHandler;
    }

    /// <summary>
    ///   Event fired when any option changes.
    /// </summary>
    public event EventHandler OptionsChanged;

  }

}
