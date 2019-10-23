using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour {


	public float speed = 1f;
	public Vector3 startPos;

	// Use this for initialization
	void Start () {
		//startPos = transform.position;
		//Debug.Log(startPos.ToString());
	}

	// Update is called once per frame
	void Update () {

		transform.Translate((new Vector3(0, -1, 0)) * speed * Time.deltaTime);


		if (transform.position.y < -10)
		{

			transform.position = startPos;
			Debug.Log(startPos.ToString());
		}
	}


}

