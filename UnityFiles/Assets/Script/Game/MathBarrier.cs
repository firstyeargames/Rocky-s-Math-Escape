using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathBarrier : MonoBehaviour {
	Mileage mile;
	public GameObject mathsB;

	// Use this for initialization
	void Start(){
		mathsB.SetActive (false);
		DontDestroyOnLoad (mathsB);
	}

	void Update(){
		if(mile.CurrentScore >= 30)
		mathsB.SetActive (true);				

	}

}
