using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlaArma : MonoBehaviour
{
    [SerializeField]
    private GameObject Pistola;
    [SerializeField]
    private GameObject MPSMG;
    [SerializeField]
    private Text nomeArma;
    private void Start()
    {
        TextoNomeArma();
    }
    public void TrocarArma()
    {
        Pistola.SetActive(!Pistola.activeInHierarchy);
        MPSMG.SetActive(!MPSMG.activeInHierarchy);
        TextoNomeArma();
    }
    private void TextoNomeArma()
    {
        //Deixei inativa para mostrar a arma oposta a ativa, ou seja, a que você receberá quando pressionar o botão;
        bool pistolaInativa = !Pistola.activeInHierarchy;
        if (pistolaInativa)   
        {
            nomeArma.text = "Pistola";
        }
        else
        {
            nomeArma.text = "MPSMG";
        }
    }
}
