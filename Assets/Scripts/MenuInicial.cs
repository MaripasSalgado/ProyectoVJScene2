using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class MenuInicial1 : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    [SerializeField]
    GameObject videoCanvas;
    public void Jugar()
    {
        StartCoroutine(PlayVideoAndLoadScene());
    }

    IEnumerator PlayVideoAndLoadScene()
    {
        videoCanvas.SetActive(true);
        videoPlayer.Play();
        yield return new WaitUntil(() => videoPlayer.isPlaying == false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Salir()
    {
        Debug.Log("Salir....");
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}

