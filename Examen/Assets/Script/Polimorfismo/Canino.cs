using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canino
{
   public virtual void Gruñen()
    {

    }
}

public class Perro : Canino
{
    public override void Gruñen()
    {
        Debug.Log("Sonido de gruñir");
    }
}
public class Lobo : Canino
{
    public override void Gruñen()
    {
        Debug.Log("Sonido de gruñir");
    }
}
