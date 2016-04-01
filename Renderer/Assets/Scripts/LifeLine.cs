using System;
using UnityEngine;
using System.Collections;

public class LifeLine : MonoBehaviour {

  public bool RX = false;
  public bool RY = false;
  public bool RZ = false;

  public string Morph;

  public Transform Target;
  Quaternion TargetRotation;
  Quaternion OriginalRotation;
  public float Speed = 1;

  public float Multiplier = 100;
  public float Direction = 1;
  
  public float MaxDelay = 4;
  public float Delay = 10;
  int state = 0;
  public System.Random rnd = new System.Random();

  public float Driver = 0;

  // Use this for initialization
  void Start () {
    rnd = new System.Random();
    if ( Target != null )
    {
      OriginalRotation = Target.localRotation;
      TargetRotation = OriginalRotation;
    }
  }

  public float Value()
  {
    return Driver * Multiplier;
  }

  public void Reset()
  {

  }

  public void Step(float timedelta)
  {
    if( state == 1 )
    {
      Delay -= timedelta;
      if (Delay < 0)
      {
        state = 0;
        Delay = MaxDelay * (float)rnd.NextDouble()*MaxDelay;
        TargetRotation = OriginalRotation;
      }
      
    }
    

    if (state == 0)
    {
      Delay -= timedelta;
      Driver += timedelta * Direction * Speed;

      if (Driver > 1)
      {
        Direction = -1;
        state = 1;
        TargetRotation *= Quaternion.Euler(          
          RX?(float)rnd.NextDouble() * Multiplier - (Multiplier / 2):0,
          RY ? (float)rnd.NextDouble() * Multiplier - (Multiplier / 2) : 0,
          RZ ? (float)rnd.NextDouble() * Multiplier - (Multiplier / 2) : 0);
      }
      if (Driver < 0)
      {
        state = 1;
        Direction = 1;
        TargetRotation *= Quaternion.Euler(
          RX?(float)rnd.NextDouble() * Multiplier - (Multiplier / 2):0,
          RY ? (float)rnd.NextDouble() * Multiplier - (Multiplier / 2) : 0,
          RZ ? (float)rnd.NextDouble() * Multiplier - (Multiplier / 2) : 0);
      }      
    }

    if ( Target != null )
    {
      Target.localRotation = Quaternion.Slerp(Target.localRotation, TargetRotation, timedelta);
    }

  }
	
	// Update is called once per frame
	void Update () {
	
	}
}
