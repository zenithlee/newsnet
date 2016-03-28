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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.button1 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.Visemes = new System.Windows.Forms.TextBox();
      this.voicebox = new System.Windows.Forms.ComboBox();
      this.checkBox1 = new System.Windows.Forms.CheckBox();
      this.button2 = new System.Windows.Forms.Button();
      this.ProjectNames = new System.Windows.Forms.ComboBox();
      this.Headline = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.trackBar1 = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button1.Location = new System.Drawing.Point(741, 389);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(141, 38);
      this.button1.TabIndex = 0;
      this.button1.Text = "Generate";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(26, 129);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(335, 299);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "Here are some of the basic operations. You can also change voice, volume , rate a" +
    "nd other parameters. You can also save the spoken audio stream directly into a \"" +
    "wave\" file.";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(26, 482);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(335, 20);
      this.textBox2.TabIndex = 2;
      // 
      // Visemes
      // 
      this.Visemes.Location = new System.Drawing.Point(367, 129);
      this.Visemes.Multiline = true;
      this.Visemes.Name = "Visemes";
      this.Visemes.Size = new System.Drawing.Size(368, 299);
      this.Visemes.TabIndex = 3;
      // 
      // voicebox
      // 
      this.voicebox.FormattingEnabled = true;
      this.voicebox.Location = new System.Drawing.Point(741, 11);
      this.voicebox.Name = "voicebox";
      this.voicebox.Size = new System.Drawing.Size(174, 21);
      this.voicebox.TabIndex = 4;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(745, 366);
      this.checkBox1.Name = "checkBox1";
      this.checkBox1.Size = new System.Drawing.Size(86, 17);
      this.checkBox1.TabIndex = 5;
      this.checkBox1.Text = "Save To File";
      this.checkBox1.UseVisualStyleBackColor = true;
      this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Brown;
      this.button2.Location = new System.Drawing.Point(741, 127);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(141, 38);
      this.button2.TabIndex = 6;
      this.button2.Text = "STOP";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // ProjectNames
      // 
      this.ProjectNames.FormattingEnabled = true;
      this.ProjectNames.Location = new System.Drawing.Point(29, 35);
      this.ProjectNames.Name = "ProjectNames";
      this.ProjectNames.Size = new System.Drawing.Size(335, 21);
      this.ProjectNames.TabIndex = 7;
      // 
      // Headline
      // 
      this.Headline.Location = new System.Drawing.Point(26, 76);
      this.Headline.Name = "Headline";
      this.Headline.Size = new System.Drawing.Size(335, 20);
      this.Headline.TabIndex = 8;
      this.Headline.Text = "And now the news";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(26, 59);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Headline";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(26, 108);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "Text";
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(741, 76);
      this.trackBar1.Maximum = 100;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(174, 45);
      this.trackBar1.TabIndex = 11;
      this.trackBar1.Value = 50;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(742, 59);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Pitch";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(26, 19);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Project";
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.SandyBrown;
      this.button3.Location = new System.Drawing.Point(741, 443);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(141, 38);
      this.button3.TabIndex = 14;
      this.button3.Text = "Save";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
      this.pictureBox1.Location = new System.Drawing.Point(371, 19);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(101, 102);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
      this.pictureBox1.TabIndex = 15;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Visible = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(932, 514);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Headline);
      this.Controls.Add(this.ProjectNames);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.voicebox);
      this.Controls.Add(this.Visemes);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox Visemes;
        private System.Windows.Forms.ComboBox voicebox;
    private System.Windows.Forms.CheckBox checkBox1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ComboBox ProjectNames;
    private System.Windows.Forms.TextBox Headline;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar trackBar1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

