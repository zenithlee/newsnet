using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using MORPH3D;
using MORPH3D.FOUNDATIONS;
using System.Collections.Generic;



public class Driver3d : CDriver
{

  public MORPH3D.M3DCharacterManager man;

  Quaternion NextHeadRotation;
  public Transform Neck;

  public LifeLine SentimentPositive;
  public float SentiPos = 0;
  public float MaxSentiPos = 0.5f;
  public LifeLine SentimentNegative;
  public float SentiNeg = 0;
  public float MaxSentiNeg = 0.5f;
  public GameObject LifeLineHolder;
  public double sentiment = 0;  

  public void Test()
  {
    //man.Get
    List<MORPH3D.FOUNDATIONS.CoreBlendshape> names = man.GetAllBlendshapes();

    foreach(CoreBlendshape name in names)
    {
      Debug.Log(name.ID);
      DebugText.text += name.ID + ",";
    }   
    
    CoreBlendshape cbs = man.GetBlendshapeByID("VSMAA");
    cbs.currentValue = 0.5f;
    cbs.UpdateBlendshapeValue(0.5f);
    man.SetBlendshapeValue("VSMAA", 25);
    man.SetBlendshapeValue("VSMTH", 128);
  }

  /*
  public override IEnumerator Blink() {
  //  Debug.Log("Blink");
    for (int f= 0; f < 100; f+=20) {
      man.SetBlendshapeValue("PHMEyesClosedR", f);
      man.SetBlendshapeValue("PHMEyesClosedL", f);
      yield return new WaitForSeconds(0.01f);
    }
    man.SetBlendshapeValue("PHMEyesClosedR", 0);
    man.SetBlendshapeValue("PHMEyesClosedL", 0);
   // Debug.Log("/Blink");
    HeadMotion1();
    
  }
  */

  public override void SetExpressionFromSentiment(double d)
  {
    sentiment = d;
  }

  public override IEnumerator HeadMotion()
  {
    System.Random r = new System.Random();
    if ( r.NextDouble()<0.5)
    {
      HeadMotion1();
    }
    else     
    {
      HeadMotion2();
    }

    yield return new WaitForSeconds(0.5f);
  }

  public void HeadMotion1()
  {
    System.Random r = new System.Random();

    NextHeadRotation = Quaternion.Euler(0, r.Next(-8, 8), 0);
  }

  public void HeadMotion2()
  {
    System.Random r = new System.Random();
    
    NextHeadRotation = Quaternion.Euler(r.Next(-3,3), r.Next(-5,5), r.Next(-5,5));

  }

  public override string MapHeadShape(int n)
  {
    return "";
  }

  //man.SetBlendshapeValue("VSMW", 128);
  //man.SetBlendshapeValue("VSMUW", 128);
  //man.SetBlendshapeValue("VSMTH", 128);
  //man.SetBlendshapeValue("VSMT", 128);
  //man.SetBlendshapeValue("VSMSH", 128);
  //man.SetBlendshapeValue("VSMS", 128);
  //man.SetBlendshapeValue("VSMOW", 128);
  //man.SetBlendshapeValue("VSMM", 128);
  //man.SetBlendshapeValue("VSML", 128);
  //man.SetBlendshapeValue("VSMK", 128);
  //man.SetBlendshapeValue("VSMIH", 128);
  //man.SetBlendshapeValue("VSMF", 128);
  public override void SetHeadFromSAPIID(int n, float v)
  {
    //MORPH3D.FOUNDATIONS.CoreBlendshape cbs = man.GetBlendshapeByID("VSMAA");
    switch( n)
    {      
      case 1:
        man.GetBlendshapeByID("VSMAA").AdjustValue(v);        
        //man.SetBlendshapeValue("VSMAA", 100);
        break;
      case 2:
        man.GetBlendshapeByID("VSMAA").AdjustValue(v);        
        break;
      case 3:
        man.GetBlendshapeByID("VSMOW").AdjustValue(v);
        //man.SetBlendshapeValue("VSMOW", 100);        
        break;
      case 4:
        man.GetBlendshapeByID("VSMEH").AdjustValue(v);
        //man.SetBlendshapeValue("VSMEH", 100);
        break;
      case 5:
        man.GetBlendshapeByID("VSMER").AdjustValue(v);
        //man.SetBlendshapeValue("VSMER", 100);        
        break;
      case 6:
        man.GetBlendshapeByID("VSMIY").AdjustValue(v);
        //man.SetBlendshapeValue("VSMIY", 100);        
        break;
      case 7:
        man.GetBlendshapeByID("VSMW").AdjustValue(v);
        //man.SetBlendshapeValue("VSMW", 100);        
        break;
      case 8:
        man.GetBlendshapeByID("VSMOW").AdjustValue(v);
        //man.SetBlendshapeValue("VSMOW", 100);        
        break;
      case 9:
        man.GetBlendshapeByID("VSMAA").AdjustValue(v);
        //man.SetBlendshapeValue("VSMAA", 100);        
        break;
      case 10:
        man.GetBlendshapeByID("VSMAA").AdjustValue(v);
        //man.SetBlendshapeValue("VSMAA", 100);
        break;
      case 11:
        man.GetBlendshapeByID("VSMEH").AdjustValue(v);
        //man.SetBlendshapeValue("VSMEH", 100);        
        break;
      case 12:
        man.GetBlendshapeByID("VSMEH").AdjustValue(v);
        //man.SetBlendshapeValue("VSMEH", 100);
        break;
      case 13:
        man.GetBlendshapeByID("VSMER").AdjustValue(v);
        //man.SetBlendshapeValue("VSMER", 100);
        break;
      case 14:
        man.GetBlendshapeByID("VSML").AdjustValue(v);
        //man.SetBlendshapeValue("VSML", 100);
        break;
      case 15:
        man.GetBlendshapeByID("VSMS").AdjustValue(v*0.75f);
        //man.SetBlendshapeValue("VSMS", 100);        
        break;
      case 16:
        man.GetBlendshapeByID("VSMSH").AdjustValue(v*0.75f);
        //man.SetBlendshapeValue("VSMSH", 100);
        break;
      case 17:
        man.GetBlendshapeByID("VSMTH").AdjustValue(v*0.8f);
        //man.SetBlendshapeValue("VSMTH", 100);
        break;
      case 18:
        man.GetBlendshapeByID("VSMF").AdjustValue(v);
        //man.SetBlendshapeValue("VSMF", 100);
        break;
      case 19:
        man.GetBlendshapeByID("VSMT").AdjustValue(v);
        man.GetBlendshapeByID("VSMER").AdjustValue(v*0.5f);
        //man.SetBlendshapeValue("VSMT", 100);
        break;
      case 20:
        man.GetBlendshapeByID("VSMK").AdjustValue(v);
        //man.SetBlendshapeValue("VSMK", 100);
        break;
      case 21:
        man.GetBlendshapeByID("VSMM").AdjustValue(v);
        //man.SetBlendshapeValue("VSMM", 100);
        break;
      default:
        man.SetBlendshapeValue("VSMW", 0);
        man.SetBlendshapeValue("VSMUW", 0);
        man.SetBlendshapeValue("VSMTH", 0);
        man.SetBlendshapeValue("VSMT", 0);
        man.SetBlendshapeValue("VSMSH", 0);
        man.SetBlendshapeValue("VSMS", 0);
        man.SetBlendshapeValue("VSMOW", 0);
        man.SetBlendshapeValue("VSMM", 0);
        man.SetBlendshapeValue("VSML", 0);
        man.SetBlendshapeValue("VSMK", 0);
        man.SetBlendshapeValue("VSMIY", 0);
        man.SetBlendshapeValue("VSMIH", 0);
        man.SetBlendshapeValue("VSMF", 0);
        man.SetBlendshapeValue("VSMER", 0);
        man.SetBlendshapeValue("VSMEH", 0);
        man.SetBlendshapeValue("VSMAA", 0);        
        break;
    }
    
  }
  // Use this for initialization
  void Start () {
   // man = GetComponent<MORPH3D.M3DCharacterManager>();
  }
	
	// Update is called once per frame
	void Update () {
    //Neck.transform.localRotation = Quaternion.Lerp(Neck.transform.localRotation, NextHeadRotation, Time.deltaTime);
    Neck.transform.localRotation = Quaternion.Slerp(Neck.transform.localRotation, NextHeadRotation, Time.deltaTime);

    LifeLine[] LifeLines = GetComponentsInChildren<LifeLine>();
    foreach( LifeLine line in LifeLines)
    {
      line.Step(Time.deltaTime);
      if ( line.DriveSentiment ) { 
        line.SetSentiment((float)sentiment);
      }
      if ( line.DriveMorphs ) { 
        man.SetBlendshapeValue(line.Morph1.ToString(), line.Value());
        man.SetBlendshapeValue(line.Morph2.ToString(), line.Value());
      }
    }    

  }
}
