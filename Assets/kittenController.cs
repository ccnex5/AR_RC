using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class kittenController : MonoBehaviour {
	public int velocity;
	private Rigidbody rb;
	//private Animation anim;
	// Use this for initialization
//	private Transform resetTransform;
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (x, 0, y);

//		rb.velocity = movement * 4f;
		rb.velocity = movement * velocity; 
		if(x!=0 && y!=0){
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2(x,y)*Mathf.Rad2Deg,transform.eulerAngles.z);

		}
	}
	public void StartingQuestPosition(){
//		transform.position = new Vector3 (0, 0, 0);
		Debug.Log("Starting quest position");
	}
}
