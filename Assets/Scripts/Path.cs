using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Path : MonoBehaviour
{
    public Button StartBtn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BtnStart()
    {
        SceneManager.LoadScene("game");
    }
}
