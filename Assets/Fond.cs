using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fond : MonoBehaviour
{
    RequireComponent Image;
    public ColorPalette colors = null;
    [SerializeField] Image image = null;
        
    private void Start()
    {
        SetColors();
    }

    public void SetColors()
    {
        if (colors != null)
            image.color = colors.fond;
        else
            Debug.Log(gameObject.name + " colors are not defined, falling back to default colors");
    }
}
