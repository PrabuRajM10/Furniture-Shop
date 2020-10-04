using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class VirtualButton : MonoBehaviour 
{
    public GameObject cube;
    VirtualButtonBehaviour vbtb;

    private void Start()
    {
        cube.SetActive(false);
        vbtb = GetComponentInChildren<VirtualButtonBehaviour>();
        vbtb.RegisterOnButtonPressed(OnButtonPressed);
        vbtb.RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }
}
