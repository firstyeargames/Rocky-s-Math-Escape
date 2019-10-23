using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileTrigger : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D col){
		Enemy.instance.PlaneCollider (col);
	}
}
