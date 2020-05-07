using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cabinet : MonoBehaviour
{
    private Text InfoText;
    private GameObject Girl;
    private bool isActive = false;

    private float hidingTimeCounter = 0.0f;
    public bool IsHiding { get; set; } = false;

    private void Start()
    {
        Girl = GameObject.Find("Girl");
        InfoText = GameObject.Find("Cabinet Info").GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && !IsHiding && isActive)
        {
            Hide();
        }
        else
        {
            if (IsHiding)
            {
                hidingTimeCounter += Time.deltaTime;
            }
            if (IsHiding && Input.GetKeyDown(KeyCode.O) && hidingTimeCounter >= .1f)
            {
                Expose();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        InfoText.enabled = true;
        isActive = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        InfoText.enabled = false;
        isActive = false;
    }

    private void Hide()
    {
        Girl.SetActive(false);
        IsHiding = true;
    }

    private void Expose()
    {
        Girl.SetActive(true);
        IsHiding = false;
        hidingTimeCounter = 0.0f;
    }
}
