using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast2 : MonoBehaviour
{
    public bool podePular;
    public float forcaPulo = 600f;

    void Update()
    {
        RaycastHit2D hit = 
        Physics2D.Raycast(transform.position, -Vector3.up, 5);

        if (hit.collider)
        {
            podePular = true;
        }

        else
        {
            podePular = false;

        }

        if (Input.GetButtonDown("Jump2"))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector3.up * forcaPulo);

        }
    }
}
