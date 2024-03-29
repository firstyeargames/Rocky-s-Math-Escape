﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SocialSharing : MonoBehaviour {

	public GameObject sharingCanvas;
	private bool isProcessing = false;
	private bool isFocus = false;


	public void ShareButtonPress(){

		if (!isProcessing) {
		
			sharingCanvas.SetActive (true);

			StartCoroutine (shareScreenShot());
		
		}
	}

	IEnumerator shareScreenShot(){
	
		isProcessing = true;

		yield return new WaitForEndOfFrame (); 

		ScreenCapture.CaptureScreenshot ("ScreenShot.png", 2);
		string destination = Path.Combine (Application.persistentDataPath, "ScreenShot.png");

		yield return new WaitForSecondsRealtime (0.3f);

	
		if (!Application.isEditor) {
			AndroidJavaClass intentClass = new AndroidJavaClass ("android.content.Intent");
			AndroidJavaObject intentObject = new AndroidJavaClass ("android.content.Intent");
			intentObject.Call<AndroidJavaObject> ("setAction", intentClass.GetStatic<string> ("ACTION_SEND"));
			AndroidJavaClass uriClass = new AndroidJavaClass ("android.net.Uri");
			AndroidJavaObject uriObject = uriClass.CallStatic<AndroidJavaObject> ("parse", "file://" + destination);
			intentObject.Call<AndroidJavaObject> ("putExtra", intentClass.GetStatic<string> ("EXTRA_STREAM"), uriObject);
			intentObject.Call<AndroidJavaObject> ("putExtra", intentClass.GetStatic<string> ("EXTRA_TEXT"), "Can you beat my score?");
			intentObject.Call<AndroidJavaObject> ("setType", "image/jpeg");
			AndroidJavaClass unity = new AndroidJavaClass ("com.unity3d.player.UnityPlayer");
			AndroidJavaObject currentActivity = unity.GetStatic<AndroidJavaObject> ("currentActivity");
			AndroidJavaObject chooser = intentClass.CallStatic<AndroidJavaObject> ("createChooser", intentObject, "Share your new score");
			currentActivity.Call ("startActivity", chooser);

			yield return new WaitForSecondsRealtime (1);


		
		}
		yield return new WaitUntil(() => isFocus);
		sharingCanvas.SetActive (false);
		isProcessing = false;
	
	}

	private void OnApplicationFocus(bool focus){
	
		isFocus = focus;
	}


}
