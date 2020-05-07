using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    private Animator GhostAnimator;
    private int LifeCount = 3;
    private GirlAttack GirlAttackComponent;

    private void Start()
    {
        GhostAnimator = FindObjectOfType<Ghost>().GetComponent<Animator>();
        GirlAttackComponent = FindObjectOfType<GirlAttack>();
    }

    private void Update()
    {
        if(LifeCount == 0)
        {
            var GhostTransform = GhostAnimator.transform;
            GhostAnimator.SetBool("IsHeartDestroyed", true);
            Instantiate(Resources.Load("Prefab/Boy"), GhostTransform.position,Quaternion.Euler(0.0f,180.0f,0.0f));            
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision == GirlAttackComponent.SwordTrigger)
        {
            LifeCount--;
        }
    }

    private void OnDestroy()
    {
        GameObject.Find("Speech Bubble").SetActive(false);
        Camera.main.GetComponent<Animator>().enabled = true;
        FindObjectOfType<MusicPlayer>().Play(Resources.Load("Audio/Music/Love") as AudioClip);
    }
}
