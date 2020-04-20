using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Manger_Touch : MonoBehaviour
{
    public bool Loop_sound;

    float ClipSoundLength;

    // Use this for initialization
    void Awake()
    {

    }

    void Start()
    {
        GetComponent<AudioSource>().Play();
        ClipSoundLength = GetComponent<AudioSource>().clip.length;
        if(Loop_sound == true)
        {
            GetComponent<AudioSource>().loop = true;
        }
        else
        {
            StartCoroutine(Destroy_Object());
        }
    }
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Destroy_Object()
    {   //IEnumerator 정지가능, yield return new WaitForSeconds = IEnumerator 시간동안 기달려라
        yield return new WaitForSeconds(ClipSoundLength);
        Destroy(this.gameObject);
    }
}
