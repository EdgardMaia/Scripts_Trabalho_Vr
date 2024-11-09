using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayAcao : MonoBehaviour
{
    public float delay;

    public GameObject proximaJanela;

    public GameObject controle;
    public controlador componenteControlador;

    public string proximaEtapa;

    public void Start()
    {
        controle = GameObject.FindWithTag("gameController");
        componenteControlador = controle.GetComponent<controlador>();
        chamaContador();
    }

    public void chamaContador()
    {
        StartCoroutine(WaitCoroutine(delay));
    }

    private IEnumerator WaitCoroutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);

        if (proximaEtapa != "")
        {
            componenteControlador.atribuirEtapa(proximaEtapa);
        }

        if (proximaJanela != null)
        {
            proximaJanela.SetActive(true);
        }

        this.gameObject.SetActive(false);
    }
}
