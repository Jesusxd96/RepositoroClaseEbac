using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosVariablesMod8 : MonoBehaviour
{
    public GameObject prefabObjeto;//El objeto al cual esta ligado el script.

    /*Punto 1*/
    int i = 0;
    float j = 1.0f;

    /*Punto 2*/
    float a = 5.0f;
    float b = 9.0f;
    int c = 0;

    /*Punto 3*/
    int resultado = 0;//Sera el resultado de 2 variables que generan valores aleatoreos
    int random1, random2;//Numeros que se generaran y cambiaran en el update.

    // Start is called before the first frame update
    void Start()
    {
        suma();
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log("La variable en el Update tiene como valor: " + i);
    }
    private void FixedUpdate()
    {
        j*=2;
        Debug.Log("La variable en el FixedUpdate tiene como valor:" + j);

        //Cambio de valor para el cambio de color del gameobject
        random1 = Random.Range(1, 50);
        random2 = Random.Range(1, 50);
        cambioColor();//Se llama al cambio de color que dependera de la operacion mod
    }

    void suma()
    {
        c = (int)(a + b);
        Debug.Log("El resultado de C es: " + c);
    }
     void cambioColor()//Dependiendo del numero se cambiara el color a blanco o negro
    {
        resultado = random1 % random2;
        if (resultado == 0) {
            prefabObjeto.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        else{
            prefabObjeto.GetComponent<MeshRenderer>().material.color = Color.white;
        }

    }
}
