using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorSwitch : MonoBehaviour
{
    public GameObject prefabObjeto;
    string cambio;
    string frase = "Hola soy goku";
    public string[] palabras;//Frase separada, o array de palabras
    [Range(0,2)]
    [SerializeField] int p;//Slider para usarse para el cambio de palabra y por ende de color


    // Start is called before the first frame update
    void Awake()
    {   //Aqui se divide la frase
        palabras = frase.Split(' ');
        for (int i = 0; i < palabras.Length; i++)
        {
            Debug.Log($"Numero " + i + ": " + palabras[i]);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        cambioColor(palabras[p]);
    }
    void cambioColor(string c)//Aqui se manejara el cambio de colores mediante una sentencia SWITCH
    {
        switch (c)
        {
            case "Hola":
                prefabObjeto.GetComponent<MeshRenderer>().material.color = Color.green;
                Debug.Log("Soy verde, mi palabra es: " + c);
                break;
            case "soy":
                prefabObjeto.GetComponent<MeshRenderer>().material.color = Color.blue;
                Debug.Log("Soy azul, mi palabra es: " + c);
                break;
            case "goku":
                prefabObjeto.GetComponent<MeshRenderer>().material.color = Color.yellow;
                Debug.Log("Soy amarillo, mi palabra es: " + c);
                break;
            default: Debug.Log("Frase invalida");
                break;
        }
    }
}
