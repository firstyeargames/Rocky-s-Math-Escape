using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GizmoCircle : MonoBehaviour {


	public int width = 1;
	public int height = 1; 

	public void OnDrawGizmos(){
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height)); 
	}
}
