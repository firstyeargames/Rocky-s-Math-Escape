using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {
	public Slider volumeSlider;
	public AudioSource volumeAudio;
	public 	GameObject Music;


	void Awake(){
		DontDestroyOnLoad (Music);
	}

	public void PlayGame(){

		SceneManager.LoadScene ("StartUp");
		
	}

	public void QuitGame(){
		#if UNITY_EDITOR

		UnityEditor.EditorApplication.isPlaying = false;
		#else

		Application.Quit() ;
	
		#endif

	}

	public void Volume(){
		volumeAudio.volume = volumeSlider.value;
	
	}

}
