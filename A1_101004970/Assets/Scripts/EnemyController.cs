﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	[SerializeField]
	private float speed = 2f;

	[SerializeField]
	private float limitRightX = -1250f;

	[SerializeField]
	private float limitLeftX = -1837f;

	[SerializeField]
	private float topY = 181f;

	[SerializeField]
	private float bottomY = -121f;

	private Transform _transform;
	private Vector2 _currentPos;

	// Use this for initialization
	void Start () {
		//Make starting point Random
		float newPosX = Random.Range (0, 100);
		float newPosY = Random.Range (-123, 183);
		_transform = gameObject.GetComponent<Transform> ();
		_currentPos = new Vector2 (limitRightX+newPosX,newPosY);
		_transform.position = _currentPos;
	}
	
	// Update is called once per frame
	void Update () {
		_currentPos = _transform.position;
		_currentPos -= new Vector2 (speed, 0);
		if (_currentPos.x < limitLeftX) {
			Reset ();
		}
		_transform.position = _currentPos;
	}

	public void Reset(){
		float newPosX = Random.Range (0, 200);
		float newPosY = Random.Range (-123, 183);
		_currentPos = new Vector2 (limitRightX+newPosX,newPosY);
		_transform.position = _currentPos;
	}
}