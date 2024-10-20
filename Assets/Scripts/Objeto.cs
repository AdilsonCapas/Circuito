using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;  // Para carregar a cena

public class Objeto : MonoBehaviour
{
    public static int pontos = 0;  // Variável estática para manter a pontuação
    public static bool venceu = false;  // Variável estática para indicar se o jogador venceu
    public TMP_Text Pontos;

    // Start is called before the first frame update
    void Start()
    {
        UpdatePontos();  // Atualiza o texto na inicialização
    }

    void UpdatePontos()
    {
        // Atualiza o texto da UI com o número de pontos
        Pontos.text = "Pontos: " + pontos.ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Quando colidir com o chão, destrói o objeto
        if (other.gameObject.CompareTag("Chão"))
        {
            Destroy(gameObject);
        }
        // Quando colidir com o jogador, incrementa os pontos e atualiza o texto
        else if (other.gameObject.CompareTag("Player"))
        {
            pontos++;  // Incrementa o número de pontos (variável estática)
            UpdatePontos();  // Atualiza o texto com o novo valor

            // Verifica se o número de pontos atingiu 10
            if (pontos >= 10)
            {
                venceu = true;  // Marca que o jogador venceu
                Vitoria();  // Chama o método de vitória
            }

            Destroy(gameObject);  // Destrói o objeto após atualizar os pontos
        }
    }

    void Vitoria()
    {
        // Carrega a nova cena onde o botão será removido
        SceneManager.LoadScene("Biblioteca");
    }
}
