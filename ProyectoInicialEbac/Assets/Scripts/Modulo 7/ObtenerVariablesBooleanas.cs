using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObtenerVariablesBooleanas : MonoBehaviour
{
    public int tipo;//Dependiendo del tipo del objeto se realizara una operacion distinta.
    public bool valor;//Este nuevo objeto es positivo o negativo?
    public bool isCubeFive;//Simple booleano checando si es el numero 5;

    /*Se crearan variables para almacenar los objetos que tienen el valor booleano a evaluar*/
    public GameObject objeto1;//Objeto 1 a referenciar
    public GameObject objeto2;//Objeto 2 a referenciar
    private bool colorObj_1;//Variable que guardara el valor del color del 1er objeto
    private bool colorObj_2;//Variable que guardara el valor del color del 2ndo objeto

    // Start is called before the first frame update
    void Start()
    {   /*Se obtendran los 2 colores de los objetos a referenciar*/
        if (isCubeFive)
        {
            colorObj_1 = objeto1.GetComponent<ObtenerVariablesBooleanas>().valor;//Se obtendra el valor booleano del 1er objeto
            colorObj_2 = objeto2.GetComponent<ObtenerVariablesBooleanas>().valor;//Se obtendra el valor booleano del 2do objeto
        }
        else{
            colorObj_1 = objeto1.GetComponent<CambioColorBooleano>().color;//Se obtendra el valor booleano del 1er objeto
            colorObj_2 = objeto2.GetComponent<CambioColorBooleano>().color;//Se obtendra el valor booleano del 2do objeto
        }
    }

    // Update is called once per frame
    void Update()
    {   /*Se vuelven a poner aqui para que el script siga detectando el color a leer*/
        if (isCubeFive)
        {//Solo se hara si este cubo es denominado como el 5to segunda las instrucciones de la tarea
            colorObj_1 = objeto1.GetComponent<ObtenerVariablesBooleanas>().valor;//Se obtendra el valor booleano del 1er objeto
            colorObj_2 = objeto2.GetComponent<ObtenerVariablesBooleanas>().valor;//Se obtendra el valor booleano del 2do objeto
            Evaluar(tipo);//Se mandara el tipo de operacion a realizar
        }
        else
        {
            colorObj_1 = objeto1.GetComponent<CambioColorBooleano>().color;//Se obtendra el valor booleano del 1er objeto
            colorObj_2 = objeto2.GetComponent<CambioColorBooleano>().color;//Se obtendra el valor booleano del 2do objeto
            Evaluar(tipo);//Se mandara el tipo de operacion a realizar
        }
    }

    void Funcion3()//Funcion Creada exclusivamente para el cubo numero 5
    {
        if (colorObj_1 && colorObj_2)
        {//Si ambos son blancos, ambos son verdaderos, este nuevo objeto es verdadero igual
            valor = true;
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
        }
        else
        {
            valor = false;
            this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    void Evaluar(int i)//Funcion que se utilizara para evaluar el
    {
        /*Se utilizara un switch para verificar el tipo de operacion a realizarse
        Caso 1: Operador AND; 
        Caso 2: Operador OR;
        Caso 3: Reservado 5to cubo
        Default: nada supongo
         */
        switch (i){
            case 1: if(colorObj_1 && colorObj_2)
                {//Si ambos son blancos, ambos son verdaderos, este nuevo objeto es verdadero igual
                    valor = true;
                    this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                }else
                {
                    valor = false;
                    this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                }
                break;
            case 2:
                if (colorObj_1 || colorObj_2)
                {//Si cualquiera es blanco, este sera blanco/verdadero
                    valor = true;
                    this.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                }
                else
                {
                    valor = false;
                    this.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                break;
            case 3: Funcion3();
                break;
            default:
                break;
        }
    }

}
