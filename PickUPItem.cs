using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUPItem : MonoBehaviour {

	public bool picked;

	// Use this for initialization
	void Start () {
		picked = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void isPicked(){

		picked = true;
	}
}
