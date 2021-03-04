using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerUiMainMenu : MonoBehaviour
{
    public Button newGame, settings, exit, buttonsCredits;
    public GameObject credits;

    private void Start()
    {
        newGame.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });
        settings.onClick.AddListener(()=>
        {
            
        });
        exit.onClick.AddListener(() =>
        {
            credits.SetActive(true);
        });
        buttonsCredits.onClick.AddListener(() =>
        {
            credits.SetActive(false);
        });
        credits.SetActive(false);
    }
}
