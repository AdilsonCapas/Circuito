using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; // Para carregar uma cena em caso de vitória ou derrota

public class Fire : MonoBehaviour
{
    public static int fogosApagados = 0;  // Conta os fogos apagados
    public static bool perdeu = false;    // Marca se o jogador perdeu
    public float tempoParaApagar = 5f;    // Tempo limite para apagar o fogo
    private bool foiApagado = false;      // Verifica se o fogo foi apagado a tempo

    void Start()
    {
        // Inicia a contagem regressiva para apagar o fogo
        if (IsVisibleOnScreen())
    {
        StartCoroutine(TemporizadorFogo());
    }
    }

    bool IsVisibleOnScreen()
{
    // Converte a posição do objeto para a tela e verifica se está visível
    Vector3 screenPoint = Camera.main.WorldToViewportPoint(transform.position);
    return screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
}

    void Update()
    {
        // Detecta toque na tela
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            Vector2 touchPos2D = new Vector2(touchPosition.x, touchPosition.y);

            RaycastHit2D hit = Physics2D.Raycast(touchPos2D, Vector2.zero);

            // Verifica se o fogo foi tocado e apaga-o se sim
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                ApagarFogo();  // Chama a função para apagar o fogo
            }
        }
    }

    void ApagarFogo()
    {
        if (!foiApagado)
    {
        foiApagado = true;  // Marca que o fogo foi apagado
        fogosApagados++;    // Incrementa o contador de fogos apagados
        PlayerPrefs.SetInt("fogosApagados", fogosApagados); // Salva a contagem
        Destroy(gameObject);  // Apaga o fogo

        // Verifica se o jogador já apagou 10 fogos
        if (fogosApagados >= 10)
        {
            Vitoria();  // Chama a função de vitória
        }
    }
    }

    IEnumerator TemporizadorFogo()
    {
        // Espera 3 segundos
        yield return new WaitForSeconds(tempoParaApagar);

        // Se o fogo não foi apagado em 3 segundos, o jogador perde
        if (!foiApagado)
        {
            perdeu = true;  // Marca que o jogador perdeu
            Derrota();      // Chama a função de derrota
        }
    }

    void Vitoria()
    {
        // Carrega a cena de vitória ou realiza alguma ação
        SceneManager.LoadScene("Biblioteca");
    }

    void Derrota()
    {
        // Carrega a cena de derrota ou realiza alguma ação
        SceneManager.LoadScene("Novamente2");
    }
}
