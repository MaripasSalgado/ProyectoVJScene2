using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGameOver : MonoBehaviour
{

    public static MenuGameOver Instance;
    public void Salir()
    {
        Debug.Log("Perdiste, saliendo del jeugo");
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    public IEnumerator DesactivateGameOver()
    {
        yield return new WaitForSeconds(0.5F);
    }
}
