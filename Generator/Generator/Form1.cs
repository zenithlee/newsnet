  using System;
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
  using System.IO;
  using System.Collections.ObjectModel;

namespace Generator
{
  public partial class Form1 : Form
  {
  string path = "../../Output/";
  string CurrentFile = "test";
    string CurrentProject;

  SpeechSynthesizer reader;
      List<string> items = new List<string>();
        
      string VoiceName = "";
      public Form1()
      {
      CurrentProject = path + CurrentFile;

          
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

      GetExistingProjects();

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
          Visemes.Text += s + "\r\n";
          items.Add(s); 
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
      textBox2.Text = "IDLE. Wrote to :" + CurrentProject;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      SaveProject();
    }
  }
  }
