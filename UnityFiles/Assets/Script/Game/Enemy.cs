using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public static Enemy Instance;

	// Enemy 
	Vector3 spawnPoints;
	public GameObject EnemyObj;
	public static Enemy instance;
	private float spawnTime = 1f;
	public float EnemySpeed = 5.5f;
	private int yDirection = -1;
	public int Health = 200;

	//Projectile 


	void Start () {
		
		InvokeRepeating("spawnEnemy", spawnTime, 0.5f);
		spawnPoints = new Vector3 (0, 4, 0); 
		instance = this;
	}


	void spawnEnemy(){
		//set the index number of the array randomly
		float spawnIndex = Random.Range(-2.5f, 2.5f );
		spawnPoints = new Vector3 (spawnIndex, 7f, 0); 
		Instantiate (EnemyObj, spawnPoints, Quaternion.identity);
	}
		
	void Update () {

		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, yDirection) * EnemySpeed;
			
	}



	public void PlaneCollider (Collider2D col){
		if (col.gameObject.tag == "Enemy") {
			Destroy (col.gameObject);
		}

	}




}