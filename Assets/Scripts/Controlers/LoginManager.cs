using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginManager : MonoBehaviour
{
    [SerializeField]
    private GUI gUI = null;

    public void Login()
    {
        gUI.OpenMEnu();
    }

}
