/*
Source File Name: TankController.cs;
Author's Name: Rafael Sanches Carvalho;
Program Description: This script controls the moviment of the tank (our Hero) according to the inputs of the player; 
Last Modified by: Autor;
Date last Modified: 15/Oct/2017;
Revision History: 
->15/Oct/2017 - Inclusion of Header;
->15/Oct/2017 - Inclusion of the optional WASD keys;
->11/Oct/2017 - Creation of the file;
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour {

	[SerializeField]
	private float speedY = 2f;

	[SerializeField]
	private float speedX = 2f;

	[SerializeField]
	private float topY = 183f;

	[SerializeField]
	private float bottomY = -123f;

	[SerializeField]
	private float startX = 183f;

	[SerializeField]
	private float endX = -123f;

	private Transform _transform;
	private Vector2 _currentPos;

	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		//Move UP event
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {		
			_currentPos = _transform.position;
			if (_currentPos.y < topY) {
				_currentPos += new Vector2 (0, speedY);
			}
			_transform.position = _currentPos;
		}

		//Move Down event
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {		
			_currentPos = _transform.position;
			if (_currentPos.y > bottomY) {
				_currentPos -= new Vector2 (0, speedY);
			}
			_transform.position = _currentPos;
		}

		//Move Front event
		if (Input.GetKey (KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {		
			_currentPos = _transform.position;
			if (_currentPos.x < endX) {
				_currentPos += new Vector2 (speedX, 0);
			}
			_transform.position = _currentPos;
		}

		//Move Back event
		if (Input.GetKey (KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {		
			_currentPos = _transform.position;
			if (_currentPos.x > startX) {
				_currentPos -= new Vector2 (speedX+2, 0);
			}
			_transform.position = _currentPos;
		}
		
	}
}
