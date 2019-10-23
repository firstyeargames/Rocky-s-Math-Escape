using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsnwerBox : MonoBehaviour {

	public RandomEquation mRandomEquation;

	public void OnTriggerEnter2D(Collider2D other)
	{
		mRandomEquation.AnswerSubmitted (other.gameObject);

	}

}
