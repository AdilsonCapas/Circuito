using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictorySceneManager : MonoBehaviour
{
    public GameObject botao;  // Referência ao botão que será removido
    public GameObject imagemVitoria;  // Referência à imagem que será mostrada

    void Start()
    {
        // Verifica se o jogador ganhou na cena anterior
        if (Objeto.venceu)
        {
            // Remove o botão se o jogador tiver vencido
            Destroy(botao);

            // Exibe a imagem de vitória
            imagemVitoria.SetActive(true);
        }
    }
}
