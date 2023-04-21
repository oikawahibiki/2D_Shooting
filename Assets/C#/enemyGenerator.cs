using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyGenerator : MonoBehaviour
{
    public GameObject enemyprefab;
    void Start()
    {
        InvokeRepeating("spawn", 2f, 1f);
        Instantiate(
            enemyprefab, transform.position,
            transform.rotation
            );
    }
    void spawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-9.5f, 9.5f),
            transform.position.y,
            transform.position.z
            );
        Instantiate(
            enemyprefab,
            spawnPosition,
            transform.rotation
            );
    }
}
