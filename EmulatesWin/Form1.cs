using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace EmulatesWin {
    public partial class Form1 : Form {
        private HotKeys h = new HotKeys ();
        private Thread handleThread = null;
        private Queue<IHandle> handleQueue = new Queue<IHandle> ();

        private IHandle runHandle = null;
        private TextBox selectTextBox = null;
        private int curIdx = 5;

        bool isRunning = false;
        int timeDelay = 1000;

        public void AddHandle (IHandle handle) {
            handleQueue.Enqueue (handle);
        }

        public Form1 () {
            InitializeComponent ();
            handleThread = new Thread (new ThreadStart (DoCmd));
            handleThread.IsBackground = true;
            handleThread.Start ();
        }

        private void btnRegist_Click (object sender, EventArgs e) {
            //这里注册了Ctrl+Alt+E 快捷键
            h.Regist (this.Handle, (int)HotKeys.HotkeyModifiers.Alt, Keys.Q, CallBack);
            // MessageBox.Show ("注册成功");
        }

        private void btnUnregist_Click (object sender, EventArgs e) {
            h.UnRegist (this.Handle, CallBack);
            // MessageBox.Show ("卸载成功");
        }

        protected override void WndProc (ref Message m) {
            //窗口消息处理函数
            h.ProcessHotKey (m);
            base.WndProc (ref m);
        }

        //按下快捷键时被调用的方法
        public void CallBack () {
            // Keyboard.Press (System.Windows.Input.Key.Enter);
            // Keyboard.Release (System.Windows.Input.Key.Enter);
            // Keyboard.Type ("second=====CallBack========");
            // Mouse.MoveTo (new System.Drawing.Point (360, 720));
            // Keyboard.Press (System.Windows.Input.Key.Enter);
            // Keyboard.Release (System.Windows.Input.Key.Enter);
            // MessageBox.Show ("快捷键被调用！");
            // Console.WriteLine ("==========CallBack======================");

            // AddHandle (new TextHandle ());
            // AddHandle (new FKeyHandle());
            if (!isRunning) {
                SetTime (this.selectTextBox);
                if (this.curIdx == 5) {
                    runHandle = new F5Handle(this.timeDelay);
                } else if (this.curIdx == 6) {
                    runHandle = new F6Handle(this.timeDelay);
                } else if (this.curIdx == 7) {
                    runHandle = new F7Handle(this.timeDelay);
                } else if (this.curIdx == 8) {
                    runHandle = new F8Handle(this.timeDelay);
                }
                isRunning = true;
            } else {
                isRunning = false;
                runHandle = null;
            }
        }

        private void DoCmd () {
            do {
                // if (handleQueue.Count > 0) {
                //     IHandle handle = handleQueue.Dequeue ();
                //     handle.Handle ();
                // }
                if (isRunning && runHandle != null) {
                    runHandle.Handle ();
                }
                Thread.Sleep (30);
            } while (true);
        }

        private void radio_CheckedChanged (int selectIdx) {
            this.curIdx = selectIdx;
        }

        private void radio_CheckedChanged (object sender, EventArgs e) {
            if (sender == this.radioF5) {
                this.curIdx = 5;
                this.selectTextBox = this.textf5;
                SetTime (this.textf5);
            } else if (sender == this.radioF6) {
                this.curIdx = 6;
                this.selectTextBox = this.textf6;
                SetTime (this.textf6);
            } else if (sender == this.radioF7) {
                this.curIdx = 7;
                this.selectTextBox = this.textf7;
                SetTime (this.textf7);
            } else if (sender == this.radioF8) {
                this.curIdx = 8;
                this.selectTextBox = this.textf8;
                SetTime (this.textf8);
            }
        }

        private void SetTime (TextBox textBox) {
            if (textBox == null) {
                return;
            }
            string time = textBox.Text;
            if (time.Trim ().Length > 0) {
                this.timeDelay = Convert.ToInt32 (time.Trim ());
            }
        }
    }
}
