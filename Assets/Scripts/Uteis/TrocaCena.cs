using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
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
    //public void TrocarCena()
    //{
    //    StartCoroutine(MudarCena(cena));
    //}
    //IEnumerator MudarCena(string name)
    //{
    //    yield return new WaitForSecondsRealtime(0.3f);
    //    SceneManager.LoadScene(name);
    //}
}