using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dimas : MonoBehaviour
{
    public Text pontos;
	public float numpontos;
	public GameObject tela, player, outro; 


	void Start()
	{
		numpontos = 0;
		pontos.text = "Rosa: " +numpontos;

	}
	void Update()
	{
		if (numpontos == 3)
		{
			tela.SetActive(true);
			player.SetActive(true);
			gameObject.SetActive(false);
			outro.SetActive(false);

		}

	}

	private void OnTriggerEnter2D(Collider2D point)
	{
		if (point.tag == "poligo")
		{
			numpontos ++;
			Destroy(point.gameObject);
			pontos.text = "Rosa: " +numpontos;
		}

	}
}
