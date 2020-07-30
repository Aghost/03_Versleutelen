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
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(603, 266);
            this.textBox.TabIndex = 0;
            // 
            // btn_to
            // 
            this.btn_to.Location = new System.Drawing.Point(12, 284);
            this.btn_to.Name = "btn_to";
            this.btn_to.Size = new System.Drawing.Size(163, 63);
            this.btn_to.TabIndex = 2;
            this.btn_to.Text = "btn_to";
            this.btn_to.UseVisualStyleBackColor = true;
            this.btn_to.Click += new System.EventHandler(this.btn_to_Click);
            // 
            // btn_from
            // 
            this.btn_from.Location = new System.Drawing.Point(452, 284);
            this.btn_from.Name = "btn_from";
            this.btn_from.Size = new System.Drawing.Size(163, 63);
            this.btn_from.TabIndex = 3;
            this.btn_from.Text = "btn_from";
            this.btn_from.UseVisualStyleBackColor = true;
            this.btn_from.Click += new System.EventHandler(this.btn_from_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 359);
            this.Controls.Add(this.btn_from);
            this.Controls.Add(this.btn_to);
            this.Controls.Add(this.textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button btn_to;
        private System.Windows.Forms.Button btn_from;
    }
}

