namespace Generator
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Visemes = new System.Windows.Forms.TextBox();
            this.voicebox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(557, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(335, 416);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Here are some of the basic operations. You can also change voice, volume , rate a" +
    "nd other parameters. You can also save the spoken audio stream directly into a \"" +
    "wave\" file.";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(26, 435);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(335, 20);
            this.textBox2.TabIndex = 2;
            // 
            // Visemes
            // 
            this.Visemes.Location = new System.Drawing.Point(367, 12);
            this.Visemes.Multiline = true;
            this.Visemes.Name = "Visemes";
            this.Visemes.Size = new System.Drawing.Size(184, 416);
            this.Visemes.TabIndex = 3;
            // 
            // voicebox
            // 
            this.voicebox.FormattingEnabled = true;
            this.voicebox.Location = new System.Drawing.Point(557, 12);
            this.voicebox.Name = "voicebox";
            this.voicebox.Size = new System.Drawing.Size(174, 21);
            this.voicebox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 471);
            this.Controls.Add(this.voicebox);
            this.Controls.Add(this.Visemes);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Visemes;
        private System.Windows.Forms.ComboBox voicebox;
    }
}

