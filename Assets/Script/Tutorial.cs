using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject step1, step2, step3, tutorial;
    private bool solto;
    private void Start()
    {
        step1.SetActive(true);
        step2.SetActive(false);
        step3.SetActive(false);
    }
    public LogicaDeAgarradoDePlataformas launcher;
    public PlatformLauncher platform;
    public PerspectiveSwitcher perspective;
    private void Update()
    {
        if (perspective.orthoOn)
        {
            tutorial.SetActive(false);
            return;
        }
        else
        {
            tutorial.SetActive(true);
        }
        if (launcher.estaAgarrando)
        {
            step1.SetActive(false);
            step2.SetActive(true);
        }
        if (platform.estaAcionado)
        {
            step2.SetActive(false);
            step3.SetActive(true);
        }
    }
}
