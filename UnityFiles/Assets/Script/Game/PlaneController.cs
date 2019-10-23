using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

	public static PlaneController Instance;

	public GameObject laser;
	public float projectileSpeed;
	float firingRate = 0.5f;
	float nextFire = 0f;
	public int Health = 400;


	void Update(){


		if (Input.GetMouseButton (0) && Time.deltaTime > nextFire) { 

			nextFire = Time.deltaTime + firingRate; 
			InvokeRepeating ("Project", 0f, firingRate);
		
		}
			
		if (Input.GetMouseButtonUp (0))
		 		CancelInvoke ("Project");


		}
		



	void Project(){
		
		Vector3 offset = new Vector3 (0, 2, 0);
		GameObject Beam = Instantiate (laser, transform.position + offset, Quaternion.identity) as GameObject;
		Beam.GetComponent<Rigidbody2D>().velocity = new Vector3 (0, projectileSpeed, 0);
	}

	public void OnTriggerEnter2D(Collider2D col){
		Score.Instance.PlaneTriggered (col);
	}

}