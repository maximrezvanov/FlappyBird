using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockSpawner : MonoBehaviour
{
    public float period = 1f;
    private float preTime = 0f;
    public GameObject block;
    public GameObject block1;
    public GameObject block2;


    [SerializeField] float speedRespawn = 0f;



    void Start()
    {
        preTime = Time.time - period * 2f;

    }

    void Update()
    {
        BlockSpawn();

    }

    public void BlockSpawn()
    {
        if (Time.time - preTime >= period)
        {
            Spawn(block);
            Spawn(block1);
            Spawn(block2);


            preTime = Time.time;
        }
    }

    private void Spawn(GameObject gameObject)
    {
        gameObject = Instantiate(gameObject, transform);
        gameObject.GetComponent<Block>().speed = speedRespawn;
        Destroy(gameObject, 20);
    }

   
   
}
