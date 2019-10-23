using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colletables : MonoBehaviour {

	public Transform[] spawnPoints;
	private float spawnTime = .5f;
	public GameObject Bone;

	private float EnemySpeed = 1.5f;
	private int yDirection = -1;

	void Start () {
		InvokeRepeating("spawnBone", spawnTime, 5f);


	}


	void spawnBone(){
		//set the index number of the array randomly
		int spawnIndex = Random.Range(0, spawnPoints.Length);
		Instantiate(Bone, spawnPoints[spawnIndex].position, spawnPoints[spawnIndex].rotation);
	}


	void Update () {

		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, yDirection) * EnemySpeed;

	}

}
