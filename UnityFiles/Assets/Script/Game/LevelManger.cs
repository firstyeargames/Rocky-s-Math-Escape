using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManger : MonoBehaviour {

	public GameObject SkyBG;
	public GameObject ForestBG;
	public GameObject AmazonForestBG;
	public GameObject RiverBG;


	private int ForestTarget = 1002;
	private int AmazonTarget = 2002;
	private int RiverTarget = 3002;
	private int SkyTarget = 4002;

	void Awake(){
		SkyBG.SetActive (true);
		ForestBG.SetActive (false);
		AmazonForestBG.SetActive (false);
		RiverBG.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		levelChange ();
	}

	void levelChange(){
		if (Mileage.Instance.CurrentScore >= ForestTarget) {
			ForestTarget += 4000;
			SkyBG.SetActive (false);
			ForestBG.SetActive (true);
			AmazonForestBG.SetActive (false);
			RiverBG.SetActive (false);

		}

		if (Mileage.Instance.CurrentScore >= AmazonTarget) {
			AmazonTarget += 4000;
			SkyBG.SetActive (false);
			ForestBG.SetActive (false);
			AmazonForestBG.SetActive (true);
			RiverBG.SetActive (false);

		}

		if (Mileage.Instance.CurrentScore >= RiverTarget) {
			RiverTarget += 4000;
			SkyBG.SetActive (false);
			ForestBG.SetActive (false);
			AmazonForestBG.SetActive (false);
			RiverBG.SetActive (true);
		}

		if (Mileage.Instance.CurrentScore >= SkyTarget) {
			SkyTarget += 4000;
			SkyBG.SetActive (true);
			ForestBG.SetActive (false);
			AmazonForestBG.SetActive (false);
			RiverBG.SetActive (false);
		}
	}

}
