using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorBooleano : MonoBehaviour
{
    public bool color;//Esta variable determinara el color de el objeto.
    public int numObjeto;//Aqui se determinara el numero del gameobject
    /*Dependiendo del numero del gameobject este se comportara de manera distinta.
     * el 0 y 1 cambiaran su color en FixedUpdate.
     * 
     * El numero 2 obtendra su valor dependiendo del valor de los objetos 0 y 1
     */

    void FixedUpdate(){
        if (color){
            color = false;
            Debug.Log("El color es negro");
        }
        else {
            color = true;
            Debug.Log("El color es blanco");
        }

    }
}
