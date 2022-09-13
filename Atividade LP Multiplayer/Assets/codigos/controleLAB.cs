using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controleLAB : MonoBehaviour
{
	public float veloc = 5;
	public Rigidbody2D corpo;
	Vector2 mover;
   
    void Update()
    {
		mover.x = Input.GetAxisRaw("Horizontal");
		mover.y = Input.GetAxisRaw("Vertical");
    }

	void FixedUpdate()
	{
		corpo.MovePosition(corpo.position + mover * veloc * Time.fixedDeltaTime);
	}
}
