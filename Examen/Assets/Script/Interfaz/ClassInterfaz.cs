using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public interface Dia
{
    public void Amanecer()
    {
        Debug.Log("Sale el sol");
    }
    public void Atardecer()
    {
        Debug.Log("Se oculta el sol");
    }
    public void Anochecer()
    {
        Debug.Log("sale la Luna");
    }
}
[System.Serializable]
public class ClassInterfaz : Dia
{
    public int hora;

    public ClassInterfaz(int hora)
    {
        this.hora = hora;
    }
    public void Amanecer()
    {
        Debug.Log("Sale el sol");
    }
    public void Atardecer()
    {
            Debug.Log("Se oculta el sol");
    }
    public void Anochecer()
    {
            Debug.Log("sale la Luna");
    }
}
