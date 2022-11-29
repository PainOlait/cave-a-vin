using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bouteille", menuName = "ScriptableObjects/Bouteille")]
[System.Serializable]
public class Bouteille : ScriptableObject
{
    public int index;

    public string nom;
    public string domaine;
    public string region;
    public string pays;
    public string couleur;
    public string type;
    public string annee;
    public string appellation;
    public double degreAlcool;
    public double[] temperatureService = new double[2];

    public string commentaire;
    public List<Tag> tags;
}

[System.Serializable]
public class Tag : ScriptableObject
{
    public string tag_name;
    public string tag_color;
    public string tag_comment;
}
