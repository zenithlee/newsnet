using UnityEngine;
using System.Collections;

public class LookAt : MonoBehaviour {

  public Transform Target;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
	
    if ( Target != null )
    {
      this.gameObject.transform.LookAt(Target);
    }

	}
}
