﻿namespace Generator
{
    partial class Analysis
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
      this.components = new System.ComponentModel.Container();
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
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.LoadButton = new System.Windows.Forms.Button();
      this.report = new System.Windows.Forms.TextBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.RefreshButton = new System.Windows.Forms.Button();
      this.SentimentGrid = new System.Windows.Forms.DataGridView();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.analysisBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.Test = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.tabControl1.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.SentimentGrid)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.button1.Location = new System.Drawing.Point(749, 294);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(141, 38);
      this.button1.TabIndex = 0;
      this.button1.Text = "Generate";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(6, 113);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(335, 331);
      this.textBox1.TabIndex = 1;
      this.textBox1.Text = "Good. Here are some of the basic operations. You can also change voice, volume , " +
    "rate and other parameters. You can also save the spoken audio stream directly in" +
    "to a \"wave\" file.";
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(7, 450);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(709, 20);
      this.textBox2.TabIndex = 2;
      // 
      // Visemes
      // 
      this.Visemes.Location = new System.Drawing.Point(355, 113);
      this.Visemes.Multiline = true;
      this.Visemes.Name = "Visemes";
      this.Visemes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.Visemes.Size = new System.Drawing.Size(182, 331);
      this.Visemes.TabIndex = 3;
      // 
      // voicebox
      // 
      this.voicebox.FormattingEnabled = true;
      this.voicebox.Location = new System.Drawing.Point(745, 35);
      this.voicebox.Name = "voicebox";
      this.voicebox.Size = new System.Drawing.Size(174, 21);
      this.voicebox.TabIndex = 4;
      // 
      // checkBox1
      // 
      this.checkBox1.AutoSize = true;
      this.checkBox1.Location = new System.Drawing.Point(749, 271);
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
      this.button2.Location = new System.Drawing.Point(749, 191);
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
      this.ProjectNames.Location = new System.Drawing.Point(9, 19);
      this.ProjectNames.Name = "ProjectNames";
      this.ProjectNames.Size = new System.Drawing.Size(335, 21);
      this.ProjectNames.TabIndex = 7;
      // 
      // Headline
      // 
      this.Headline.Location = new System.Drawing.Point(6, 60);
      this.Headline.Name = "Headline";
      this.Headline.Size = new System.Drawing.Size(335, 20);
      this.Headline.TabIndex = 8;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 43);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(49, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Headline";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 92);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(28, 13);
      this.label2.TabIndex = 10;
      this.label2.Text = "Text";
      // 
      // trackBar1
      // 
      this.trackBar1.Location = new System.Drawing.Point(745, 97);
      this.trackBar1.Maximum = 100;
      this.trackBar1.Name = "trackBar1";
      this.trackBar1.Size = new System.Drawing.Size(174, 45);
      this.trackBar1.TabIndex = 11;
      this.trackBar1.Value = 50;
      this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(746, 78);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(31, 13);
      this.label3.TabIndex = 12;
      this.label3.Text = "Pitch";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Project";
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.SandyBrown;
      this.button3.Location = new System.Drawing.Point(749, 338);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(141, 38);
      this.button3.TabIndex = 14;
      this.button3.Text = "Save";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBox1.InitialImage = null;
      this.pictureBox1.Location = new System.Drawing.Point(355, 5);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(101, 102);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 15;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Visible = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Location = new System.Drawing.Point(12, 13);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(727, 551);
      this.tabControl1.TabIndex = 16;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.LoadButton);
      this.tabPage1.Controls.Add(this.report);
      this.tabPage1.Controls.Add(this.label4);
      this.tabPage1.Controls.Add(this.pictureBox1);
      this.tabPage1.Controls.Add(this.textBox1);
      this.tabPage1.Controls.Add(this.ProjectNames);
      this.tabPage1.Controls.Add(this.Headline);
      this.tabPage1.Controls.Add(this.label1);
      this.tabPage1.Controls.Add(this.label2);
      this.tabPage1.Controls.Add(this.textBox2);
      this.tabPage1.Controls.Add(this.Visemes);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(719, 525);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Text";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // LoadButton
      // 
      this.LoadButton.Location = new System.Drawing.Point(463, 7);
      this.LoadButton.Name = "LoadButton";
      this.LoadButton.Size = new System.Drawing.Size(75, 23);
      this.LoadButton.TabIndex = 17;
      this.LoadButton.Text = "Load...";
      this.LoadButton.UseVisualStyleBackColor = true;
      this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
      // 
      // report
      // 
      this.report.Location = new System.Drawing.Point(543, 3);
      this.report.Multiline = true;
      this.report.Name = "report";
      this.report.Size = new System.Drawing.Size(170, 441);
      this.report.TabIndex = 16;
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.RefreshButton);
      this.tabPage2.Controls.Add(this.SentimentGrid);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(719, 525);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Sentiment";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // RefreshButton
      // 
      this.RefreshButton.Location = new System.Drawing.Point(608, 7);
      this.RefreshButton.Name = "RefreshButton";
      this.RefreshButton.Size = new System.Drawing.Size(105, 23);
      this.RefreshButton.TabIndex = 1;
      this.RefreshButton.Text = "Refresh";
      this.RefreshButton.UseVisualStyleBackColor = true;
      this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
      // 
      // SentimentGrid
      // 
      this.SentimentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.SentimentGrid.Location = new System.Drawing.Point(3, 4);
      this.SentimentGrid.Name = "SentimentGrid";
      this.SentimentGrid.Size = new System.Drawing.Size(598, 515);
      this.SentimentGrid.TabIndex = 0;
      this.SentimentGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SentimentGrid_CellDoubleClick);
      this.SentimentGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SentimentGrid_CellValidating);
      this.SentimentGrid.Validated += new System.EventHandler(this.SentimentGrid_Validated);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // analysisBindingSource
      // 
      this.analysisBindingSource.DataSource = typeof(Generator.Analysis);
      // 
      // Test
      // 
      this.Test.Location = new System.Drawing.Point(749, 146);
      this.Test.Name = "Test";
      this.Test.Size = new System.Drawing.Size(75, 23);
      this.Test.TabIndex = 17;
      this.Test.Text = "TestButton";
      this.Test.UseVisualStyleBackColor = true;
      this.Test.Click += new System.EventHandler(this.Test_Click);
      // 
      // Analysis
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(944, 568);
      this.Controls.Add(this.Test);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.trackBar1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.checkBox1);
      this.Controls.Add(this.voicebox);
      this.Controls.Add(this.button1);
      this.Name = "Analysis";
      this.Text = "Analysis";
      ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.tabControl1.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.SentimentGrid)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.analysisBindingSource)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox report;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView SentimentGrid;
    private System.Windows.Forms.BindingSource analysisBindingSource;
    private System.Windows.Forms.Button RefreshButton;
    private System.Windows.Forms.Button Test;
  }
}

