using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Gmae_Start()
    {
        SceneManager.LoadScene("Play");
    }

    public void Gmae_Explanation()
    {
        
        Instantiate(Resources.Load("Prefab/Explanation_Canvas"), new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void Gmae_Credit()
    {
        Instantiate(Resources.Load("Prefab/Credit_Canvas"), new Vector3(0, 0, 0), Quaternion.identity);
    }

    public void Gmae_End()
    {
        Application.Quit();
    }

    public void Gmae_Close()
    {
        Destroy(this.gameObject);
    }

    public void Gmae_Main()
    {
        SceneManager.LoadScene("UI");
    }
}
