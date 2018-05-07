using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour {

	bool animation;
	bool finished;
	float finalLeft;
	float finalScale;
	float del;
	int counter;
	// Use this for initialization
	void Start () {
		del = 200;
		animation = false;
		counter = 0;
		finished = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (animation && (counter < ((int) del)) && !finished) {
			transform.Rotate (0f, 0f, .1f);
			transform.localScale += new Vector3 (0f, 0.002f, 0f);
			counter += 1;
			if (counter == 200) {
				finished = true;
			}
		}
		if (finished && counter > 0) {
			transform.Rotate (0f, 0f, -0.1f);
			transform.localScale -= new Vector3 (0f, 0.002f, 0f);
			counter -= 1;
			if (counter == 0) {
				finished = false;
			}
		}

//		transform.Rotate (10f, 10f, 10f);
	}

	public void setAnimation () {
		animation = true;
	}
}
