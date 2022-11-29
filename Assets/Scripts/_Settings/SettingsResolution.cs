using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SettingsResolution : MonoBehaviour
{
    [SerializeField]
    TMP_Dropdown dropdown;

    public bool fullscreen = true;

    private List<string> options = new List<string>();

    void Start()
    {
        Resolution[] resolutions = Screen.resolutions;
        int i = 0;
        dropdown.options.Clear();
        foreach (var res in resolutions)
        {
            options.Add(resolutions[i].ToString());
            dropdown.options.Add(new TMP_Dropdown.OptionData(options[i]));
            i++;
        }
        dropdown.value = 0;
        dropdown.RefreshShownValue();
        dropdown.onValueChanged.AddListener(delegate { SetResolution(dropdown); });
    }

    private void SetResolution(TMP_Dropdown _dropdown)
    {
        Resolution[] resolutions = Screen.resolutions;
        Resolution selectedRes = resolutions[_dropdown.value];
        Screen.SetResolution(selectedRes.width, selectedRes.height, fullscreen, selectedRes.refreshRate);
        Debug.Log("Set resolution to " + Screen.currentResolution);
    }
}
