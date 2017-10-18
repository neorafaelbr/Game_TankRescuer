/*
Source File Name: TankCollision.cs;
Author's Name: Rafael Sanches Carvalho;
Program Description: This script controls the User Interface elements, by showing, hiding and updating life and scores; 
Last Modified by: Autor;
Date last Modified: 15/Oct/2017;
Revision History: 
->15/Oct/2017 - Inclusion of Header;
->13/Oct/2017 - Inclusion of the link with UI logic to lose life and/or increase score;
->12/Oct/2017 - Inclusion of sound effects;
->11/Oct/2017 - Creation of the file;
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCollision : MonoBehaviour {

	[SerializeField]
	private GameController gameController;

	[SerializeField]
	private AudioClip explosion;

	[SerializeField]
	private AudioSource explosionSource;

	[SerializeField]
	private AudioClip rescued;

	[SerializeField]
	private AudioSource rescuedSource;

	//When Tank touches on enemies and/or soldiers this method controls what should happen next
	public void OnTriggerEnter2D(Collider2D other){
	
		if (other.gameObject.tag.Equals ("enemy")) {
			Debug.Log ("Kabum!\n");
			explosionSource.clip = explosion;
			explosionSource.Play();
			Collider2D thisObj = other.GetComponent<Collider2D>();
			thisObj.GetComponent<EnemyController> ().Reset();
			gameController.Life -= 1;

		}

		if (other.gameObject.tag.Equals ("soldier")) {
			Debug.Log ("Saved a Soldier!\n");
			rescuedSource.clip = rescued;
			rescuedSource.Play();
			Collider2D thisObj = other.GetComponent<Collider2D>();
			thisObj.GetComponent<SoldierController> ().Reset();
			gameController.Score += 15;
		}
	}
}
