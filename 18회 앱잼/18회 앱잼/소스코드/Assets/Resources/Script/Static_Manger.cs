using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Static_Manger : MonoBehaviour {

    static public GameObject BGM_Object;
    /*static public float BGM_BgSoundVolume = 0.5f;
    static public float BGM_TouchSoundVolume = 0.5f;
    static public bool BGM_SoundOff;*/

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    static public void PlayBGM(int Num)
    {
        Instantiate(Resources.Load<GameObject>("BGM_Prefeb/BGM_" + Num.ToString()), new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    static public void PlayBGM_Touch(int Num)
    {
        Instantiate(Resources.Load<GameObject>("BGM/BGM_Touch_" + Num.ToString()), new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    /*static public GameObject Loop_BGM;
    static public void PlayBGM_Touch_Loop(int Num)
    {
        BGM_Manger_Touch Sound_Script;
        Loop_BGM = Instantiate(Resources.Load<GameObject>("BGM_Touch/BGM_Touch_" + Num.ToString()), new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        Sound_Script = Loop_BGM.transform.gameObject.GetComponent<BGM_Manger_Touch>();
        Sound_Script.Loop_sound = true;
    }*/

    /*static public void Save_Option_data()   //전에 했던 사운드를 저장
    {
        PlayerPrefs.SetFloat("BGM_BgSoundVolume", BGM_BgSoundVolume);
        PlayerPrefs.SetFloat("BGM_TouchSoundVolume", BGM_TouchSoundVolume);
    }

    static public void Load_Option_data()   //저장한 사운드 가져오기
    {
        BGM_BgSoundVolume = PlayerPrefs.GetFloat("BGM_BgSoundVolume");
        BGM_TouchSoundVolume = PlayerPrefs.GetFloat("BGM_TouchSoundVolume");
    }*/
}
