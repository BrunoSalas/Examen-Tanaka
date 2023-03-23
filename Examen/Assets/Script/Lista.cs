using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lista : MonoBehaviour
{
    private List<int> numeros = new();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            numeros.Add(i);
        }

        for (int i = 0; i < numeros.Count; i++)
        {
            Debug.Log(numeros[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
