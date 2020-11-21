using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
    public float period = 1f;
    private float preTime = 0f;
    [SerializeField] GameObject block;
    [SerializeField] GameObject block1;

    [SerializeField] float speedRespawn;

    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> ItemPrefabs = new List<GameObject>();
    public int amountItems = 3;



    void Start()
    {
        preTime = Time.time - period * 2f;
        SpawnBonus();

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

            //GameObject _ = Instantiate(block1, transform);
            //newBlock.GetComponent<Block>().speed = speedRespawn;

            preTime = Time.time;
            Destroy(newBlock, 10);
        }
    }
    

   
    public void SpawnBonus()
    {
        for (int i = 0; i < amountItems; i++)
        {
            Transform spawnPoint = GetRandomSpawnPoint();
            GameObject bonusItem = SpawnItem(spawnPoint);

            Destroy(bonusItem, 10);
        }
    }

    private Transform GetRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Count)];
    }

    private GameObject SpawnItem(Transform spawnPoint)
    {
        var prefab = ItemPrefabs[Random.Range(0, ItemPrefabs.Count)];
        return Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
