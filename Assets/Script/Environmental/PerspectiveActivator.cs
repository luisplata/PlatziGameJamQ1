﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerspectiveActivator : MonoBehaviour
{
    public PerspectiveSwitcher perspectiveSwitcher;
    public GameObject whiteLight;
    public GameObject blueLight;
    public GameObject particles;

   
    public void ActivarOrtho()
    {
        Debug.Log("Orto On");
        whiteLight.SetActive(true);
        blueLight.SetActive(false);
        particles.SetActive(false);
    }

    public void DesactivarOrtho()
    {
        Debug.Log("Orto Off");
        whiteLight.SetActive(false);
        blueLight.SetActive(true);
        particles.SetActive(true);
    }

}
