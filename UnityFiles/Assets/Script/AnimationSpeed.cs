using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour {
	Animator anim;
	private float animSpeed = 0.2f;


	void Start () {
		anim = GetComponent<Animator> ();

	}

	void Update(){
	
		anim.speed = animSpeed;
	}

}
