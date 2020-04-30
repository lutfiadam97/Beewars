using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
	public float speed = 20f;
	public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
    	if(col.gameObject.tag == "walls" || col.gameObject.tag == "Enemy" || col.gameObject.tag == "Bee")
    	{
    		this.gameObject.SetActive(false);
    	}
    	else if(col.gameObject.tag == "Honey")
    	{
    		this.gameObject.SetActive(true);
    	}
    }
}
