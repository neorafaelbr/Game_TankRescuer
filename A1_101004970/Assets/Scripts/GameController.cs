using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

	[SerializeField]
	private Text lifeLabel;

	[SerializeField]
	private Text scoreLabel;

	[SerializeField]
	private Text highScoreLabel;

	[SerializeField]
	private Text gameOverLabel;


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
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
