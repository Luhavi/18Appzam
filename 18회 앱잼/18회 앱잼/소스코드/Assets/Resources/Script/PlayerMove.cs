using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public float speed = 0.1f;
    public int playerDir = 0;
    public float dashCool = 3f;
    public bool canDash = true;
    public float isDash = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.playerHeart > 0)
        {
            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                playerDir = 1;
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (Input.GetAxisRaw("Horizontal") == -1)
            {
                playerDir = 2;
                transform.localScale = new Vector3(-1, 1, 1);
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                if (canDash)
                {
                    canDash = false;
                    isDash = 0.1f;
                    dashCool = 3;
                    StartCoroutine(Dash());
                }
            }
            if (isDash > 0)
            {
                isDash -= Time.deltaTime;
                speed = 0.3f;
            }
            else
            {
                speed = 0.1f;
            }
            transform.Translate(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed, 0);
        }
    }
    IEnumerator Dash()
    { 
        while (dashCool > 0)
        {
            dashCool -= Time.deltaTime;
            yield return new WaitForFixedUpdate();
        }
        if (dashCool < 0)
        {
            canDash = true;
        }
    }
}
