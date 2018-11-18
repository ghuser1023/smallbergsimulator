using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallbergController : MonoBehaviour {
    private Rigidbody2D rb2d;
    private float angerstart = -20;
    public float speed;
    Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {
            anim.SetBool("angry", true);
            angerstart = Time.time;
        }
        if (Time.time - 1.5 > angerstart) {
            anim.SetBool("angry", false);
        }
	}

    private void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        anim.SetFloat("dir", moveHorizontal);
        transform.Translate((new Vector3(moveHorizontal, moveVertical, 0)) * speed);
    }
}
