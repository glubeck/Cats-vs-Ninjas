using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	public Player playerOne;
	public Player2 playerTwo;

	//void Start() {
		//player1 = GameObject.FindGameObjectWithTag ("Player1").GetComponent<Player>();
		//player2 = GameObject.FindGameObjectWithTag ("Player2").GetComponent<Player2>();
	//}

	void OnTriggerEnter2D(Collider2D col) {

		if (col.CompareTag ("Player1DeathCheck")) {
			playerOne.Die ();
		} else if (col.CompareTag ("Player2DeathCheck")) {
			playerTwo.Die ();
		}
	}
}
