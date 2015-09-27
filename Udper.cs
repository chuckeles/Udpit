using System;

namespace Udpit {

  /// <summary>
  ///   The UDP messaging system.
  /// </summary>
  internal class Udper {

    public Udper() {
      // check singleton
      if (Singleton != null)
        return;

      // set singleton
      Singleton = this;

      // set up default options
      SetupOptions();
    }

    /// <summary>
    ///   Sets up default first-time options.
    /// </summary>
    private void SetupOptions() {
      // get the options form
      var optionsForm = MainForm.Singleton.OptionsForm;

      // set default name
      Name = "excited user";
      optionsForm.NameBox.Text = Name;

      // hook up the name input
      optionsForm.NameBox.TextChanged += (sender, args) => { Name = optionsForm.NameBox.Text; };

      // set default destination
      Destination = "localhost";
      optionsForm.DestinationBox.Text = Destination;

      // hook up the destination input
      optionsForm.DestinationBox.TextChanged += (sender, args) => { Destination = optionsForm.DestinationBox.Text; };

      // set default fragment
      MaxFragment = 128;
      optionsForm.FragmentBox.Text = MaxFragment.ToString();

      // hook up the name input
      optionsForm.FragmentBox.TextChanged +=
        (sender, args) => { MaxFragment = Convert.ToInt32(optionsForm.FragmentBox.Text); };

      // set default error
      SendError = false;
      optionsForm.ErrorCheckbox.Checked = SendError;

      // hook up the name input
      optionsForm.ErrorCheckbox.CheckedChanged += (sender, args) => { SendError = optionsForm.ErrorCheckbox.Checked; };
    }

    /// <summary>
    ///   The udper singleton.
    /// </summary>
    public static Udper Singleton { get; private set; }

    /// <summary>
    ///   The destination url.
    /// </summary>
    public string Destination;

    /// <summary>
    ///   Maximum fragment size.
    /// </summary>
    public int MaxFragment;

    /// <summary>
    ///   The user's name.
    /// </summary>
    public string Name;

    /// <summary>
    ///   Whether to send error fragments for testing purposes.
    /// </summary>
    public bool SendError;

  }

}
