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
    public int daño;
    public abstract void Atacar(); 
}

public class Espada : Arma
{
    public Espada(int daño)
    {
        this.daño = daño;
    }
    public override void Atacar()
    {
        Debug.Log(daño);
    }
}
