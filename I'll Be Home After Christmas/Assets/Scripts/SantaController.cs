using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SantaController : MonoBehaviour {

    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        rb2d = this.gameObject.GetComponent<Rigidbody2D>();
        //rb2d.velocity = new Vector2 (5.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
        //rb2d.AddForce(new Vector2(5.0f, 0.0f));
        rb2d.velocity = new Vector2(5.0f, 0.0f);

        float upForce = Input.GetAxis("Vertical");
        rb2d.AddForce(new Vector2(0.0f, upForce * 50.0f));
    }
}
