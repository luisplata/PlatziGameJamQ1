using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialLevel0 : MonoBehaviour
{
    public GameObject step1, step2;
    public PerspectiveSwitcher ps;
    private void Start()
    {
        step1.SetActive(true);
        step2.SetActive(false);
    }

    private void Update()
    {
        if (ps.orthoOn)
        {
            step1.SetActive(false);
            step2.SetActive(true);
        }
    }
}
