using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EmplacementWidget : MonoBehaviour
{
    private List<Emplacement> emplacements = new List<Emplacement>();

    [SerializeField]
    private Color emptyColor;
    [SerializeField]
    private Color fullColor;

    private void Awake()
    {
        foreach (Emplacement e in FindObjectsOfType<Emplacement>())
        {
            emplacements.Add(e);
        }
    }

    private void Start()
    {
        RefreshLayout();
    }

    public void RefreshLayout()
    {
        Debug.Log("RefreshingLayouts");
        foreach (Emplacement e in emplacements)
        {
            if (e.bouteille != null)
                e.fillColor.color = fullColor;
            else
                e.fillColor.color = emptyColor;
        }
    }
}
