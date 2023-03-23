using UnityEngine;
using System.Collections;

public class For : MonoBehaviour
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

        // Imprimir los valores del arreglo en orden descendente
        for (int i = arreglo.Length - 1; i >= 0; i--)
        {
            Debug.Log(arreglo[i]);
        }
    }
}
