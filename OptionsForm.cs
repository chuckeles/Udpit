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

  }

}
