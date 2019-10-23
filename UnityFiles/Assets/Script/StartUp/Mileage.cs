using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Mileage : MonoBehaviour
{
    private int CountSpeed = 10;
    public Text scoreText;
	public Text HighScore;
	public float CurrentScore = 0f;
	public GameObject rootCanvas;
	public bool InsideEquation = false;
	int TargetScore = 100;
	public static Mileage Instance;

	//Maths Barrier
	public GameObject mathsCountDown;
	public GameObject LeaderBoardCanvas;
	float mathCoutDown_Target = 90;

	//CutScene
	int CutScene_Target = 1001;


	void Awake(){
		Instance = this;
		mathsCountDown.SetActive (false);
		DontDestroyOnLoad (rootCanvas);
		DontDestroyOnLoad (mathsCountDown);
		DontDestroyOnLoad (LeaderBoardCanvas);
	}

    void Start()

    {
		
		scoreText.text = ((int)PlayerPrefs.GetInt("HighScore")).ToString(); 	
		HighScore.text = ((int)PlayerPrefs.GetInt("HighScore")).ToString(); 	
	}

    public void Update()
    {

		PlayerPrefs.SetFloat("HighScore", CurrentScore);

		if (InsideEquation)
			return;
			CurrentScore += Time.deltaTime * CountSpeed;
			scoreText.text = ((int)CurrentScore).ToString ();
			HighScore.text = ((int)CurrentScore).ToString ();


		//maths count down, EquationBarrier will be loaded

		if (CurrentScore >= mathCoutDown_Target) {
			mathCoutDown_Target += 100;
			mathsCountDown.SetActive (true);
			//mathsB.GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 8) * -0.2f;
		}
			

		if (CurrentScore >= TargetScore)
		{
			TargetScore += 100;
			InsideEquation = true;
			SceneManager.LoadScene("EquationBoard");
			mathsCountDown.SetActive (false);
		}	

		// Cut Scene for the next level

		if (CurrentScore > CutScene_Target) {
			CutScene_Target += 1000;
			InsideEquation = true;
			SceneManager.LoadScene ("CutScene");
			mathsCountDown.SetActive (false);
		}

    }

}
