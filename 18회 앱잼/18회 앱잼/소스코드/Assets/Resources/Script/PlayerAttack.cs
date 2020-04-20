using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackCool = 0.5f;
    bool canAttack = true;
    public GameObject attackEffect;
    public Animator anim;
    public float isAnim = 0;


// Start is called before the first frame update
void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.playerHeart > 0)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (canAttack)
                {
                    if (anim != null)
                    {
                        isAnim = 0.5f;
                        anim.SetInteger("AnimState", 1);
                    }
                    Instantiate(attackEffect, transform.position, Quaternion.identity);
                    canAttack = false;
                    attackCool = 0.5f;
                    StartCoroutine(Attack());
                }
            }
            if (isAnim > 0)
            {
                isAnim -= Time.deltaTime;
            }
            if (isAnim < 0)
            {
                anim.SetInteger("AnimState", 0);
            }
        }
    }
    IEnumerator Attack()
    {
        while (attackCool > 0)
        {
            attackCool -= Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
        if (attackCool < 0)
        {
            canAttack = true;
        }
    }
}
