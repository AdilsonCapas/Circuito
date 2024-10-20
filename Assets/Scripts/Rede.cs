using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rede : MonoBehaviour
{
    private Vector3 offset;

    void Update()
    {
        // Verifica se há toque na tela
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0; // Ignora a posição Z

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Captura a posição inicial do toque
                    offset = transform.position - touchPosition;
                    break;

                case TouchPhase.Moved:
                    // Move a rede conforme o toque
                    transform.position = touchPosition + offset;
                    break;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
{
    Debug.Log("Colidiu com: " + other.gameObject.name);
    // Quando a rede colide com o lixo, incrementa os pontos
    if (other.CompareTag("Lixo"))
    {
        Lixo.pontos++;
        Destroy(other.gameObject);
    }
}
}
