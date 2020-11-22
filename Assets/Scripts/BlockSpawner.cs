using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockSpawner : MonoBehaviour
{
    public float period = 1f;
    private float preTime = 0f;
    [SerializeField] GameObject block;
    [SerializeField] GameObject block1;
    [SerializeField] GameObject block2;


    [SerializeField] float speedRespawn;

   



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
            GameObject newBlock = Instantiate(block, transform);
            newBlock.GetComponent<Block>().speed = speedRespawn;

            GameObject newBlock1 = Instantiate(block1, transform);
            newBlock1.GetComponent<Block>().speed = speedRespawn;

            GameObject newBlock2 = Instantiate(block2, transform);
            newBlock2.GetComponent<Block>().speed = speedRespawn;

            preTime = Time.time;
            Destroy(newBlock, 10);
        }
    }
    

   
   
}
