using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoySpeak : MonoBehaviour
{
    private GameObject SpeechBubble;
    private Text InfoText;
    private bool isActive = false;
    private const string BoySpeechText = "HAHAHAHA";

    // Start is called before the first frame update
    void Start()
    {
        InfoText = GameObject.Find("Boy Info").GetComponent<Text>();
        SpeechBubble = GameObject.Find("Speech Bubble");        
    }

    private void Update()
    {
        if (!SpeechBubble.activeSelf && Input.GetKeyDown(KeyCode.O) && isActive)
        {
            SpeechBubble.SetActive(true);
            SpeechBubble.transform.GetComponentInChildren<Text>().text = BoySpeechText;
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
}
