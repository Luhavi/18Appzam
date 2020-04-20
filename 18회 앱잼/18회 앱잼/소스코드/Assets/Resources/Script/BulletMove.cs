using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    
    public float speed = 0.1f;
    public GameObject GrandFaSound;
    public GameObject GrandMaSound;
    public GameObject PlayerSound;
    int state;

    GameObject Player;
    Vector3 Dir;
    PlayerMove PM;
    Timer SM;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        PM = Player.gameObject.GetComponent<PlayerMove>();
        SM = Player.gameObject.GetComponent<Timer>();
        Dir = (Player.transform.position - transform.position).normalized;
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(state == 0)
        {
            transform.Translate(Dir * speed);
        }else if(state == 1)
        {
            transform.Translate(speed, 0, 0);
        }
        else if (state == 2)
        {
            transform.Translate(-speed, 0, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Destroyer")
        {
            Destroy(this.gameObject);
        }
        else if (other.tag == "Player")
        {
            Instantiate(PlayerSound);
            Timer.playerHeart--;
            Destroy(this.gameObject);
        }
        else if (other.tag == "PlayerBat")
        {
            speed = 0.3f;
            state = PM.playerDir;
        }
        else if (other.tag == "GrandMa")
        {
            if(state == 1 || state == 2)
            {
                Instantiate(GrandMaSound);
                Timer.hitcount++;
                Destroy(this.gameObject);
            }
        }
        else if (other.tag == "GrandFa")
        {
            if (state == 1 || state == 2)
            {
                Instantiate(GrandFaSound);
                Timer.hitcount++;
                Destroy(this.gameObject);
            }
        }
    }
}
