using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moeda : MonoBehaviour
{
	public Text pontos;
	public float numpontos;
	public GameObject tela, player, outro; 


	void Start()
	{
		numpontos = 0;
		pontos.text = "Pontos: " +numpontos;

	}
	void Update()
	{
		if (numpontos == 8)
		{
			tela.SetActive(true);
			player.SetActive(true);
			gameObject.SetActive(false);
			outro.SetActive(false);

		}

	}

	private void OnTriggerEnter2D(Collider2D coin)
	{
		if (coin.tag == "moedinha")
		{
			numpontos ++;
			Destroy(coin.gameObject);
			pontos.text = "Pontos: " +numpontos;
		}

	}
	
}
