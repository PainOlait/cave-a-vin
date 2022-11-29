using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUI : MonoBehaviour
{
    [SerializeField]
    private Header header = null;

    [SerializeField]
    private Body body = null;

    [SerializeField]
    private Footer footer = null;

    [SerializeField]
    private int defaultIndex = 0;

    private void Start()
    {
        Initialize();
    }
    public void Initialize()
    {
        header.Initialize(defaultIndex);
        body.Initialize(defaultIndex);
        footer.Initialize(defaultIndex);
    }

    public void OpenMEnu()
    {
        SwitchPage(1);
    }

    public void OpenSettings()
    {
        SwitchPage(2);
    }

    public void OpenCaveView()
    {
        SwitchPage(3);
    }

    private void SwitchPage(int _index)
    {
        header.SetHeader(_index);
        body.ShowPageContent(_index);
        footer.ShowFooter(_index);
    }
}
