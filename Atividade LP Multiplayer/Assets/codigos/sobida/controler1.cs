using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controler1 : MonoBehaviour
{
    public CharacterController2D controle;
    public float veloc = 5f;
    float movimento = 0f;
    
   
    void Update()
    {
		movimento = Input.GetAxisRaw("Horizontal") * veloc;

    }

	void FixedUpdate()
	{
		controle.Move(movimento * Time.fixedDeltaTime, false, false);
	}
}
