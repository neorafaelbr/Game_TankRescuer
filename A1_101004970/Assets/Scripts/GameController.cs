/*
Source File Name: GameController.cs;
Author's Name: Rafael Sanches Carvalho;
Program Description: This script controls the User Interface elements, by showing, hiding and updating life and scores; 
Last Modified by: Autor;
Date last Modified: 15/Oct/2017;
Revision History: 
->15/Oct/2017 - Inclusion of Header;
->13/Oct/2017 - Inclusion of the Restart and GameOver UI logic;
->11/Oct/2017 - Creation of the file;
*/

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

	[SerializeField]
	private EnemyController enemy;

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
		StartCoroutine ("addEnemy");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Method that controls the UI elements tp be shown when life reaches 0
	private void GameOver(){
		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (true);
		gameOverLabel.gameObject.SetActive (true);
		restartButton.gameObject.SetActive (true);
		tank.gameObject.SetActive (false);
	}

	//Method for restarting the game when user clicks the button
	public void RestartButtonClicked(){	
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	
	}
	//Method for adding more enemies
	private IEnumerator addEnemy(){		
		yield return new WaitForSeconds (5f);
		Instantiate (enemy);
		StartCoroutine ("addEnemy");
	
	}
}
