using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject watch, painting, wheel;


	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if (watch.GetComponent<PickUPItem> ().picked) {
			SceneManager.LoadScene ("Scene2");
		} 
		if (painting.GetComponent<PickUPItem> ().picked) {
			SceneManager.LoadScene ("Scene3");
		} 
		if (wheel.GetComponent<PickUPItem> ().picked) {
			SceneManager.LoadScene ("Scene4");
		}
	}
}
