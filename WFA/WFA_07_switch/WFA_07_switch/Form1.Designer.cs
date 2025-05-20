namespace WFA_07_switch
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
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.textBox_input = new System.Windows.Forms.TextBox();
            this.input_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(66, 106);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(510, 289);
            this.textBox_result.TabIndex = 2;
            this.textBox_result.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(66, 41);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(231, 21);
            this.textBox_input.TabIndex = 0;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // input_button
            // 
            this.input_button.Location = new System.Drawing.Point(501, 41);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(75, 23);
            this.input_button.TabIndex = 1;
            this.input_button.Text = "button1";
            this.input_button.UseVisualStyleBackColor = true;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.input_button);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.textBox_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button input_button;
    }
}

