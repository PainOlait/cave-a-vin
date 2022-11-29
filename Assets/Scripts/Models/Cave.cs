using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cave : MonoBehaviour
{
    [SerializeField]
    CaveManager caveManager;

    public Bouteille[] bouteilles;

    public string nom;
    public int capaciteMax;
    public int temperature;
    public int remplissage;

    public void Initialize()
    {
        Debug.Log("There is " + bouteilles.Length + "bottles in " + gameObject.name);
    }

    
}
