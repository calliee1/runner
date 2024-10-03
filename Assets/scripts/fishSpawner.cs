using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;

    public Vector2 fishOffset = new Vector2(0, 1);

    void Start()
    {
        SpawnFish(); 
    }

    
    void SpawnFish()
    {
        Vector3 fishPosition = transform.position + (Vector3)fishOffset;

        Instantiate(fishPrefab, fishPosition, Quaternion.identity);
    }
}
