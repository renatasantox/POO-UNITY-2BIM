using System;
using TMPro;
using UnityEngine;

public class Texto : MonoBehaviour
{
    public string novoTexto;
    public TextMeshProUGUI UITexto;

    public int numero;
    void Start()
    {
        UITexto.text = novoTexto + " " + numero;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && numero > 0)
        {
            numero--;
            UITexto.text = novoTexto + " " + numero;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            numero++;
            UITexto.text = novoTexto + " " + numero;
        }    
    }
}
