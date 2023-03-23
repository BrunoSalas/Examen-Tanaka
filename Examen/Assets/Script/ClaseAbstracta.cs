using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClaseAbstracta : MonoBehaviour
{
    public Espada espadaFuego = new(10);
    // Start is called before the first frame update
    void Start()
    {
        espadaFuego.Atacar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public abstract class Arma
{
    public int da�o;
    public abstract void Atacar(); 
}

public class Espada : Arma
{
    public Espada(int da�o)
    {
        this.da�o = da�o;
    }
    public override void Atacar()
    {
        Debug.Log(da�o);
    }
}
