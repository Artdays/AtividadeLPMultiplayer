using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controle2 : MonoBehaviour
{
	public float veloc = 8;
	public Rigidbody2D corpo;
	Vector2 mover;

	void Update()
	{
		mover.x = Input.GetAxisRaw("Horizontal2");
		mover.y = Input.GetAxisRaw("Vertical2");
	}

	void FixedUpdate()
	{
		corpo.MovePosition(corpo.position + mover * veloc * Time.fixedDeltaTime);
	}
}
