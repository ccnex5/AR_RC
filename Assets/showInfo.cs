using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showInfo : MonoBehaviour {

//	public GameObject kitten;
	public kittenController kitten;
	public GameObject canvas;
	public Text canvasText;


	void Start(){
//		kitten = GameObject.FindGameObjectWithTag ("Player");


	}
	void OnCollisionEnter(Collision col){
		canvasText.text = "The duck is a number of species in the Anatidae family of birds. Can you find the other members of this family?";
		canvas.SetActive(true);
		kitten.StartingQuestPosition ();
	}
}
