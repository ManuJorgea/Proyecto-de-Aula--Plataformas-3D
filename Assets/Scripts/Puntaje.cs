using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Puntaje : MonoBehaviour
{
    public int valorMaximo = 20;
    private int puntajeActual;

    private void Start()
    {
        puntajeActual = valorMaximo;
    }

    private void OnCollisionEnter(Collision collision)
    {
        puntajeActual--;
        Debug.Log("Puntaje actual: " + puntajeActual);

        if (puntajeActual <= 0)
        {
            
            Debug.Log("¡Has perdido!");
        }
    }
}

