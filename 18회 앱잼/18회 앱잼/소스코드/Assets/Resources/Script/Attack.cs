using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    PlayerMove PM;
    GameObject Player;
    GameObject Effect;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        PM = Player.GetComponent<PlayerMove>();
        if (PM.playerDir == 2)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        Destroy(this.gameObject, 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        Effect = GameObject.Find("Effect");
        transform.position = Effect.transform.position;
    }
}
