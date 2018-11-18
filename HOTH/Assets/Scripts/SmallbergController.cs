using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallbergController : MonoBehaviour {
    public float speed;
    Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        anim.SetFloat("dir", moveHorizontal);
        transform.Translate((new Vector3(moveHorizontal, moveVertical, 0)) * speed);
    }
}
