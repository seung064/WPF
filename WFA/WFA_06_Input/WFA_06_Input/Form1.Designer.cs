namespace WFA_06_Input
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
            this.button_input = new System.Windows.Forms.Button();
            this.radioButton_true = new System.Windows.Forms.RadioButton();
            this.radioButton_false = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // textBox_result
            // 
            this.textBox_result.AcceptsTab = true;
            this.textBox_result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox_result.Location = new System.Drawing.Point(60, 65);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.ReadOnly = true;
            this.textBox_result.Size = new System.Drawing.Size(507, 337);
            this.textBox_result.TabIndex = 0;
            // 
            // textBox_input
            // 
            this.textBox_input.Location = new System.Drawing.Point(60, 13);
            this.textBox_input.Name = "textBox_input";
            this.textBox_input.Size = new System.Drawing.Size(265, 21);
            this.textBox_input.TabIndex = 2;
            this.textBox_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_input
            // 
            this.button_input.Location = new System.Drawing.Point(456, 38);
            this.button_input.Name = "button_input";
            this.button_input.Size = new System.Drawing.Size(111, 24);
            this.button_input.TabIndex = 1;
            this.button_input.Text = "Input";
            this.button_input.UseVisualStyleBackColor = true;
            this.button_input.Click += new System.EventHandler(this.button_input_Click);
            this.button_input.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.button_input_QueryContinueDrag);
            // 
            // radioButton_true
            // 
            this.radioButton_true.AutoSize = true;
            this.radioButton_true.Location = new System.Drawing.Point(60, 40);
            this.radioButton_true.Name = "radioButton_true";
            this.radioButton_true.Size = new System.Drawing.Size(44, 16);
            this.radioButton_true.TabIndex = 3;
            this.radioButton_true.TabStop = true;
            this.radioButton_true.Text = "true";
            this.radioButton_true.UseVisualStyleBackColor = true;
            // 
            // radioButton_false
            // 
            this.radioButton_false.AutoSize = true;
            this.radioButton_false.Location = new System.Drawing.Point(158, 40);
            this.radioButton_false.Name = "radioButton_false";
            this.radioButton_false.Size = new System.Drawing.Size(50, 16);
            this.radioButton_false.TabIndex = 4;
            this.radioButton_false.TabStop = true;
            this.radioButton_false.Text = "false";
            this.radioButton_false.UseVisualStyleBackColor = true;
            this.radioButton_false.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_false);
            this.Controls.Add(this.radioButton_true);
            this.Controls.Add(this.textBox_input);
            this.Controls.Add(this.button_input);
            this.Controls.Add(this.textBox_result);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.TextBox textBox_input;
        private System.Windows.Forms.Button button_input;
        private System.Windows.Forms.RadioButton radioButton_true;
        private System.Windows.Forms.RadioButton radioButton_false;
    }
}



