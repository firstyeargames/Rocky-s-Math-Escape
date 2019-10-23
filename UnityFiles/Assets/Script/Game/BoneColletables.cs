using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneColletables : MonoBehaviour {

	public static BoneColletables Instance;
	Vector3 spawnPoints;
	private float spawnTime = 0.5f;
	public GameObject Bone;

	public float speed = 1.5f;
	private int yDirection = -1;

	void Start () {
		InvokeRepeating("spawnBone", spawnTime, 10f);
		spawnPoints = new Vector3 (0, 4, 0); 

	}


	void spawnBone(){
		//set the index number of the array randomly
		float spawnIndex = Random.Range(-2.5f, 2.5f );
		spawnPoints = new Vector3 (spawnIndex, 5.5f, 0); 
		Instantiate(Bone, spawnPoints, Quaternion.identity);
	}


	void Update () {

		gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, yDirection) * speed;

	}

}
