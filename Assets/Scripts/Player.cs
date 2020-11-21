using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rbb;
    public float force;


    void Start()
    {
        rbb = GetComponent<Rigidbody2D>();
    }



    void Update()
    {
        Control();
    }

    void Control()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rbb.AddForce(Vector2.up * force * Time.deltaTime, ForceMode2D.Impulse);
        }
    }

    
}
