using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSizescript : MonoBehaviour {

    public int TextSize;
    float StandardScrren = 1080;

    // Use this for initialization
    void Start () {
       GetComponent<Text>().fontSize = Mathf.RoundToInt(TextSize * (Screen.height / StandardScrren));
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
