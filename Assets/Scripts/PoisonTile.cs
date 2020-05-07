using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PoisonTile : MonoBehaviour
{
    //Cache
    private BoxCollider2D GirlFeetCollider;

    private void Start()
    {
        GirlFeetCollider = GameObject.Find("Girl Feet").GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if(otherCollider == GirlFeetCollider)
        {
            SceneManager.LoadScene("Ladder Scene");
        }
    }
}
