using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criarSabao : MonoBehaviour
{
    public GameObject gotaSabao;
    
    public void instanciarObjeto()
    {
        Instantiate(gotaSabao, transform.position, transform.rotation);
    }
}