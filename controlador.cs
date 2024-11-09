using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class controlador : MonoBehaviour
{

    public string etapaName;
    public string ultimaAcao;

    public bool inciado;

    public GameObject janela1;
    public GameObject janela2;
    public GameObject janela3;
    public GameObject janela4;

    public GameObject janela6;
    public GameObject janela7;

    public TextMeshProUGUI messageText;

    public void inicial()
    {
        if (!inciado)
        {
            janela1.SetActive(false);
            janela2.SetActive(true);
            etapaName = "etapa1";
            inciado = true;
        }
    }

    public void reiniciar()
    {
        SceneManager.LoadScene(0);
    }
    
    public void etapas()
    {
        //etapa em que a mao toca na agua
        if (etapaName == "etapa1" && ultimaAcao == "agua")
        {
            janela2.SetActive(false);
            janela3.SetActive(true);
            etapaName = "etapa2";
            messageText.text = etapaName;
        }

        //etapa em que a mao toca no sabonete
        if (etapaName == "etapa2" && ultimaAcao == "sabao")
        {
            janela3.SetActive(false);
            janela4.SetActive(true);
            etapaName = "etapa3";
            messageText.text = etapaName;
        }

        if (etapaName == "etapa5" && ultimaAcao == "agua")
        {
            janela6.SetActive(false);
            janela7.SetActive(true);
            etapaName = "final";
            messageText.text = etapaName;
        }
    }

    public void atribuirEtapa(string nomeEtapa)
    {
        etapaName = nomeEtapa;
        messageText.text = etapaName;
    }

    public void toqueNaAgua()
    {
        ultimaAcao = "agua";
    }

    public void toqueNoSabao()
    {
        ultimaAcao = "sabao";
    }
}

