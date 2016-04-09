using UnityEngine;
using System.Collections;

public class MorphDriver : MonoBehaviour {

  public Vector3 Values;
  public Vector3 TargetValues;
  public float DecayRate = 1;

  public string Morph1;
  public string Morph2;
  public string Morph3;
  // Use this for initialization
  void Start () {
	
	}

  public void SetValue1(float f)
  {
    TargetValues.Set(f, TargetValues.y, TargetValues.z);
  }
  public void SetValue2(float f)
  {
    TargetValues.Set(TargetValues.x, f, TargetValues.z);
  }
  public void SetValue3(float f)
  {
    TargetValues.Set(TargetValues.x, TargetValues.y, f);
  }
  public float Value1()
  {
    return Values.x;
  }
  public float Value2()
  {
    return Values.y;
  }
  public float Value3()
  {
    return Values.z;
  }

  // Update is called once per frame
  void Update () {    
    Values = Vector3.Lerp(Values, TargetValues, Time.deltaTime * DecayRate);
	}
}
