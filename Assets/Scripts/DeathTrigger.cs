using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	private Player player1;
	private Player2 player2;

	void Start() {
		player1 = GameObject.FindGameObjectWithTag ("Player1").GetComponent<Player>();
		player2 = GameObject.FindGameObjectWithTag ("Player2").GetComponent<Player2>();
	}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.CompareTag ("Player1DeathCheck")) {
			player1.Die ();
		} else if (col.CompareTag ("Player2DeathCheck")) {
			player2.Die ();
		}
	}
}
