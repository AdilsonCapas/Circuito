using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botao : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Biblioteca");
    }
    public void JogarEstante()
    {
        SceneManager.LoadScene("EstanteMenu");
    }
    public void Estante()
    {
        SceneManager.LoadScene("Estante");
    }
    public void Estante2()
    {
        SceneManager.LoadScene("Estante2");
    }
    public void Mesa()
    {
        SceneManager.LoadScene("Mesaa");
    }
    public void Estante2Menu()
    {
        SceneManager.LoadScene("Estante2Menu");
    }
}
