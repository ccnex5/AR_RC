using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showInfo : MonoBehaviour {

//	public GameObject kitten;
	public kittenController kitten;
	public GameObject canvas;
	public Text textObject;
	public string canvasText;


	void Start(){
//		kitten = GameObject.FindGameObjectWithTag ("Player");
		textObject = GameObject.FindWithTag("CanvasTextTag").GetComponent(typeof(Text)) as Text;
//		Debug.Log (textObject + " this is the textObject");
	}
	void OnCollisionEnter(Collision col){

		textObject.text = canvasText;
		canvas.SetActive(true);
		kitten.StartingQuestPosition ();
	}
}
