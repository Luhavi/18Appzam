using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buning : MonoBehaviour
{
    float Gauge = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Gauge += Time.deltaTime;
        Gauge = Mathf.Clamp(Gauge + 0.1f, 0, 1);
    }
}
