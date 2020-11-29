using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{

    private SpriteRenderer sprite;
    private BoxCollider2D bgCollider;
    private float scrollSpeed = 1.5f;
    private float groundHorizontalLength;
    private Rigidbody2D rb;
    public GameObject GoCollider;
    //public Vector2 oldPosition;




    void Awake()
    {
        //runInEditMode = true;
        bgCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = bgCollider.size.x;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(-scrollSpeed, 0);

        if (transform.position.x < -groundHorizontalLength)
        {
            //If true, this means this object is no longer visible and we can safely move it forward to be re-used.
            RepositionBackground();
        }
    }

    private void RepositionBackground()
    {
        //transform.position = oldPosition;
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);

        transform.position = (Vector2)transform.position + groundOffSet;

    }

}
