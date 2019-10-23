using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public static Bullet Instance;


	public void BulletTriggered (Collider2D col){
		GameObject go = GameObject.Find ("Airplane");
		Destroy (go.gameObject);

		}

}
