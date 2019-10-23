using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class LeaderBoard : MonoBehaviour {


	public static LeaderBoard instance;
	public GameObject Board;


	 void Awake(){
		DontDestroyOnLoad (Board);
		Board.SetActive (false);
		instance = this;
	

	}

	public void Back(){
		SceneManager.LoadScene ("MainMenu");
	
	}

}
