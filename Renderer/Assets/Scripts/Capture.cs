using System.IO;
using UnityEngine;
using System.Collections;

public class Capture : MonoBehaviour {

  int counter = 0;
  public string path = "render";
  bool DoCapture = false;

	// Use this for initialization
	void Start () {
    Time.captureFramerate = 25;
    DoCapture = true;

    Directory.CreateDirectory(path);
    
	}
	
	// Update is called once per frame
	void FixedUpdate () {

    if ( DoCapture = true ) { 
    counter++;
      //yield return new WaitForEndOfFrame();
    Application.CaptureScreenshot(path + "/" + Time.frameCount + ".png");
    }

  }
}
