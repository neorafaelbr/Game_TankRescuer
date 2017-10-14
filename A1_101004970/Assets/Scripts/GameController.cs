using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[SerializeField]
	private TankController tank;

	[SerializeField]
	private Text lifeLabel;

	[SerializeField]
	private Text scoreLabel;

	[SerializeField]
	private Text highScoreLabel;

	[SerializeField]
	private Text gameOverLabel;

	[SerializeField]
	private Button restartButton;


	private int _score;
	private int _life;

	public int Score{
		get{ return _score;}
		set{ 
			_score = value; 
			scoreLabel.text = "Score: " + _score;
		}
	}

	public int Life{
		get{ return _life;}
		set{ 
			_life = value;
			lifeLabel.text = "Life: " + _life;
			if (_life <= 0) {
				highScoreLabel.text = "HIGH SCORE = " + _score;
				GameOver ();
			} 

			else {
				//Game Over
			}
		}
	}

	// Use this for initialization
	void Start () {
		Life = 3;
		Score = 0;
		lifeLabel.gameObject.SetActive (true);
		scoreLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (false);
		gameOverLabel.gameObject.SetActive (false);
		restartButton.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void GameOver(){
		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (true);
		gameOverLabel.gameObject.SetActive (true);
		restartButton.gameObject.SetActive (true);
		tank.gameObject.SetActive (false);
	}

	public void RestartButtonClicked(){
	
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	
	}
}
