using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

public class FKeyHandle : IHandle {

    public void Handle () {
		Mouse.MoveTo (new System.Drawing.Point (360, 720));
        Mouse.Click (MouseButton.Left);
        Thread.Sleep (3000);
        Keyboard.Press (System.Windows.Input.Key.F4);
		Keyboard.Release (System.Windows.Input.Key.F4);
        Thread.Sleep (3000);
        Mouse.Click (MouseButton.Left);
		Mouse.MoveTo (new System.Drawing.Point (360, 720));
    }
}
