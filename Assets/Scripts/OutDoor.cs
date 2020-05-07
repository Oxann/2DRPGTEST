using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OutDoor : MonoBehaviour
{
    private BoxCollider2D OpeningCollider;
    private Text InfoText;
    private bool isActive = false;

    // Start is called before the first frame update
    void Start()
    {
        OpeningCollider = GetComponent<BoxCollider2D>();
        InfoText = GameObject.Find("Door Info").GetComponent<Text>(); ;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O) && isActive)
        {
            FindObjectOfType<MusicPlayer>().Play(MusicPlayer.DarkAmbient, 0.22f);
            SceneManager.LoadScene("Ladder Scene");
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
