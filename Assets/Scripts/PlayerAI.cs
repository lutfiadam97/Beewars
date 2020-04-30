using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAI : MonoBehaviour
{
    public float speed;
    public float jarakngejar;
    public Rigidbody2D rb;
    public Transform enemyBee;
    public Transform Honey;
    // Start is called before the first frame update
    void Start()
    {
        Honey = GameObject.FindGameObjectWithTag("Honey").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Honey.position) < jarakngejar)
        {
            transform.position = Vector2.MoveTowards(transform.position, Honey.position, speed * Time.deltaTime);
        }

        if (rb.velocity.x >= 0.01f)
        {
        	enemyBee.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if(rb.velocity.x <= -0.01f)
        {
        	enemyBee.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
    	if(col.gameObject.GetComponent<Rigidbody2D>() == null)
    	return;
    }
}
