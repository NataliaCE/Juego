using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMuerte : MonoBehaviour
{
    public void Intentar()
    {
        SceneManager.LoadScene("Juego");
    }

    public void Volver()
    {
        SceneManager.LoadScene("Inicio");
    }
}
