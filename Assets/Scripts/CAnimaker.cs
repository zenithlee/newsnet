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

    Dictionary<string, int> Heads = new Dictionary<string, int>();
    SortedDictionary<int, string> Sequence = new SortedDictionary<int, string>();
    SortedDictionary<int, int> Rendered = new SortedDictionary<int, int>();
    string BasePath = "Bin/Data/";
    string RenderBasePath = "Bin/Render/";
    string CurrentFile = "test";
    int msPerFrame = 40;

    public Text RenderText;

    public void Test()
    {
        Generate(BasePath + "test.wav", BasePath + "test.txt");
        Directory.CreateDirectory(RenderBasePath + CurrentFile);
       StartCoroutine(SaveRender());
    }

    public IEnumerator SaveRender()
    {
        StringBuilder op = new StringBuilder();
        int n = 0;
        foreach( KeyValuePair<int,int> p in Rendered)
        {
            n++;
            string s = p.Key + ":" + p.Value;
            op.Append(s + "\n");
            RenderText.text =s;
           yield return new WaitForEndOfFrame();
            Application.CaptureScreenshot(RenderBasePath + CurrentFile + "/"+ n+ ".png");
        };
        File.WriteAllText(RenderBasePath + CurrentFile +".txt", op.ToString());
      
    }

    public void Generate(string PathToAudio, string PathToPhonemes)
    {
        GetPhonemesFromFile(PathToPhonemes);
        int len = GetLengthOfSet();
        //add 1 second
        len += 1000;

        int currentPhone = 0;

        for ( int n=0; n < len; n+= msPerFrame)
        {
            int time = Sequence.Keys.First<int>();
            if ( time < n )
            {
                Debug.Log("Generating for:" + Sequence.Values.First<string>());
                currentPhone = GetHeadForPhoneme(Sequence.Values.First<string>());
                Sequence.Remove(Sequence.First().Key);
                if (Sequence.Count == 0) break;
            }

            Debug.Log(n + ":" + time + " : " + currentPhone);
            Rendered.Add(n, currentPhone);
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
            if (n == 0) {
                timeformat = pair[0];
                phoneformat = pair[1];
                version = pair[2];
                n++;
                continue;
            }

            int ms = Convert.ToInt32(pair[0]);
            Sequence.Add(ms, pair[1]);
        }

        return Sequence; 
    }

    public int GetHeadForPhoneme(string phoneme)
    {
        return Heads[phoneme];
    }

    void Awake()
    {
        Heads.Add("ah", 1);
        Heads.Add("eh", 2);
        Heads.Add("ey", 2);
        Heads.Add("i",  3);
        Heads.Add("oh", 4);
        Heads.Add("yu", 5);
        Heads.Add("oo", 5);
        Heads.Add("sh", 6);
        Heads.Add("t", 7);
        Heads.Add(".", 7);
        Heads.Add(",", 7);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
