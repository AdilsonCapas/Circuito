using UnityEngine;

public class Botaoverificar : MonoBehaviour
{
    public GameObject botao1;   // Arraste o Botão 1 aqui
    public GameObject botao2;   // Arraste o Botão 2 aqui
    public GameObject botao3;
    public GameObject imagemAtiva;  // A imagem que será ativada quando os botões forem destruídos

    private void Start()
    {
        // Desativa a imagem inicialmente
        imagemAtiva.SetActive(false);
    }

    private void Update()
    {
        // Verifica se ambos os botões foram destruídos
        if (botao1 == null && botao2 == null && botao3 == null)
        {
            imagemAtiva.SetActive(true); // Ativa a imagem se ambos os botões forem destruídos
        }
    }
}
