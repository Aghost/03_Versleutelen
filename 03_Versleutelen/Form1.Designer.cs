namespace _03_Versleutelen
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.btn_to = new System.Windows.Forms.Button();
            this.btn_from = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyBox = new System.Windows.Forms.CheckBox();
            this.extraBox = new System.Windows.Forms.CheckBox();
            this.rst_Btn = new System.Windows.Forms.Button();
            this.btn_revfrom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.AcceptsReturn = true;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(652, 244);
            this.textBox.TabIndex = 0;
            // 
            // btn_to
            // 
            this.btn_to.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_to.Location = new System.Drawing.Point(12, 284);
            this.btn_to.Name = "btn_to";
            this.btn_to.Size = new System.Drawing.Size(81, 65);
            this.btn_to.TabIndex = 2;
            this.btn_to.Text = "Encode";
            this.btn_to.UseVisualStyleBackColor = false;
            this.btn_to.Click += new System.EventHandler(this.btn_to_Click);
            // 
            // btn_from
            // 
            this.btn_from.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_from.Location = new System.Drawing.Point(595, 284);
            this.btn_from.Name = "btn_from";
            this.btn_from.Size = new System.Drawing.Size(69, 65);
            this.btn_from.TabIndex = 3;
            this.btn_from.Text = "Decode";
            this.btn_from.UseVisualStyleBackColor = false;
            this.btn_from.Click += new System.EventHandler(this.btn_from_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.keyTextBox.Location = new System.Drawing.Point(99, 285);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyTextBox.Size = new System.Drawing.Size(340, 64);
            this.keyTextBox.TabIndex = 4;
            // 
            // keyBox
            // 
            this.keyBox.AutoSize = true;
            this.keyBox.Checked = true;
            this.keyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.keyBox.Location = new System.Drawing.Point(99, 262);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(88, 17);
            this.keyBox.TabIndex = 5;
            this.keyBox.Text = "generate key";
            this.keyBox.UseVisualStyleBackColor = true;
            // 
            // extraBox
            // 
            this.extraBox.AutoSize = true;
            this.extraBox.Checked = true;
            this.extraBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.extraBox.Location = new System.Drawing.Point(333, 262);
            this.extraBox.Name = "extraBox";
            this.extraBox.Size = new System.Drawing.Size(106, 17);
            this.extraBox.TabIndex = 6;
            this.extraBox.Text = "show extra chars";
            this.extraBox.UseVisualStyleBackColor = true;
            // 
            // rst_Btn
            // 
            this.rst_Btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rst_Btn.Location = new System.Drawing.Point(445, 284);
            this.rst_Btn.Name = "rst_Btn";
            this.rst_Btn.Size = new System.Drawing.Size(69, 66);
            this.rst_Btn.TabIndex = 7;
            this.rst_Btn.Text = "Reset";
            this.rst_Btn.UseVisualStyleBackColor = false;
            this.rst_Btn.Click += new System.EventHandler(this.rst_Btn_Click);
            // 
            // btn_revfrom
            // 
            this.btn_revfrom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btn_revfrom.Location = new System.Drawing.Point(520, 284);
            this.btn_revfrom.Name = "btn_revfrom";
            this.btn_revfrom.Size = new System.Drawing.Size(69, 66);
            this.btn_revfrom.TabIndex = 8;
            this.btn_revfrom.Text = "Reverse Alphabet Cipher";
            this.btn_revfrom.UseVisualStyleBackColor = false;
            this.btn_revfrom.Click += new System.EventHandler(this.btn_revfrom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 359);
            this.Controls.Add(this.btn_revfrom);
            this.Controls.Add(this.rst_Btn);
            this.Controls.Add(this.extraBox);
            this.Controls.Add(this.keyBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.btn_from);
            this.Controls.Add(this.btn_to);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Septenary";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_to;
        private System.Windows.Forms.Button btn_from;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.CheckBox keyBox;
        private System.Windows.Forms.CheckBox extraBox;
        private System.Windows.Forms.Button rst_Btn;
        private System.Windows.Forms.Button btn_revfrom;
    }
}

