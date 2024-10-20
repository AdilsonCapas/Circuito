using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vitoria : MonoBehaviour
{
    public GameObject botao;  // Referência ao botão que será removido
    public GameObject imagemVitoria;  // Referência à imagem que será mostrada

    void Update()
    {
        // Verifica se o jogador venceu
        if (Lixo.venceu) // Usando a variável estática do seu script Lixo
        {
           // Remove os botões
            Destroy(botao);
            
            // Exibe a imagem de vitória
            imagemVitoria.SetActive(true);
        }
    }
}
