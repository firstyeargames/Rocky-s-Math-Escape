using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundaries : MonoBehaviour {
	Vector2 playerPosition;

	void Start(){
		playerPosition = new Vector2 (0, -4);
	}

	// Update is called once per frame
	void Update () {
		
		playerPosition.x =  Mathf.Clamp (Time.time, -3, 3);
		playerPosition.y =  Mathf.Clamp (Time.time, -4, 4);	


	}
}
