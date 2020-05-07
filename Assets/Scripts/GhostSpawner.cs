using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{
    private bool isSpawned = false;
    private GameObject Ghost;

    // Start is called before the first frame update
    void Start()
    {
        Ghost = Resources.Load("Prefab/First Ghost") as GameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isSpawned)
        {
            Instantiate(Ghost, transform.position, Quaternion.identity);
            isSpawned = true;
        }
    }
}
