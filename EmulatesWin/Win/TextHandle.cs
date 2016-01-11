using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

class TextHandle : IHandle {

    public void Handle () {
		// Mouse.MoveTo (new System.Drawing.Point (360, 720));
        // Mouse.Click (MouseButton.Left);
        // // Keyboard.Press (System.Windows.Input.Key.Enter);
		// // Keyboard.Release (System.Windows.Input.Key.Enter);
        // Keyboard.Press (System.Windows.Input.Key.A);
        // Keyboard.Release (System.Windows.Input.Key.A);
        // Thread.Sleep (30);
		// Keyboard.Type ("second=====CallBack========");
		// Mouse.MoveTo (new System.Drawing.Point (360, 720));

        Mouse.MoveTo (new System.Drawing.Point (360, 720));
        Mouse.Click (System.Windows.Input.MouseButton.Left);
        Keyboard.Press (System.Windows.Input.Key.A);
        Thread.Sleep (10000);
        Keyboard.Release (System.Windows.Input.Key.A);
        Mouse.MoveTo (new System.Drawing.Point (360, 720));
    }
}
