using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vr_loo_walk : MonoBehaviour {

	public Transform vrCamera;

	public float toggleAngle = 20.0f;

	public float speed = 2.0f;

	public bool moveforward;

	private CharacterController cc;


	// Use this for initialization
	void Start () {
		
		cc = GetComponent <CharacterController> ();	
	}
	
	// Update is called once per frame
	void Update () {
		if (vrCamera.eulerAngles.x >= toggleAngle && vrCamera.eulerAngles.x < 90.0) {
			moveforward = true;
		}
		else {
			moveforward = false;
		}
		if (moveforward) {
			Vector3 forward = vrCamera.TransformDirection(Vector3.forward);

			cc.SimpleMove(forward * speed);
		}
	}
}
