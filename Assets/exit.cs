using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

	public void doquit(){
		Debug.Log ("exit....");

		UnityEditor.EditorApplication.isPlaying = false;
		Application.Quit ();


	}
		

}
