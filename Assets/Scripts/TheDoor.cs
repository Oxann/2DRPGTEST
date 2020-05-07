using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TheDoor : MonoBehaviour
{
    private Text Info;
    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        Info = GameObject.Find("The Door Info").GetComponent<Text>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && isActive)
        {
            SceneManager.LoadScene("End Scene");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Info.enabled = true;
        isActive = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Info.enabled = false;
        isActive = false;
    }
}
