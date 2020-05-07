using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    //Cache
    private AudioClip BornSFX;
    private AudioClip StableSFX;

    // Start is called before the first frame update
    void Start()
    {
        BornSFX = Resources.Load("Audio/Effects/ghost") as AudioClip;
        StableSFX = Resources.Load("Audio/Effects/ghost") as AudioClip;
        AudioSource.PlayClipAtPoint(BornSFX,transform.position);
    }

    private void DestroyMe()
    {
        Destroy(gameObject);
    }
}
