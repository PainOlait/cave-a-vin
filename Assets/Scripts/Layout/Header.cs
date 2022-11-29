using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Header : MonoBehaviour
{
    //[SerializeField]
    //private PageTexts textData;

    //[SerializeField]
    //private TMP_Text title = null;

    [SerializeField]
    private List<GameObject> texts = null;

    [SerializeField]
    private int defaultIndex = 0;

    private int currentIndex;

    public void Initialize(int _index)
    {
        for (int i = 0; i < texts.Count; i++)
        {
            if (i == defaultIndex)
                texts[i].SetActive(true);
            else
                texts[i].SetActive(false);

            currentIndex = defaultIndex;
        }

        //title.text = textData.header_home;
    }

    public void SetHeader(int _index)
    {
        currentIndex = defaultIndex;
        for (int i = 0; i < texts.Count; i++)
        {
            if (i == _index)
                texts[i].SetActive(true);
            else
                texts[i].SetActive(false);
        }
    }


}
