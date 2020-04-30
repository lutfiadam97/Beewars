using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed;
    public float jarakngejar;
    public Rigidbody2D rb;
    public Transform enemyTawon;

    public Transform Bee;
    public Transform BeeAi;
    // Start is called before the first frame update
    void Start()
    {
        Bee = GameObject.FindGameObjectWithTag("Bee").transform;
        BeeAi = GameObject.FindGameObjectWithTag("BeeAI").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, Bee.position) < jarakngejar)
        {
            transform.position = Vector2.MoveTowards(transform.position, Bee.position, speed * Time.deltaTime);
        }
        else if (Vector2.Distance(transform.position, BeeAi.position) < jarakngejar)
        {
        	transform.position = Vector2.MoveTowards(transform.position, BeeAi.position, speed * Time.deltaTime);
        }

        if (rb.velocity.x >= 0.01f)
        {
        	enemyTawon.localScale = new Vector3(-2f, 2f, 2f);
        }
        else if(rb.velocity.x <= -0.01f)
        {
        	enemyTawon.localScale = new Vector3(2f, 2f, 2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
    	if(col.gameObject.GetComponent<Rigidbody2D>() == null)
    	return;
    }
}
