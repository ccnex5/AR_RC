using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
	
	public Transform hero1;
	public float speed;
	
	// Update is called once per frame
	void Update () {
		//only follows position and not rotation, as opposed to attaching camera to the hero (thus Lerp)
		transform.position = Vector3.Lerp (transform.position, hero1.position, speed * Time.deltaTime);
	}
}
