using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Rendering2D, Rendering3D;

    public void ShowContentByOrthoOn(bool orthoOn)
    {
        Rendering2D.SetActive(orthoOn);
        Rendering3D.SetActive(!orthoOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
