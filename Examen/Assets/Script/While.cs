using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour
{
    int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (num < 10)
        {
            Debug.Log(num);
            num++;
        }
    }
}
