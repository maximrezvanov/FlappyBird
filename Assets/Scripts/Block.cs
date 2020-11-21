using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Block : MonoBehaviour
{
    public float speed;
    private float dy;


    private void Start()
    {
        dy = Random.Range(-0.45f, 1.2f);
        transform.position = new Vector3(transform.position.x, transform.position.y + dy, transform.position.z);


    }
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);

    }

      

}
