using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public GameObject outro;
    private void OnCollisionEnter2D(Collision2D bateu)
    {
        if(bateu.transform.tag == "inimugo")
        {
            variaveis.acabou = true;
            gameObject.SetActive(false);
            outro.SetActive(false);

        }

    }

}
