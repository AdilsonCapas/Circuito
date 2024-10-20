using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dual1 : MonoBehaviour
{
    public Button button1; // Referência ao primeiro botão
    public Button button2; // Referência ao segundo botão

    public Color highlightColor; // Cor dos botões quando "acesos"
    private Color defaultColor;  // Cor padrão dos botões

    void Start()
    {
        // Obtém a cor padrão dos botões (assumimos que ambos têm a mesma cor)
        defaultColor = button1.image.color;

        // Conectar a função de clique para ambos os botões
        button1.onClick.AddListener(OnButtonClicked);
        button2.onClick.AddListener(OnButtonClicked);
    }

    // Função chamada quando qualquer um dos botões é clicado
    void OnButtonClicked()
    {
        // Simular que ambos os botões foram clicados juntos
        AcenderBotoes();

        // Executar a ação desejada (coloque sua lógica aqui)
        ExecutarAcao();

        // Restaurar as cores após 1 segundo
        Invoke("ResetButtonColors", 1f);
    }

    // Função que muda a cor dos dois botões para simular que foram acionados
    void AcenderBotoes()
    {
        button1.image.color = highlightColor;
        button2.image.color = highlightColor;
    }

    // Função que realiza a ação desejada
    void ExecutarAcao()
    {
        Debug.Log("Os dois botões agiram como um só!");
        // Adicione sua lógica aqui, como mudar de cena, ativar um objeto, etc.
    }

    // Restaurar as cores dos botões após a ação
    void ResetButtonColors()
    {
        button1.image.color = defaultColor;
        button2.image.color = defaultColor;
    }
}
