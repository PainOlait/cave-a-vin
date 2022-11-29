using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Palette", menuName = "ScriptableObjects/Color palette")]
[System.Serializable]
public class ColorPalette : ScriptableObject
{
    public Color main;
    public Color accentuation;
    public Color fond;
}
