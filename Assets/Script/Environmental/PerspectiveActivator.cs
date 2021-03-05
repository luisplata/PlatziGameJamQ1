using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PerspectiveActivator : MonoBehaviour
{
    PerspectiveSwitcher perspectiveSwitcher;

    public GameObject whiteLight;
    public GameObject blueLight;
    public GameObject particles;
    public GameObject character2D;
    public GameObject character3D;

    AudioManager audioManager;

    private void Awake()
    {
        perspectiveSwitcher = GameObject.Find("PerspectiveController").GetComponent<PerspectiveSwitcher>();
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    }

    public void ActivarOrtho()
    {
        Debug.Log("Orto On");
        whiteLight.SetActive(true);
        blueLight.SetActive(false);
        particles.SetActive(false);
        audioManager.TransitionTo2DAudio();   
    }

    public void DesactivarOrtho()
    {
        Debug.Log("Orto Off");
        whiteLight.SetActive(false);
        blueLight.SetActive(true);
        particles.SetActive(true);
        audioManager.TransitionTo3DAudio();
    }

}
