﻿  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Data;
  using System.Drawing;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Forms;

  using System.Speech;
  using System.Speech.Synthesis;
  using System.Speech.Synthesis.TtsEngine;
  using System.IO;
  using System.Collections.ObjectModel;

  namespace Generator
  {
  public partial class Analysis : Form
  {
  string path = "../Output/";
  string CurrentFile = "test";
  string CurrentProject;
  string SentimentFile = "../Data/sentiments.csv";
  Dictionary<string, float> Sentiments = new Dictionary<string, float>();

  SpeechSynthesizer reader;
  List<string> items = new List<string>();
  List<string> missing = new List<string>();
   public BindingSource source = new BindingSource();
  
        
  string VoiceName = "";
  public Analysis()
  {
      CurrentProject = path + CurrentFile;
      source.DataSource = Sentiments;
      
      Directory.CreateDirectory(CurrentProject);
          
      Console.WriteLine(Directory.GetCurrentDirectory());

      InitializeComponent();      

      SetupReader();
           
      ReadOnlyCollection<InstalledVoice> voices = reader.GetInstalledVoices();
      foreach (InstalledVoice voice in voices)
      {
          voicebox.Items.Add(voice.VoiceInfo.Name);
      }

      voicebox.SelectedValueChanged +=voicebox_SelectedValueChanged;
      voicebox.Text = voices[0].VoiceInfo.Name;
      LoadSentiments();
      var SentiData = from row in Sentiments select new { word = row.Key, sentiment = row.Value };
      SentimentGrid.DataSource = SentiData.ToArray();

      GetExistingProjects();
      Application.EnableVisualStyles();

    }

  void LoadSentiments()
  {
      string[] items = File.ReadAllLines(SentimentFile);
      foreach( string item in items)
      {
          string[] pair = item.Split(';');
          string sword = pair[0];
          float value = (float)Convert.ToDouble(pair[1]);
              if ( !Sentiments.ContainsKey(sword)) { 
                  Sentiments.Add(sword, value);
              }
          }
  }

  void GetExistingProjects()
  {

      DirectoryInfo di = new DirectoryInfo(path);
      DirectoryInfo[] dirs = di.GetDirectories();      
      foreach( DirectoryInfo dir in dirs)
      {
        ProjectNames.Items.Add(dir.Name);
      }

      ProjectNames.TextChanged += ProjectNames_TextChanged;
      ProjectNames.SelectedIndexChanged += ProjectNames_SelectedIndexChanged;
  }

  private void ProjectNames_SelectedIndexChanged(object sender, EventArgs e)
  {
      CurrentProject = path + ProjectNames.Text;
      checkBox1.Checked = false;
      LoadProject();
  }

  private void ProjectNames_TextChanged(object sender, EventArgs e)
  {
      CurrentProject = path + ProjectNames.Text;
      checkBox1.Checked = false;
      LoadProject();
  }

  void LoadProject()
  {
      if (File.Exists(CurrentProject + "/input.txt"))
      {
      textBox1.Text = File.ReadAllText(CurrentProject + "/input.txt");
      }
      if (File.Exists(CurrentProject + "/headline.txt"))
      {
      Headline.Text = File.ReadAllText(CurrentProject + "/headline.txt");
      }
  }

  void SetupReader()
  {
      reader = new SpeechSynthesizer(); //create new object
                  //reader.SetOutputToWaveFile(path + CurrentFile + "/audio.wav");                                              
      reader.VoiceChange += Reader_VoiceChange;
      reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
      reader.VisemeReached += new EventHandler<VisemeReachedEventArgs>(reader_VisemeReached);
      reader.SpeakProgress += reader_SpeakProgress;
      VoiceName = reader.Voice.Name;
      if ( VoiceName != "" ) {
        reader.SelectVoice(VoiceName);
      }
      
    }

  private void Reader_VoiceChange(object sender, VoiceChangeEventArgs e)
  {
      string s = "S " + e.Voice.Name + "," + e.Voice.Gender + "," + e.Voice.Age + "," + e.Voice.Culture + "," + e.Voice.Description;
      Visemes.Text += s + "\r\n";
      items.Add(s);
  }

  void reader_SpeakProgress(object sender, SpeakProgressEventArgs e)
  {
      string s = "W " + e.Text;
      string slower = e.Text.ToLower();
      float sentiment = 0f;
      if (Sentiments.ContainsKey(slower))
      {
          sentiment = Sentiments[slower];
      }
      else
      {
        sentiment = -1;
        if (!missing.Contains(slower))
        {
            missing.Add(slower);
            report.Text += slower + "\r\n";
        }            
      }
      Visemes.Text += s + " " + sentiment + "\r\n";
      items.Add(s + " " + sentiment); 
  }

  private void voicebox_SelectedValueChanged(object sender, EventArgs e)
  {
      VoiceName = voicebox.Text;
      reader.SelectVoice(VoiceName);
  }

  private void reader_VisemeReached(object sender, VisemeReachedEventArgs e)
  {
      string s = "V " + Math.Round(e.AudioPosition.TotalMilliseconds) + " " + e.Viseme.ToString();
      Visemes.Text += s + "\r\n";
      items.Add(s);
      //Console.WriteLine(e.Viseme);
  }

  private void button1_Click(object sender, EventArgs e)
  {
      Directory.CreateDirectory(CurrentProject);
      string sText = textBox1.Text;
      items.Clear();
      Visemes.Clear();
      missing.Clear();
      report.Clear();

      items.Add("H " + Headline.Text);
      Visemes.Text += "H " + Headline.Text + "\r\n";
      if (checkBox1.Checked)
      {
          reader.SetOutputToWaveFile(CurrentProject+ "/audio.wav");
      }
      else
      {
          reader.SetOutputToDefaultAudioDevice();
      }

      
      reader.SpeakAsync(sText);            

      textBox2.Text = "SPEAKING";
  }

  void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
  {
      textBox2.Text = "IDLE.";
      SaveProject();
      textBox2.Text = "SAVED.";
  } 

  private void checkBox1_CheckedChanged(object sender, EventArgs e)
  {
    
  }

  private void button2_Click(object sender, EventArgs e)
  {
      reader.Pause();
      reader.Dispose();
      SetupReader();
  }

  void SaveProject()
  {      
      CurrentProject = path + ProjectNames.Text;
      Directory.CreateDirectory(CurrentProject);
      File.WriteAllLines(CurrentProject + "/sequence.txt", items);
      File.WriteAllText(CurrentProject + "/input.txt", textBox1.Text);
      File.WriteAllText(CurrentProject + "/headline.txt", Headline.Text);
      File.WriteAllLines(CurrentProject + "/missing.txt", missing.ToArray());
      textBox2.Text = "IDLE. Wrote to :" + CurrentProject;
  }

  private void button3_Click(object sender, EventArgs e)
  {
      SaveProject();
  }

  private void pictureBox1_Click(object sender, EventArgs e)
  {

  }
      private void LoadButton_Click(object sender, EventArgs e)
      {
          FileInfo fi = new FileInfo(path);
          openFileDialog1.InitialDirectory = fi.FullName;
          DialogResult result = openFileDialog1.ShowDialog();
      }

      private void trackBar1_Scroll(object sender, EventArgs e)
      {
        
      }

    private void SentimentGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      SentimentGrid.CurrentCell.ReadOnly = false;
      SentimentGrid.BeginEdit(false); 
    }
    
    private void RefreshButton_Click(object sender, EventArgs e)
    {
      var SentiData = from row in Sentiments select new { word = row.Key, sentiment = row.Value };
      SentimentGrid.DataSource = SentiData.ToArray();
    }

    private void SentimentGrid_Validated(object sender, EventArgs e)
    {
      var SentiData = from row in Sentiments select new { word = row.Key, sentiment = row.Value };
      SentimentGrid.DataSource = SentiData.ToArray();
    }

    void PopulateControl()
    {
      var SentiData = from row in Sentiments select new { word = row.Key, sentiment = row.Value };
      SentimentGrid.DataSource = SentiData.ToArray();
    }

    private void SentimentGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
    {
      if (e.ColumnIndex == 1)
      {
        Sentiments[SentimentGrid[0, SentimentGrid.CurrentRow.Index].Value.ToString()] = (float)Convert.ToDouble(e.FormattedValue);        
        BeginInvoke(new MethodInvoker(PopulateControl));
      }
    }

    private void Test_Click(object sender, EventArgs e)
    {
      //SpeechSynthesizer synth = new SpeechSynthesizer();
      PromptBuilder pb = new PromptBuilder();      
      pb.AppendSsmlMarkup("<voice xml:lang=\"en-US\">");

      pb.StartVoice(VoiceName);      
      pb.AppendText("Hello, how are you today?");
      
      string high = "This is Normal pitch <prosody pitch=\"+20\"> This is Normal pitch. </prosody>";
      string low = "<prosody pitch=\"-10\">This is extra low pitch. </prosody>";
      pb.AppendSsmlMarkup(high);
      pb.AppendSsmlMarkup(low);
      string test= "This is extra <prosody pitch=\"-10\">extra</prosody> low pitch. ";
      pb.AppendSsmlMarkup(test);
      pb.EndVoice();
      pb.AppendSsmlMarkup("</voice>");
      
      
      reader.Speak(pb);
    }
  }
  }
