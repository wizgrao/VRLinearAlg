using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeImage : MonoBehaviour {

	public Sprite text1;
	public Sprite text2;
	public Sprite text3;
	public Sprite text4;
	public Sprite text5;
	public GameObject targetVec;
	Image image;
	int counter;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void transition () {
		if (counter == 0) {
			image.sprite = text2;
			counter = 1;
		} else if (counter == 1) {
			image.sprite = text3;
			counter = 2;
		} else if (counter == 2) {
			image.sprite = text4;
			counter = 3;
		} else if (counter == 3) {
			image.sprite = text5;
			counter = 4;
		} else if (counter == 4) {
			image.sprite = text1;
			counter = 0;
		}
	}
}
