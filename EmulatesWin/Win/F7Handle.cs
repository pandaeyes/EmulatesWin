using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Input;

public class F7Handle : IHandle {

    private int delay = 30;

    public F7Handle (int delay) {
        this.delay = delay;
    }

    public void Handle () {
        Thread.Sleep (30);
        Keyboard.Press (System.Windows.Input.Key.F7);
		Keyboard.Release (System.Windows.Input.Key.F7);
        Thread.Sleep (this.delay);
        Mouse.Click (MouseButton.Left);
        Thread.Sleep (30);
    }
}
