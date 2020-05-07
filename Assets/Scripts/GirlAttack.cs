using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlAttack : MonoBehaviour
{
    public GameObject Sword { private set; get; }
    public SpriteRenderer SwordRenderer { private set; get; }
    public PolygonCollider2D SwordTrigger { private set; get; }
    private Animator _Animator;
    public bool IsAttacking { get; set; } = false;
    float AttackDelayTime = 0.1f;
    float AttackDelayTimeCounter = 0.0f;

    private void Start()
    {
        Sword = transform.GetChild(1).gameObject;
        SwordRenderer = Sword.transform.GetComponentInChildren<SpriteRenderer>();
        SwordTrigger = Sword.GetComponent<PolygonCollider2D>();
        _Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if(!IsAttacking)
        {
            AttackDelayTimeCounter += Time.deltaTime;
        }
        if(Sword.activeSelf && AttackDelayTimeCounter >= AttackDelayTime)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }            
        }     
    }

    private void EndAttack()
    {
        IsAttacking = false;
        SwordRenderer.enabled = true;
        _Animator.SetBool("IsAttacking", IsAttacking);
    }

    private void Attack()
    {
        AttackDelayTimeCounter = 0.0f;
        IsAttacking = true;
        SwordRenderer.enabled = false;
        _Animator.SetBool("IsAttacking", IsAttacking);
    }
}
