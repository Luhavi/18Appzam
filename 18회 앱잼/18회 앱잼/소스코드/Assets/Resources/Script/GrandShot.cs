using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrandShot : MonoBehaviour
{
    public GameObject[] Bullet;
    public float waitTime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shot());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Shot()
    {
        while (true)
        {
            if(Timer.playerHeart > 0)
            {
                Instantiate(Bullet[Random.Range(0, Bullet.Length)], transform.position, Quaternion.identity);
                yield return new WaitForSeconds(waitTime);
            }
        }
    }
}
