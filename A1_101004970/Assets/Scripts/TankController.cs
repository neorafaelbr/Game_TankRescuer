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

		//Move UP
		if (Input.GetKey (KeyCode.UpArrow)) {		
			_currentPos = _transform.position;
			if (_currentPos.y < topY) {
				_currentPos += new Vector2 (0, speedY);
			}
			_transform.position = _currentPos;
		}

		//Move Down
		if (Input.GetKey (KeyCode.DownArrow)) {		
			_currentPos = _transform.position;
			if (_currentPos.y > bottomY) {
				_currentPos -= new Vector2 (0, speedY);
			}
			_transform.position = _currentPos;
		}

		//Move Front
		if (Input.GetKey (KeyCode.RightArrow)) {		
			_currentPos = _transform.position;
			if (_currentPos.x < endX) {
				_currentPos += new Vector2 (speedX, 0);
			}
			_transform.position = _currentPos;
		}

		//Move Back
		if (Input.GetKey (KeyCode.LeftArrow)) {		
			_currentPos = _transform.position;
			if (_currentPos.x > startX) {
				_currentPos -= new Vector2 (speedX+2, 0);
			}
			_transform.position = _currentPos;
		}
		
	}
}
