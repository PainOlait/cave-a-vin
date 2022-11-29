using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footer : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> footers = null;

    public void Initialize(int _index)
    {
        for (int i = 0; i < footers.Count; i++)
        {
            if (i == _index)
                footers[i].SetActive(true);
            else
                footers[i].SetActive(false);
        }
    }

    public void ShowFooter(int _index)
    {
        for (int i = 0; i < footers.Count; i++)
        {
            if (i == _index)
            {
                footers[i].SetActive(true);
            }
            else
            {
                footers[i].SetActive(false);
            }
        }
    }
}
