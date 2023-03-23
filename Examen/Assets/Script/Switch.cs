using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour
{
    void Start()
    {
        // Declarar una variable que represente la inicial de un d�a de la semana
        char inicialDia = 'L';

        // Utilizar una declaraci�n switch para imprimir el d�a de la semana correspondiente
        switch (inicialDia)
        {
            case 'L':
                Debug.Log("Lunes");
                break;
            case 'M':
                Debug.Log("Martes");
                break;
            case 'X':
                Debug.Log("Mi�rcoles");
                break;
            case 'J':
                Debug.Log("Jueves");
                break;
            case 'V':
                Debug.Log("Viernes");
                break;
            case 'S':
                Debug.Log("S�bado");
                break;
            case 'D':
                Debug.Log("Domingo");
                break;
            default:
                Debug.Log("La inicial no corresponde a un d�a de la semana");
                break;
        }
    }
}
