using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassarDeFase : MonoBehaviour
{
    private GameObject jogador;
    [SerializeField]
    private string cena;
    void Start()
    {
        jogador = GameObject.FindWithTag("Jogador");
    }
    private void OnTriggerEnter(Collider objetoDeColisao)
    {
        if (objetoDeColisao.tag == "Jogador")
        {
            SceneManager.LoadScene(cena);
        }
    }
}