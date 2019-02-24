using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public ReservaExtensivel reservaDeBalas;
    public GameObject CanoDaArma;
    public AudioClip SomDoTiro;
    [SerializeField]
    private float tempoEntreTiros;
    private float tempoUltimoTiro;
    void Update()
    {
        tempoUltimoTiro += Time.deltaTime;
        var toquesNaTela = Input.touches;
        foreach (var toque in toquesNaTela)
        {
            if (toque.phase == TouchPhase.Began && tempoUltimoTiro >= tempoEntreTiros)
            {
                this.Atirar();
                ControlaAudio.instancia.PlayOneShot(SomDoTiro);
                tempoUltimoTiro = 0;
            }
        }
    }
    private void Atirar()
    {
        if (this.reservaDeBalas.TemObjeto())
        {
            var bala = this.reservaDeBalas.PegarObjeto();
            bala.transform.position = CanoDaArma.transform.position;
            bala.transform.rotation = CanoDaArma.transform.rotation;
        }
    }
}
