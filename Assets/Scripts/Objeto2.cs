using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;  // Necessário se quiser reiniciar a cena ou carregar outra cena

public class Objeto2 : MonoBehaviour
{
    public static int erros = 0;  // Variável estática para manter o valor entre instâncias
    public TMP_Text Erros;

    void Start()
    {
        UpdateErros();  // Atualiza o texto na inicialização
    }

    void UpdateErros()
    {
        // Atualiza o texto da UI com o número de erros
        Erros.text = "Erros: " + erros.ToString();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        // Quando colidir com o chão, destrói o objeto
        if (other.gameObject.CompareTag("Chão"))
        {
            Destroy(gameObject);
        }
        // Quando colidir com o jogador, incrementa os erros e atualiza o texto
        else if (other.gameObject.CompareTag("Player"))
        {
            erros++;  // Incrementa o número de erros
            UpdateErros();  // Atualiza o texto com o novo valor

            // Verifica se o número de erros atingiu 3
            if (erros >= 3)
            {
                Derrota();  // Chama o método de derrota
            }

            Destroy(gameObject);  // Destrói o objeto após atualizar os erros
        }
    }

    void Derrota()
    {
        SceneManager.LoadScene("TenteNovamente");
    }
}
