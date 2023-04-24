using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bot : MonoBehaviour
{
    private humano humanoScript;
    public string nuevoNombre;
    public string nombreActual;

    public TextMeshProUGUI saludo;
    void Start()
    {
        humanoScript = GameObject.FindGameObjectWithTag("humano").GetComponent<humano>();
    }

    void Saludar()
    {
        humanoScript.nombre = nuevoNombre;
        saludo.text = "Hola " + nombreActual + "! Ahora te llamas " + humanoScript.nombre; 

        if(nombreActual == humanoScript.nombre)
        {
            saludo.text = "Hola " + nombreActual + "! Tu nombre ya es " + humanoScript.nombre;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("humano"))
        {
            nombreActual = humanoScript.nombre;
            Saludar();
        }
    }
}
