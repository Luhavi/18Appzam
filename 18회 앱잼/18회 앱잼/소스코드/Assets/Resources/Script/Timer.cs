using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float Timerr = 0;
    public Text TimerText;
    public Text scoreText;
    public GameObject gameover;
    public GameObject gameoverText;
    static public int hitcount;
    public float totalTime;
    static public int playerHeart = 3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (playerHeart > 0)
        {
            Timerr += Time.deltaTime;
            TimerText.text = Timerr.ToString("F") + " 초";
            if (hitcount == 1)
            {
                totalTime += (int)(Timerr / 10);
                totalTime *= 2;
                hitcount = 0;
            }
        }else if(playerHeart == 0)
        {
            gameover.SetActive(true);
            gameoverText.SetActive(true);
            totalTime += Timerr;
            //playerHeart--;
            scoreText.text = totalTime.ToString("F") + " 초";
            Debug.Log(totalTime);
        }
    }
}
