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
      destinationBox.Text = udper.Destination;
      fragmentBox.Value = udper.MaxFragment;
      errorCheckbox.Checked = udper.SendError;

      // hook up
      nameBox.TextChanged += (sender, args) => { udper.Name = nameBox.Text; };
      destinationBox.TextChanged += (sender, args) => { udper.Destination = destinationBox.Text; };
      fragmentBox.ValueChanged += (sender, args) => { udper.MaxFragment = fragmentBox.Value; };
      errorCheckbox.CheckedChanged += (sender, args) => { udper.SendError = errorCheckbox.Checked; };
    }

    /// <summary>
    ///   Sets up a master event fired when any option changes.
    /// </summary>
    private void SetUpdateEvent() {
      nameBox.TextChanged += (sender, args) => { OptionsChanged?.Invoke(sender, args); };
      destinationBox.TextChanged += (sender, args) => { OptionsChanged?.Invoke(sender, args); };
      fragmentBox.ValueChanged += (sender, args) => { OptionsChanged?.Invoke(sender, args); };
      errorCheckbox.CheckedChanged += (sender, args) => { OptionsChanged?.Invoke(sender, args); };
    }

    /// <summary>
    ///   Event fired when any option changes.
    /// </summary>
    public event EventHandler OptionsChanged;

  }

}
