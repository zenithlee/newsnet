﻿using System;
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
        SpeechSynthesizer reader;

        List<string> items = new List<string>();
        string CurrentFile = "test";
        string path = "../../../../../bin/render/";

        string VoiceName = "david";
        public Form1()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            InitializeComponent();
            reader = new SpeechSynthesizer(); //create new object
            //System.Speech.AudioFormat.SpeechAudioFormatInfo info;            
            Directory.CreateDirectory(path + CurrentFile);
            reader.SetOutputToWaveFile(path + CurrentFile + "/audio.wav");
            reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
            reader.VisemeReached += new EventHandler<VisemeReachedEventArgs>(reader_VisemeReached);            
            reader.SpeakProgress += reader_SpeakProgress;


            ReadOnlyCollection<InstalledVoice> voices = reader.GetInstalledVoices();
            foreach (InstalledVoice voice in voices)
            {
                voicebox.Items.Add(voice.VoiceInfo.Name);
            }

            voicebox.SelectedValueChanged +=voicebox_SelectedValueChanged;
            voicebox.Text = voices[0].VoiceInfo.Name;
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
            reader = new SpeechSynthesizer(); //create new object
            reader.SelectVoice(VoiceName);
            string sText = textBox1.Text;
            reader.SpeakAsync(sText);
            textBox2.Text = "SPEAKING";
        }

        void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            textBox2.Text = "IDLE";
            File.WriteAllLines(path + CurrentFile + "/sequence.txt", items);
            File.WriteAllText(path + CurrentFile + "/input.txt", textBox1.Text);
            reader.Dispose();
        } 
    }
}
