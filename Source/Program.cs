using System;
using System.Windows.Forms;

namespace Udpit {

  internal static class Program {

    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main() {
      // start application
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(MainForm.Create());
    }

  }

}
