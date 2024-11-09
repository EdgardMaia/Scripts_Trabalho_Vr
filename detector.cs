using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class detector : MonoBehaviour
{
    public GameObject controle;
    public controlador componenteControlador;

    public bool agua;
    public bool sabao;

    // Start is called before the first frame update
    void Start()
    {
        controle = GameObject.FindWithTag("gameController");
        componenteControlador = controle.GetComponent<controlador>();
    }

    public void OnTriggerEnter(Collider other)
    {
        componenteControlador.etapas();

        if (agua)
        {
            componenteControlador.toqueNaAgua();
        }

        if (sabao)
        {
            componenteControlador.toqueNoSabao();
        }
    }
}
