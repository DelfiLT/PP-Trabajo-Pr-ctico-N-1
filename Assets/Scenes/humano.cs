using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class humano : MonoBehaviour
{
    public float velocity;

    private string nombreHumano = "Delfi";

    public string nombre
    {
        get { return nombreHumano; }
        set { nombreHumano = value; }
    }

    void Update()
    {
        float movX = Input.GetAxis("Horizontal") * velocity;
        movX *= Time.deltaTime;
        transform.Translate(movX, 0, 0);
    }
}
