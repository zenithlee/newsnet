using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

public class CDriver : MonoBehaviour {

  string sTitle = "Microsoft AI chatbot promptly becomes Nazi";
  public Text TitleText;
  public Text DebugText;

  public Text Headline;

  public GameObject StrapLine;
  public GameObject Intro;

  string BasePath = "../Output/";
  string RenderBasePath = "../Output/";
  public string CurrentFile = "test";
  string CurrentProject;
  int msPerFrame = 40;
  float BlinkTime = 2;
  int CurrentFrame = 0;

  public float SpeakStrength = 50;

  public int LipSyncTimeOffset = 500;

  float HeadTime = 1000;

  private bool alive = true;

  private string article;
  public Text Status;

  public AudioSource Audio;

  Dictionary<int, int> Heads = new Dictionary<int, int>(); //a mapping of SAPI viseme to MCS heads
  SortedDictionary<int, int> Sequence = new SortedDictionary<int, int>();

  public bool Alive
  {
    get
    {
      return alive;
    }

    set
    {
      alive = value;
    }
  }

  public string Article
  {
    get
    {
      return article;
    }

    set
    {
      article = value;
      CurrentFile = article;
    }
  }

  void print(string s)
  {
    if (Status != null)
    {
      Status.text = s;
    }
  }

  virtual public string MapHeadShape(int n)
  {
    return "";
  }

  virtual public void SetHeadFromSAPIID(int n,float v)
  {

  }

  public void LoadArticle()
  {
    CurrentProject = BasePath + CurrentFile + "/";
    print("loading " + CurrentProject);
    TitleText.text = File.ReadAllText(CurrentProject + "headline.txt");
    Headline.text = File.ReadAllText(CurrentProject + "headline.txt");
    GetPhonemesFromFile(CurrentProject + "sequence.txt");
    StartCoroutine(LoadAudio());
  }

  public void DoPreview()
  {
    print("speaking");   
    if ( Sequence.Count < 1 )
    {
      print("not loaded");
    } 
    BeginTalking();
  }

  IEnumerator LoadAudio()
  {
    string sPath = CurrentProject + "/audio.wav";
    FileInfo fi = new FileInfo(sPath);
    WWW www = new WWW("file://"+fi.FullName);
    yield return www;
    Audio.clip = www.audioClip;
    www.Dispose();
    print("loaded " + CurrentProject);

  }

  void BeginTalking()
  {
    Audio.Play();
    StopCoroutine(Preview());
    StartCoroutine(Preview());
    StrapLine.SetActive(true);
  }

  void HideIntro()
  {
    Intro.SetActive(false);
  }

  public void Render()
  {
    int TotalTime = Sequence.Last().Value;

    SetHeadFromSAPIID(99,0);
    CurrentFrame = 0;
    for ( int i=0; i< TotalTime; i+= msPerFrame)
    {

      if (Sequence.Count > 0)
      {
        SetHeadFromSAPIID(Sequence.First().Value, 100);
        Sequence.Remove(Sequence.First().Key);
        SaveFrame();
      }
    }

    SetHeadFromSAPIID(99,0);
  }

  IEnumerator Preview()
  {        
    System.Random n = new System.Random();

    SortedDictionary<int, int> TempSequence = new SortedDictionary<int,int>(Sequence);
    
    

    var stopwatch = new System.Diagnostics.Stopwatch();
    // Show object here
    stopwatch.Start();

    float start = stopwatch.ElapsedMilliseconds;
    //for ( int i=0; i< 40; i++) {
    int panic = 99;
    float previous = start;
    System.Random r = new System.Random();
    while ( Audio.isPlaying)
    {

      panic = 99;
      
      float time = stopwatch.ElapsedMilliseconds;
      if (TempSequence.Count < 1) break;
      int CurrentSeqTime = TempSequence.First().Key;

      BlinkTime -= time-previous;
      if ( BlinkTime < 0 )
      {
        StartCoroutine(Blink());
        BlinkTime = 1000 + r.Next(4000);
      }

      HeadTime -= time - previous;
      if ( HeadTime < 0 )
      {
        StartCoroutine(HeadMotion());
        HeadTime = 1000 + r.Next(2500);
      }

      CurrentFrame++;
      DebugText.text = "B:" + BlinkTime + " H:" + HeadTime + " F:" + CurrentFrame;

      while ( CurrentSeqTime <= time + LipSyncTimeOffset)
      {
        panic--;
        if (panic < 0) break;

        SetHeadFromSAPIID(99,0);
        SetHeadFromSAPIID(TempSequence.First().Value, SpeakStrength);
        DebugText.text += "  " + TempSequence.Count + "/" + Sequence.Count + " V:" + TempSequence.First().Key + ":" + TempSequence.First().Value;
        TempSequence.Remove(CurrentSeqTime);
        if (TempSequence.Count > 0)
        {
          CurrentSeqTime = TempSequence.First().Key;
        }
        else
        {
          SetHeadFromSAPIID(99,0);
          break;
        }
      }

      previous = time;

      yield return new WaitForSeconds(0.15f);
      //yield return new WaitForEndOfFrame();      
      //SaveFrame();
      //yield return new WaitForFixedUpdate();
    }

    print("done");

    //Intro.SetActive(true);
    //yield return new WaitForSeconds(3.15f);
    //CancelInvoke("SaveFrame");
  }

  void SaveFrame()
  {
    CurrentFrame++;
    Application.CaptureScreenshot(RenderBasePath + CurrentFile + "/frames/" + CurrentFrame + ".png");
  }

  public virtual IEnumerator Blink()
  {
    yield return false;
  }

  public virtual IEnumerator HeadMotion()
  {
    yield return false;
  }

  virtual public SortedDictionary<int, int> GetPhonemesFromFile(string path)
  {
    string CurrentFolder = Directory.GetCurrentDirectory();
    Debug.Log(CurrentFolder);
    string[] lines = File.ReadAllLines(path);
        
    foreach (string s in lines)
    {
      string[] pair = s.Split(' ');

      string part = pair[0];
      if (part == "W")
      {
        string CurrentWord = pair[1];
      }
      if (part == "V")
      {
        int ms = Convert.ToInt32(pair[1]);
        int head = Convert.ToInt32(pair[2]);
        if (!Sequence.ContainsKey(ms))
        {
          Sequence.Add(ms, head);
        }
        else
        {
          //TODO: combos come in at the same time. Handle them as multimorphs
          //Debug.Log("duplicate for " + ms);
        }
      }

    }

    return Sequence;
  }

  // Use this for initialization
  void Start () {
    Directory.CreateDirectory(RenderBasePath + CurrentFile);
    Directory.CreateDirectory(RenderBasePath + CurrentFile + "/frames/");    
  }
	
	// Update is called once per frame
	void Update () {
	
	}
}
