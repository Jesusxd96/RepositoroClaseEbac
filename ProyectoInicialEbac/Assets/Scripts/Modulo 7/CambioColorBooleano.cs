using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColorBooleano : MonoBehaviour
{
    public bool color;//Esta variable BOOLEANA determinara el color de el objeto.
    //public int numObjeto;//Aqui se determinara el numero del gameobject
    public GameObject objACambiar;//A que objeto se le cambiara el color

    void FixedUpdate(){
       CambiarColor();
    }

    void CambiarColor()
    {
        Color c = new Color();
        if (color==true){
            //color = true;
            c = Color.white;
            objACambiar.GetComponent<MeshRenderer>().material.color = c;
            //Debug.Log("El color es blanco");
        }
        else{
            //color = false;
            c = Color.black;
            objACambiar.GetComponent<MeshRenderer>().material.color = c;
            //Debug.Log("El color es negro");
        }
    }
}
