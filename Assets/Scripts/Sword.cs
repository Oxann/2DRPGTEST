using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    GirlAttack _GirlAttack;
    private bool isActive = false;

    private void Start()
    {
        _GirlAttack = FindObjectOfType<GirlAttack>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && isActive)
        {
            _GirlAttack.Sword.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isActive = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isActive = false;
    }
}
