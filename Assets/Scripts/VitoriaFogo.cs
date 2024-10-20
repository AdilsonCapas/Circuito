using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VitoriaFogo : MonoBehaviour
{
    public GameObject botao;  // Referência ao terceiro botão que será removido

    public GameObject imagemVitoria;  // Referência à imagem que será mostrada
    

    void Update()
    {
        // Verifica se todos os botões foram destruídos
        if (Fire.fogosApagados >= 10) // ou qualquer outra condição que você queira verificar
        {
            // Remove os botões
            Destroy(botao);
            
            // Exibe a imagem de vitória
            imagemVitoria.SetActive(true);
        }
    }
}
