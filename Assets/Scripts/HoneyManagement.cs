using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyManagement : MonoBehaviour
{

	public void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.GetComponent<Rigidbody2D>() == null)
		return;

		if(col.gameObject.tag == "Bee")
		{
			ScoreManager.honeyValue += 1;
			Destroy(gameObject);
		}
		
	}

}
