using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableCharString : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        char c = 'k';
        int valorEntero = 0;
        if (!int.TryParse(c.ToString(), out valorEntero)) {
            Debug.LogError("Eso no es un tipo de Dato Valido");
        }

        Debug.Log(valorEntero);

        char miCaracter;
        string miString = "Hola desde EBAC";
        string miSegundoString = miString.Replace('e', 'E');//Cambiar las "e" a "E"
        //string miTercerString = miString.ToUpper();//todo el strin se cambia a mayuscula
        string miTercerString = miString + " " + miSegundoString;
        string ejemploEscape = "C:\\Users\\Diego\n Documentos";

        miCaracter = miString[13];

        string miNombre = "Eduardo";
        string misApellidos = "Lara Ortiz";
        string miPrimerApellido = misApellidos.Substring(0, 4);
        string salida = $"Mi nombre es: {miNombre} Y mis apellidos son {misApellidos}";
        int longitud = miString.Length;
        Debug.Log("El caracter tomado es:" + miCaracter);
        Debug.Log(salida);
        Debug.Log(miPrimerApellido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
