using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject mpausa;
    public static bool pausado;

    void Start()
    {
        mpausa.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausado)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        mpausa.SetActive(true);
        Time.timeScale = 0f;
        pausado = true;
    }

    public void Resume()
    {
        mpausa.SetActive(false);
        Time.timeScale = 1f;
        pausado = false;
    }

    public void Titulo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void SalirJ()
    {
        Application.Quit();
    }
}
