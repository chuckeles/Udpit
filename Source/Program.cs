﻿using System;
using System.Windows.Forms;

namespace Udpit {

  internal static class Program {

    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    private static void Main() {
      // create the singletons
      Receiver.Create();
      Sender.Create();
      MessageCenter.Create();

      // start application
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

  }

}
