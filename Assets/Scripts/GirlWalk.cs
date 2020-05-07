using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlWalk : MonoBehaviour
{
    private Animator _Animator;
    private Rigidbody2D Body;

    public bool IsWalking { get; set; } = false;
    public float Speed { get; set; } = 3.0f;

    private Quaternion WalkingLeft; 
    private Quaternion WalkingRight; 

    // Start is called before the first frame update
    void Start()
    {
        _Animator = GetComponent<Animator>();
        Body = GetComponent<Rigidbody2D>();
        WalkingLeft = Quaternion.Euler(0.0f, 180.0f, 0.0f);
        WalkingRight = Quaternion.Euler(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetButton("Horizontal") || Input.GetButton("Vertical"))
         {
             IsWalking = true;
             var HorizontalAxis = Input.GetAxis("Horizontal");

             if (HorizontalAxis < 0.0f)
             {
                 transform.rotation = WalkingLeft;
             }
             else if (HorizontalAxis > 0.0f)
             {
                 transform.rotation = WalkingRight;
             }
         }
         else IsWalking = false;
        _Animator.SetBool("IsWalking", IsWalking);
    }

    private void FixedUpdate()
    {
        Body.MoveRotation(0.0f);
        Body.velocity = Vector2.zero;
        if (IsWalking)
        {
            Walk();
        }
    }

    private void Walk()
    {
        var VerticalAxis = Input.GetAxis("Vertical");
        var HorizontalAxis = Input.GetAxis("Horizontal");

        var MovementVector = new Vector2(HorizontalAxis, VerticalAxis).normalized * Speed * Time.deltaTime;
        Body.MovePosition(Body.position + MovementVector);
    }
}
