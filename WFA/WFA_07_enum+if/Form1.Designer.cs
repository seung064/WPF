namespace WFA_07_enum_if
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.a = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.c = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(46, 69);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(54, 33);
            this.a.TabIndex = 0;
            this.a.Text = "가위";
            this.a.UseVisualStyleBackColor = true;
            this.a.Click += new System.EventHandler(this.a_Click);
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(46, 108);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(54, 33);
            this.b.TabIndex = 1;
            this.b.Text = "바위";
            this.b.UseVisualStyleBackColor = true;
            this.b.Click += new System.EventHandler(this.b_Click);
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(46, 147);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(54, 33);
            this.c.TabIndex = 2;
            this.c.Text = "보";
            this.c.UseVisualStyleBackColor = true;
            this.c.Click += new System.EventHandler(this.c_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(187, 69);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(232, 111);
            this.textBox_result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button a;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button c;
        private System.Windows.Forms.TextBox textBox_result;
    }
}

