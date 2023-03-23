using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Return : MonoBehaviour
{
    public int a;
    public int b;
    void Start()
    {
       Main();
        Debug.Log(Suma(a, b));
    }
    public void Main()
    {
        int resultado = Suma(5, 10);
      Debug.Log("El resultado de la suma es: " + resultado);
    }

    public int Suma(int a, int b)
    {
        int total = a + b;
        return total;
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
