using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CutScene : MonoBehaviour {


	private IEnumerator coroutine;

	// Use this for initialization
	void Start () {

			coroutine = jumpToScene (1f);
			StartCoroutine (coroutine);

	}

	IEnumerator jumpToScene(float waitTime){
	
		yield return new WaitForSeconds (waitTime);
		SceneManager.LoadScene ("Game");
		Mileage.Instance.InsideEquation = false;
	}


	// Update is called once per frame
	void Update () {
		
	}
}
