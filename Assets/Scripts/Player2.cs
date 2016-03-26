using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {

	public float maxSpeed = 3;
	public float speed = 50f;
	public float jumpPower = 200f;

	public bool grounded;

	private Rigidbody2D rb2d;
	private Animator anim;

	// Stats
	int curHealth = 0;
	int lives = 3;

	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.GetComponent<Animator> ();
	}


	void Update() {

		anim.SetBool ("Grounded", grounded);
		anim.SetFloat ("Speed", Mathf.Abs(Input.GetAxis("Horizontal2")));

		if (Input.GetAxis ("Horizontal2") < -0.1f) {
			transform.localScale = new Vector3 ((float)1.45, (float)1.5, (float)1.0);
		}

		if (Input.GetAxis ("Horizontal2") > 0.1f) {
			transform.localScale = new Vector3 ((float)-1.45, (float)1.5, (float)1.0);
		}

		if (Input.GetButtonDown ("Jump2")) {
			rb2d.AddForce (Vector2.up * jumpPower);
		}
	}

	void FixedUpdate () {

		float h = Input.GetAxis ("Horizontal2");

		rb2d.AddForce ((Vector2.right * speed) * h);

		//limits speed
		if (rb2d.velocity.x > maxSpeed) {
			rb2d.velocity = new Vector2 (maxSpeed, rb2d.velocity.y);
		}

		if (rb2d.velocity.x < -maxSpeed) {
			rb2d.velocity = new Vector2 (-maxSpeed, rb2d.velocity.y);
		}
	}

	public void Die() {
		rb2d.velocity = new Vector3 (0, 0, 0);
		transform.position = new Vector3 (1, 1, 1);
		curHealth = 0;
		lives -= 1;
	}
}
