using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesBooleanas : MonoBehaviour
{
    bool variable1;
    bool variable2;
    bool variable3;
    int valor1 = 5;
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
