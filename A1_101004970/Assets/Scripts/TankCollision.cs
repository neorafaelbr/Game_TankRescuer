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
