using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);   
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Ladder Scene")
        {
            Destroy(gameObject);
        }
    }
}
