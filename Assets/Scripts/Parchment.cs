using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parchment : MonoBehaviour
{
    private Rigidbody2D GirlBody;
    private Text InfoText;
    private bool isActive = false;
    [SerializeField] private GameObject DisplayingParchment = null;
    float displayTimeCounter = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        GirlBody = GameObject.Find("Girl").GetComponent<Rigidbody2D>();
        InfoText = GameObject.Find("Parchment Info").GetComponent<Text>();    
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && isActive)
        {
            DisplayingParchment.SetActive(true);
            GirlBody.simulated = false;
        }
        else if (DisplayingParchment.activeSelf)
        {
            displayTimeCounter += Time.deltaTime;
            if (displayTimeCounter >= 0.2f && Input.GetKeyDown(KeyCode.O))
            {
                DisplayingParchment.SetActive(false);
                GirlBody.simulated = true;
                displayTimeCounter = 0.0f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        InfoText.enabled = true;
        isActive = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        InfoText.enabled = false;
        isActive = false;
    }
}
