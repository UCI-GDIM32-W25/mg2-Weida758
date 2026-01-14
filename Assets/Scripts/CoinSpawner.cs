using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField] private GameObject coinPrefab;
    private float timeForNextSpawn = 0;

    private void SpawnCoin()
    {
        GameObject newCoin = Instantiate(coinPrefab, transform.position, transform.rotation);
        timeForNextSpawn = Random.Range(0.5f, 2f);
    }

    private void Update()
    {
        timeForNextSpawn -= Time.deltaTime;

        if (timeForNextSpawn <= 0f)
        {
            SpawnCoin();
        }
    }
    
    
}
