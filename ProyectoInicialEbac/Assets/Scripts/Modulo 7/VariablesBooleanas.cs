using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
    int limiteInferior = -5;
    int limiteSuperior = 5;
    enum SeleccionColor
    {
        rojo,
        verde,
        azul,
        blanco,
        gris
    };
    
    // Start is called before the first frame update
    void Start()
    {
        variable1 = true;
        variable2 = false;
        variable3 = false;
        if ((variable1 || variable2) && variable3){
            Debug.Log("La operacion 1 dio resultado verdadero");
            //Solo entrara a este If, si el de la operacion 1 es verdadero.
            if (valor1 <= 5) {
                Debug.Log("El valor 1 es menor o igual a 5");
            }
            else{
                Debug.Log("El valor 1 es mayor a 5");
            }
        }
        else if(variable1 || variable2 || variable3){
            Debug.Log("La operacion 2 dio resultado verdadero");
        }
        else if ((variable1 && variable2) || variable3){
            Debug.Log("La operacion 3 dio resultado verdadero");
        }
        //Esto pasa despues de dar los mensajes anteriores
        valor1 = Random.Range(limiteInferior, limiteSuperior);
        Debug.Log(valor1);
        
        /*if(valor1 >= 0){
            Debug.Log("El resultado es positivo.");
        }
        else{
            Debug.Log("El resultado es negativo");
        }*/

        string resultado = (valor1 >= 0) ? "el valor es positivo" : "el valor es negativo";
        Debug.Log(resultado);
        /*switch (valor1)
        {//Como no son numeros como tal lo del enum, se castea con el int.
            case (int)SeleccionColor.rojo:
                Debug.Log("El color seleccionado es el rojo");
                break;
            case (int)SeleccionColor.verde:
                Debug.Log("El color seleccionado es el verde");
                break;
            case (int)SeleccionColor.azul:
                Debug.Log("El color seleccionado es el azul");
                break;
            case (int)SeleccionColor.blanco:
                Debug.Log("El color seleccionado es el blanco");
                break;
            case (int)SeleccionColor.gris:
                Debug.Log("El color seleccionado es el gris");
                break;
            default:
                Debug.Log("Ningun color valido se selecciono");
                break;
        }
        */

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
