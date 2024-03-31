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
        Debug.Log("Hola desde update");
    }
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }
    private void LateUpdate()
    {
        Debug.LogWarning("Hola desde Late Update");
    }
    private void OnEnable()
    {
        Debug.LogWarning("El Objeto ha sido habilidato");
    }
    private void OnDisable()
    {
        Debug.LogError("El objeto ha sido deshabilitado");
    }
}
