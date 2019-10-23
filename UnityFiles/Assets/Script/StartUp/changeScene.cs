using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : Mileage {

	void Awake(){
		SceneManager.LoadScene ("Game");
	}
}
