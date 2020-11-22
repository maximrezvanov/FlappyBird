using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusSpawner : MonoBehaviour
{
    public List<Transform> spawnPoints = new List<Transform>();
    public List<GameObject> ItemPrefabs = new List<GameObject>();
    public int amountItems = 3;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpawnBonus();

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
