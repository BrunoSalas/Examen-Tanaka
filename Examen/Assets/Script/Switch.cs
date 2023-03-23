using UnityEngine;
using System.Collections;

public class Switch : MonoBehaviour
{
    void Start()
    {
        // Declarar una variable que represente la inicial de un día de la semana
        char inicialDia = 'L';

        // Utilizar una declaración switch para imprimir el día de la semana correspondiente
        switch (inicialDia)
        {
            case 'L':
                Debug.Log("Lunes");
                break;
            case 'M':
                Debug.Log("Martes");
                break;
            case 'X':
                Debug.Log("Miércoles");
                break;
            case 'J':
                Debug.Log("Jueves");
                break;
            case 'V':
                Debug.Log("Viernes");
                break;
            case 'S':
                Debug.Log("Sábado");
                break;
            case 'D':
                Debug.Log("Domingo");
                break;
            default:
                Debug.Log("La inicial no corresponde a un día de la semana");
                break;
        }
    }
}
