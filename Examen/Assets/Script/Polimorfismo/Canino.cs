using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canino
{
   public virtual void Gru�en()
    {

    }
}

public class Perro : Canino
{
    public override void Gru�en()
    {
        Debug.Log("Sonido de gru�ir");
    }
}
public class Lobo : Canino
{
    public override void Gru�en()
    {
        Debug.Log("Sonido de gru�ir");
    }
}
