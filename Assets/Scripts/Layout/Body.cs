using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    [SerializeField]
    private List<ContentSection> pages = null;

    private float currentIndex;

    public void Initialize(int _index)
    {
        for (int i = 0; i < pages.Count; i++)
        {
            pages[i].Initialize();
        }
        ShowPageContent(_index);
    }

    public void ShowPageContent(int _index)
    {
        currentIndex = _index;
        for (int i = 0; i < pages.Count; i++)
        {
            if (i == currentIndex)
            {
                pages[i].Show();
            }
            else
            {
                pages[i].Hide();
            }
        }
    }
}
