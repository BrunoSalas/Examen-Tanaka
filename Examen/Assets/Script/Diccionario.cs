using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionario : MonoBehaviour
{
    Dictionary<string, int> NombreEdad = new Dictionary<string, int>()
    {
        {"Jimmy",20},
        {"Bruno", 21}
    };
    
    // Start is called before the first frame update
    void Start()
    {
        NombreEdad.Add("Jorge", 22);

        if (NombreEdad.TryGetValue("Bruno", out int resultadoEdad))
        {
            Debug.Log(resultadoEdad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
