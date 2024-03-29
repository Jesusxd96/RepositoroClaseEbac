using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("Se imprimiran un par de mensajinis");
        Debug.Log("Hola Mundo!");
        Debug.LogWarning("Algo podria salir mal");
        Debug.LogError("Ya valio burger");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
