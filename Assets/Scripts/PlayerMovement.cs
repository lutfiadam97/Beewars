using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
	public float moveSpeed = 20f;
	public Rigidbody2D rb;
	public Animator animator;
	Vector2 movement;
	//private bool facingRight = true;

	void Start()
	{
		
	}

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
    }

    void FixedUpdate()
    {
    	rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }


    public void OnCollisionEnter2D(Collision2D col)
    {
    	if(col.gameObject.tag == "Enemy")
    	{
    		FindObjectOfType<AudioManager>().Play("PlayerDeath");
    		GameControlScript.health -= 1;	
    	}
    }
}
