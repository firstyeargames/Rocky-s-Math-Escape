using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberController : MonoBehaviour {

	// Use this for initialization
    void OnDrag (DragGesture gesture) {

//		transform.position.x =  Mathf.Clamp (Time.time, -3, 3);
//		transform.position.y =  Mathf.Clamp (Time.time, -4, 4);	
        if (gesture.Selection == null) return;
		if (gesture.Selection.tag != "Player")
			return;
	
        Vector3 target = Camera.main.ScreenToWorldPoint((Vector3)gesture.Position);
        target.z = -1f;
        gesture.Selection.transform.position = target;
	}
	
}
