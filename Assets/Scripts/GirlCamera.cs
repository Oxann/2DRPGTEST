using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GirlCamera : MonoBehaviour
{
    private Transform Girl; 

    // Start is called before the first frame update
    void Start()
    {
        Girl = GameObject.Find("Girl").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowGirl();
    }

    void FollowGirl()
    {
        var GirlPosition = Girl.position;
        transform.position = new Vector3(GirlPosition.x, GirlPosition.y, transform.position.z);
    }
}
