using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitMedico : MonoBehaviour
{
    [SerializeField]
    private int quantidadeDeCura;
    [SerializeField]
    private int tempoDeDestruicao;

    private void Start()
    {
        Destroy(gameObject, tempoDeDestruicao);
    }

    private void OnTriggerEnter(Collider objetoDeColisao)
    {
        if(objetoDeColisao.tag == "Jogador")
        {
            objetoDeColisao.GetComponent<ControlaJogador>().CurarVida(quantidadeDeCura);
            Destroy(gameObject);
        }
    }
}
