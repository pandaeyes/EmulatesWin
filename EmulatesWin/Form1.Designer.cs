using System;
namespace EmulatesWin {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioF5 = new System.Windows.Forms.RadioButton();
            this.radioF6 = new System.Windows.Forms.RadioButton();
            this.radioF7 = new System.Windows.Forms.RadioButton();
            this.radioF8 = new System.Windows.Forms.RadioButton();
            this.textf5 = new System.Windows.Forms.TextBox();
            this.textf6 = new System.Windows.Forms.TextBox();
            this.textf7 = new System.Windows.Forms.TextBox();
            this.textf8 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "停止";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUnregist_Click);
            // 
            // radioF5
            // 
            this.radioF5.AutoSize = true;
            this.radioF5.Location = new System.Drawing.Point(13, 60);
            this.radioF5.Name = "radioF5";
            this.radioF5.Size = new System.Drawing.Size(35, 16);
            this.radioF5.TabIndex = 2;
            this.radioF5.TabStop = true;
            this.radioF5.Text = "F5";
            this.radioF5.UseVisualStyleBackColor = true;
            this.radioF5.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioF6
            // 
            this.radioF6.AutoSize = true;
            this.radioF6.Location = new System.Drawing.Point(12, 100);
            this.radioF6.Name = "radioF6";
            this.radioF6.Size = new System.Drawing.Size(35, 16);
            this.radioF6.TabIndex = 3;
            this.radioF6.TabStop = true;
            this.radioF6.Text = "F6";
            this.radioF6.UseVisualStyleBackColor = true;
            this.radioF6.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioF7
            // 
            this.radioF7.AutoSize = true;
            this.radioF7.Location = new System.Drawing.Point(12, 142);
            this.radioF7.Name = "radioF7";
            this.radioF7.Size = new System.Drawing.Size(35, 16);
            this.radioF7.TabIndex = 4;
            this.radioF7.TabStop = true;
            this.radioF7.Text = "F7";
            this.radioF7.UseVisualStyleBackColor = true;
            this.radioF7.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioF8
            // 
            this.radioF8.AutoSize = true;
            this.radioF8.Location = new System.Drawing.Point(13, 185);
            this.radioF8.Name = "radioF8";
            this.radioF8.Size = new System.Drawing.Size(35, 16);
            this.radioF8.TabIndex = 5;
            this.radioF8.TabStop = true;
            this.radioF8.Text = "F8";
            this.radioF8.UseVisualStyleBackColor = true;
            this.radioF8.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // textf5
            // 
            this.textf5.Location = new System.Drawing.Point(54, 59);
            this.textf5.Name = "textf5";
            this.textf5.Size = new System.Drawing.Size(100, 21);
            this.textf5.TabIndex = 6;
            this.textf5.Text = "1000";
            // 
            // textf6
            // 
            this.textf6.Location = new System.Drawing.Point(54, 100);
            this.textf6.Name = "textf6";
            this.textf6.Size = new System.Drawing.Size(100, 21);
            this.textf6.TabIndex = 7;
            this.textf6.Text = "1000";
            // 
            // textf7
            // 
            this.textf7.Location = new System.Drawing.Point(54, 142);
            this.textf7.Name = "textf7";
            this.textf7.Size = new System.Drawing.Size(100, 21);
            this.textf7.TabIndex = 8;
            this.textf7.Text = "1000";
            // 
            // textf8
            // 
            this.textf8.Location = new System.Drawing.Point(55, 185);
            this.textf8.Name = "textf8";
            this.textf8.Size = new System.Drawing.Size(100, 21);
            this.textf8.TabIndex = 9;
            this.textf8.Text = "1000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textf8);
            this.Controls.Add(this.textf7);
            this.Controls.Add(this.textf6);
            this.Controls.Add(this.textf5);
            this.Controls.Add(this.radioF8);
            this.Controls.Add(this.radioF7);
            this.Controls.Add(this.radioF6);
            this.Controls.Add(this.radioF5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioF5;
        private System.Windows.Forms.RadioButton radioF6;
        private System.Windows.Forms.RadioButton radioF7;
        private System.Windows.Forms.RadioButton radioF8;
        private System.Windows.Forms.TextBox textf5;
        private System.Windows.Forms.TextBox textf6;
        private System.Windows.Forms.TextBox textf7;
        private System.Windows.Forms.TextBox textf8;
    }
}

