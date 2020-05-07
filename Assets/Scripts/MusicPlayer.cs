using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    //Cache
    private AudioSource _AudioSource;

    //Audio Clips
    static public AudioClip Rain;
    static public AudioClip DarkAmbient;


    // Start is called before the first frame update
    void Start()
    {
        Rain = Resources.Load("Audio/Effects/Rain") as AudioClip;
        DarkAmbient = Resources.Load("Audio/Music/DarkAmbient") as AudioClip;
        _AudioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
        Play(Rain, 1.0f);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("down" + Time.time.ToString());
        }
        if (Input.GetKeyUp(KeyCode.Space) && Input.GetKeyUp(KeyCode.Return))
        {
            Debug.Log("up" + Time.time.ToString());
        }
    }

    public void Play(AudioClip clip,float volume = 0.5f)
    {
        SetVolume(volume);
        SetAudioClip(clip);
        _AudioSource.Play();
    }

    public void SetVolume(float volume)
    {
        if (volume > 1.0f) _AudioSource.volume = 1.0f;
        else if (volume < 0.0f) _AudioSource.volume = 0.0f;
        else _AudioSource.volume = volume;
    }

    public void SetAudioClip(AudioClip clip)
    {
        _AudioSource.clip = clip;
    }
}
