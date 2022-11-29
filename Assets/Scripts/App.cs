using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    private void Start()
    {
        Debug.Log("App is running at " + Screen.currentResolution);
    }

    

        
}
