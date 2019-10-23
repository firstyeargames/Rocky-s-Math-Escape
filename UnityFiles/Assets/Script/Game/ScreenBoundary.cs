using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundary : MonoBehaviour {

	private float minX, minY, maxX, maxY;
	Vector2 pos = new Vector2(0, -4);

	void Start(){
		
		float camDistance = Vector2.Distance (transform.position, Camera.main.transform.position);
		Vector2 bottomCorner = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, camDistance));
		Vector2 topCorner = Camera.main.ViewportToWorldPoint (new Vector3 (1, 1, camDistance));

		minX = bottomCorner.x;
		minY = bottomCorner.y;
		maxX = topCorner.x;
		maxY = topCorner.y;
	}

	void Update(){
	


		// Horizontal contraint
		if (pos.x < minX) pos.x = minX;
		if (pos.x > maxX) pos.x = maxX;
	
		// Vertical contraint
		if (pos.y < minY) pos.y = minY;
		if (pos.y < maxY) pos.y = maxY;

		// Update position
		//transform.position = pos;
	
	}

}
