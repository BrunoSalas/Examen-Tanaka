using UnityEngine;
using System.Collections;

public class Array : MonoBehaviour
{
    void Start()
    {
        // Declarar un arreglo de 5 valores
        int[] arreglo = new int[5];

        // Asignar valores a cada elemento del arreglo
        arreglo[0] = 1;
        arreglo[1] = 3;
        arreglo[2] = 5;
        arreglo[3] = 7;
        arreglo[4] = 9;

        // Imprimir los valores del arreglo en la consola
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(arreglo[i]);
        }
    }
}
