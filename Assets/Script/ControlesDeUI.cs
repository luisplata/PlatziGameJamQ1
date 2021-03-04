using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlesDeUI : MonoBehaviour
{
    public GameObject panelDeUI, menuUI;
    public Button buttonExit, buttonReset;
    public bool showMenu;

    private void Start()
    {
        buttonExit.onClick.AddListener(() => Exit());
        buttonReset.onClick.AddListener(() => Reseter());
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

    public void Reseter()
    {
        SceneManager.LoadScene(1);
    }

    public void ActivarUI()
    {
        panelDeUI.SetActive(true);
    }

    public void DesactivarUI()
    {
        panelDeUI.SetActive(false);
    }

    public void ShowMenu()
    {
        if (!showMenu)
        {
            menuUI.SetActive(true);
            showMenu = true;
        }
        else
        {
            HiddeMenu();
        }
    }

    public void HiddeMenu()
    {
        menuUI.SetActive(false);
        showMenu = false;
    }
}
