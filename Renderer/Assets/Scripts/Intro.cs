using UnityEngine;
using System.Collections;

public class Intro : MonoBehaviour {

	// Use this for initialization
	void Start () {
    Invoke("Hide", 5);
	}

  void Hide()
  {
    this.transform.gameObject.SetActive(false);
  }
	
	// Update is called once per frame
	void Update () {
	
	}
}
