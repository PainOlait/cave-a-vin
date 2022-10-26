using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginControl : MonoBehaviour
{

    public void Login()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }

}
