using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class RandomEquation : MonoBehaviour {

	int firstValue, secondValue;
	int Symbol;
	int randIndex;
	int Solution = 0;
	int SolutionRange; 
	public int timeSpeed = 5;
	public float mathCountDownTime = 60;
	 
	int randValueInt;
	int SolutionPosition;

	public static RandomEquation instance;
	public TextMesh[] textMeshes;
	public GameObject Equation;
	public GameObject TimeDuration;
	string	randValueString;


	void Awake(){
		instance = this;

	}

	void Start () {

		SolutionPosition = Random.Range (0, 9);

		if (Mileage.Instance.CurrentScore >= 0 && Mileage.Instance.CurrentScore <= 1000) {
			EasyStage ();
		
		}

		if (Mileage.Instance.CurrentScore >= 1000 && Mileage.Instance.CurrentScore <= 2000) {
			MediumStage ();

		}

		if (Mileage.Instance.CurrentScore >= 2000 && Mileage.Instance.CurrentScore <= 3000) {
			HardStage ();

		}

		if (Mileage.Instance.CurrentScore >= 3000) {
			EndlessStage ();

		}
			

	}

	public void Update(){

		mathCountDownTime -= Time.deltaTime * timeSpeed;
		TimeDuration.GetComponent<GUIText>().text = ((int)mathCountDownTime).ToString ();

		if (mathCountDownTime <= 0) {
			mathCountDownTime = 0;

			LeaderBoard.instance.Board.SetActive (true);
		}



	}



	void QuitGame(){

		#if UNITY_EDITOR

		UnityEditor.EditorApplication.isPlaying = false;

		#else
		Application.Quit();

		#endif
	}

	void EasyStage(){

		firstValue = Random.Range (1, 5);
		secondValue = Random.Range (1, 4);
		Symbol = Random.Range (0, 2);


		if (Symbol == 1) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " + " + secondValue.ToString () + " = ";
			Solution = firstValue + secondValue;

		} else if (Symbol == 0) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " - " + secondValue.ToString () + " = ";
			Solution = firstValue - secondValue;

		} 

		for (int i = 0; i < 10; i++) {

			randIndex = Random.Range (0, 10);
			randValueInt = Random.Range (-99, 99);
			SolutionPosition = Random.Range (0, 9);
			randValueString = randValueInt.ToString ();

			textMeshes [i].text = randValueString;
			if (i == SolutionRange) {
				textMeshes [i].text = Solution.ToString ();
			}



			Debug.Log (Solution);
		}
	}
		

	void MediumStage(){
		firstValue = Random.Range (1, 5);
		secondValue = Random.Range (1, 4);
		Symbol = Random.Range (0, 2);


		if (Symbol == 1) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " x " + secondValue.ToString () + " = ";
			Solution = firstValue * secondValue;

		} else if (Symbol == 0) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " x " + secondValue.ToString () + " = ";
			Solution = firstValue * secondValue;
		} 

		for (int i = 0; i < 10; i++) {

			randIndex = Random.Range (0, 10);
			randValueInt = Random.Range (-99, 99);
			SolutionPosition = Random.Range (0, 9);
			randValueString = randValueInt.ToString ();

			textMeshes [i].text = randValueString;

			if (i == SolutionRange) {
				textMeshes [i].text = Solution.ToString ();
			}
		Debug.Log (Solution);
		}
	}


	void HardStage(){
		firstValue = Random.Range (-5, 5);
		secondValue = Random.Range (-5, 5);
		Symbol = Random.Range (0, 2);


		if (Symbol == 1) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " - " + secondValue.ToString () + " = ";
			Solution = firstValue - secondValue;

		} else if (Symbol == 0) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " x " + secondValue.ToString () + " = ";
			Solution = firstValue * secondValue;
		} 

		for (int i = 0; i < 10; i++) {

			randIndex = Random.Range (0, 10);
			randValueInt = Random.Range (-99, 99);
			SolutionPosition = Random.Range (0, 9);
			randValueString = randValueInt.ToString ();

			textMeshes [i].text = randValueString;

			if (i == SolutionRange) {
				textMeshes [i].text = Solution.ToString ();
			}
		Debug.Log (Solution);
	
	}
}

	void EndlessStage(){
		firstValue = Random.Range (-10, 10);
		secondValue = Random.Range (-10, 10);
		Symbol = Random.Range (0, 3);


		if (Symbol == 0) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " - " + secondValue.ToString () + " = ";
			Solution = firstValue - secondValue;

		} else if (Symbol == 1) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " + " + secondValue.ToString () + " = ";
			Solution = firstValue + secondValue;
		} 

		if (Symbol == 2) {
			Equation.GetComponent<GUIText> ().text = firstValue.ToString ()
				+ " x " + secondValue.ToString () + " = ";
			Solution = firstValue * secondValue;

		} 

		for (int i = 0; i < 10; i++) {

			randIndex = Random.Range (0, 10);
			randValueInt = Random.Range (-99, 99);
			SolutionPosition = Random.Range (0, 9);
			randValueString = randValueInt.ToString ();

			textMeshes [i].text = randValueString;

			if (i == SolutionRange) {
				textMeshes [i].text = Solution.ToString ();
			}
		}
		Debug.Log (Solution);

	
	}
		

	public void AnswerSubmitted (GameObject gameObject) 
	{

		//Debug.Log ("Test");
		string result = gameObject.transform.GetChild (0).GetComponent<TextMesh> ().text;
		//Debug.Log (result);	
		int intResult = int.Parse (result);
		//Debug.Log (intResult);
	

		if (intResult != Solution) {
				SceneManager.LoadScene ("EquationBoard");
			}



		if (Solution <= 0) {

			intResult = -Mathf.Abs (intResult);
		}

		if (intResult.Equals (Solution)) {

			Mileage.Instance.InsideEquation = false;
			SceneManager.LoadScene ("Game");  

		}

	}


}