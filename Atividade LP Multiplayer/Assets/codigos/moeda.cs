using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moeda : MonoBehaviour
{
	private float coins = 0;
	
	private void OnTriggerEnter2D(Collider2D coin)
	{
		if (coin.transform.tag == "moedinha")
		{
			Destroy(coin.gameObject);
		}

	}
}
