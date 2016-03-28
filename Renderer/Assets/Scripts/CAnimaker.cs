using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

public class CAnimaker : MonoBehaviour {

  //phoneme list file format
  //ms phoneme
  //ms phoneme
  //5010 ah

  /**
  * phoneme layout
  * AH - 1
  * OH - 2
  * EH - 3
  * OO - 4
  * SH - 5
  * T - 6
  * M - 7
  * L - 8
  * F - 9
  */

  public Sprite[] HeadSprites;

    Dictionary<int, int> Heads = new Dictionary<int, int>(); //a mapping of SAPI viseme to Disney heads
    SortedDictionary<int, string> Sequence = new SortedDictionary<int, string>();
    SortedDictionary<int, int> Rendered = new SortedDictionary<int, int>();
    string BasePath = "../Bin/Render/";
    string RenderBasePath = "../Bin/Render/";
    string CurrentFile = "test";
    int msPerFrame = 40;

  public SpriteRenderer head;

    public Text RenderText;

    public void Test()
    {
    string sPath = BasePath + CurrentFile + "/";
        Generate(sPath + "audio.wav", sPath + "sequence.txt");
        Directory.CreateDirectory(RenderBasePath + CurrentFile);
    Directory.CreateDirectory(RenderBasePath + CurrentFile + "/frames/");
    StartCoroutine(SaveRender());
    }

    public IEnumerator SaveRender()
    {
        StringBuilder op = new StringBuilder();
        int n = 0;
        foreach( KeyValuePair<int,int> p in Rendered)
        {
            n++;
      if ( p.Value > HeadSprites.Count())
      {
        Debug.Log(p.Key + ":" + p.Value);
      }
      Debug.Log(p.Key + ":" + p.Value);
      head.sprite = HeadSprites[p.Value-1]; //0 based
      yield return new WaitForEndOfFrame();
      try {
        string s = p.Key + ":" + p.Value;
        op.Append(s + "\n");
        RenderText.text = s;
        
        //Application.CaptureScreenshot(RenderBasePath + CurrentFile + "/frames/" + n + ".png");
      } catch( Exception e)
      {
        e=e;
        n--; //try again
      }
        };
        File.WriteAllText(RenderBasePath + CurrentFile +"/rendered.txt", op.ToString());
      
    }

    public void Generate(string PathToAudio, string PathToPhonemes)
    {
        GetPhonemesFromFile(PathToPhonemes);
        int len = GetLengthOfSet();
        //add 1 second
        len += 1000;

        int currentPhone = 7;

        for ( int n=0; n < len; n+= msPerFrame)
        {
            int time = Sequence.Keys.First<int>();
            if ( time < n )
            {
        // Debug.Log("Generating for:" + Sequence.Values.First<string>());
        string val = Sequence.Values.First<string>();
        int viseme = Convert.ToInt32(val);
                currentPhone = GetHeadForPhoneme(viseme);
                Sequence.Remove(Sequence.First().Key);
                if (Sequence.Count == 0) break;
            }

           // Debug.Log(n + ":" + time + " : " + currentPhone);
      if (!Rendered.ContainsKey(n))
      {
        Rendered.Add(n, currentPhone);
      }
        }

        Debug.Log("done " + len);
    }

    public int GetLengthOfSet()
    {
        int item = Sequence.Keys.Last<int>();
        return item;
    }

    public SortedDictionary<int,string> GetPhonemesFromFile(string path)
    {
        string CurrentFolder = Directory.GetCurrentDirectory();
        Debug.Log(CurrentFolder);
        string[] lines = File.ReadAllLines(path);
        int n = 0;
        string timeformat = "ms";
        string phoneformat = "phoneme";
        string version = "1.0";
        foreach( string s in lines)
        {            
            string[] pair = s.Split(' ');

      string part = pair[0];
      if ( part == "W")
      {
        string CurrentWord = pair[1];
      }
      if ( part == "V")
      {
        int ms = Convert.ToInt32(pair[1]);
        if (!Sequence.ContainsKey(ms))
        {
          Sequence.Add(ms, pair[2]);
        }
        else
        {
          Debug.Log("duplicate for " + ms);
        }
      }
            
        }

        return Sequence; 
    }

    public int GetHeadForPhoneme(int phoneme)
    {
      if (!Heads.ContainsKey(phoneme))
    {
      Debug.Log("No head for " + phoneme);
      return 7;
    }
        return Heads[phoneme];
    }

  /**
        * phoneme layout
        * AH - 1
        * OH - 2
        * EH - 3
        * OO - 4
        * SH - 5
        * T - 6
        * M - 7
        * L - 8
        * F - 9
        */
  void Awake()
    {
    Heads.Add(0, 7);
    Heads.Add(1, 1);
    Heads.Add(2, 1);
    Heads.Add(3, 2);
    Heads.Add(4,  3);
    Heads.Add(5, 3);
    Heads.Add(6, 5);
    Heads.Add(7, 4);
    Heads.Add(8, 4);
    Heads.Add(9, 1);
    Heads.Add(10, 2);
    Heads.Add(11, 1);    
    Heads.Add(12, 6);
    Heads.Add(13, 8);
    Heads.Add(14, 8);
    Heads.Add(15, 5);
    Heads.Add(16, 5);
    Heads.Add(17, 6);
    Heads.Add(18, 9);
    Heads.Add(19, 6);
    Heads.Add(20, 6);
    Heads.Add(21, 7);    
  }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
