using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraToPlayer : MonoBehaviour {

    public GameObject player;
    Vector3 Offset;

	// Use this for initialization
	void Start () {
        Offset = transform.position;
	}
	
    // Update is called once per frame
	void LateUpdate () {
        transform.position = player.transform.position + Offset * 3;
	}
}
