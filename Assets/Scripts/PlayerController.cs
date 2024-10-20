using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f; // Velocidade de movimentação
    private Vector2 targetPosition; // Posição do toque na tela
    public int score = 0;

    void Start()
    {
        targetPosition = transform.position; // Inicializa com a posição atual
    }

    void Update()
    {
        // Detecta o toque na tela (para celulares)
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f; // Definindo o eixo Z como 0 para 2D

            // Define a posição alvo como o ponto tocado
            targetPosition = new Vector2(touchPosition.x, transform.position.y);
        }

        // Move suavemente o player em direção à posição alvo
        transform.position = Vector2.Lerp(transform.position, targetPosition, speed * Time.deltaTime);
    }

    /*void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))
        {
            // Aumenta a pontuação ao coletar um fruto
            score += 1;
            Destroy(collision.gameObject); // Remove o fruto da tela
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Aplica uma penalidade ao colidir com um obstáculo
            score -= 1;
            Destroy(collision.gameObject); // Remove o obstáculo da tela
        }
    }*/
}
