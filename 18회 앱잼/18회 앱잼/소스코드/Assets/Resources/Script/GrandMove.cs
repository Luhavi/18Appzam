using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandMove : MonoBehaviour
{
    public float speed = 0.1f;
    public float maxTop = 4.3f;
    public float minBot = -4.3f;
    float Top;
    float Bot;
    int state = 0;


    // Start is called before the first frame update
    void Start()
    {
        Top = Random.Range(0, maxTop + 1);
        Bot = Random.Range(minBot, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer.playerHeart > 0)
        {
            if (state == 0)
            {
                transform.Translate(0, speed, 0);
                if (transform.position.y >= Top)
                {
                    state = 1;
                    Top = Random.Range(0, maxTop + 1);
                }
            }
            else if (state == 1)
            {
                transform.Translate(0, -speed, 0);
                if (transform.position.y <= Bot)
                {
                    state = 0;
                    Bot = Random.Range(minBot, 1);
                }
            }
        }
    }
}
