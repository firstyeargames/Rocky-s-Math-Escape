using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Score : MonoBehaviour {
	public static Score Instance;
	public Text ScoreText;
	public int score;
	public Text HighScore;
	public GameObject rootCanvas;

	void Awake(){
		Instance = this;
		DontDestroyOnLoad (rootCanvas);
	}

	void Start(){
		
		HighScore.text = ((int)PlayerPrefs.GetInt("HighBone")).ToString(); 	

		score = 0;
		UpdateScore ();

	}


	void UpdateScore(){
		ScoreText.text = "Bone: " + score;

		PlayerPrefs.SetInt("HighBone", score);
		HighScore.text = ((int)score).ToString ();
	}

	public void PlaneTriggered(Collider2D col){
			Destroy (col.gameObject);
			score += 1;
			Debug.Log (score);
			UpdateScore ();

	}
}
