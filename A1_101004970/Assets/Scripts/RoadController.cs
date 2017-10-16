/*
Source File Name: RoadController.cs;
Author's Name: Rafael Sanches Carvalho;
Program Description: This script controls the moviment of the road (background scenario) in a loop; 
Last Modified by: Autor;
Date last Modified: 15/Oct/2017;
Revision History: 
->15/Oct/2017 - Inclusion of Header;
->10/Oct/2017 - Creation of the file;
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {

	[SerializeField]
	private float speed = 2f;

	[SerializeField]
	private float startX = 1.9f;

	[SerializeField]
	private float endX = -314f;


	private Transform _transform;
	private Vector2 _currentPos;

	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = _transform.position;
	}

	void Update () {
		_currentPos = _transform.position;
		_currentPos -= new Vector2 (speed, 0);

		if (_currentPos.x < endX) {
			Reset ();
		}
		_transform.position = _currentPos;

	}

	private void Reset(){
		_currentPos = new Vector2 (startX, 0);
	}
}
