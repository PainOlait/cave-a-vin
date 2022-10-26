using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public GameObject landingPage;
    public GameObject mainPage;

    List<DataBase> dataBases;
    List<UserData> userDatas;

    private void Awake()
    {
        userDatas.Add(FindObjectOfType<UserData>());
    }

    public void Login()
    {
        landingPage.SetActive(false);
        mainPage.SetActive(true);
    }
}
