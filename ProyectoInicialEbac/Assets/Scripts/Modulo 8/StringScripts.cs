using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringScripts : MonoBehaviour
{
    /*Para convertir un flotante a string*/
    public float num = 65.9732786f;//Numero que se convertira a String
    [SerializeField]string flotanteString;

    /*Ejercicio 6, Metodo Substring*/
    public string nombre = "Jesus Eduardo Lara";//Aqui se asignara un nombre mediante el editor
    string s1, s2, s3;
    string[] nombreArray;

    /*-----------------------------------PARTE 2------------------------------------------*/
    //2 Variables STRING que guarde valores numericos de miles y pasarlas a tipos de datos num.
    string numero1="1500";
    string numero2="7830";
    int res;

    public string oracionSimple = "Esto es una oracion";


    /*--------------------------------------------------------------------------------------*/

    // Start is called before the first frame update
    void Start()
    {
        //El N4 es para los decimales aparentemente
        flotanteString = num.ToString("N4");//El string ahora contiene el numero flotante
        Debug.Log("El numero impreso es: " + flotanteString);
        ImprimirNombre();
        StringOperations();
        Debug.Log("El resultado de la operacion de strings es: " + res);

        ImprimirOracion();
    }

    void ImprimirNombre()
    {
        s1 = nombre.Substring(0, 5);
        s2 = nombre.Substring(6, 7);
        s3 = nombre.Substring(14, 4);
        //Aqui se divide la frase
        nombreArray  = nombre.Split(' ');
        for (int i = 0; i < nombreArray.Length; i++)
        {
            Debug.Log($"Nombre array: " + i + ": " + nombreArray[i]);
        }

        Debug.Log("Substring 1: " + s1);
        Debug.Log("Substring 2: " + s2);
        Debug.Log("Substring 3: " + s3);
    }
    void StringOperations()
    {
        int temp1, temp2;
        int.TryParse(numero1,out temp1);
        int.TryParse(numero2, out temp2);
        res = temp1 + temp2;
    }

    void ImprimirOracion()
    {//Dentro de este metodo se imprimiran solo los caracteres que se encuentren en un indice par.
        string nuevaOracion = "";
        int i = 0;
        for(i=0; i < oracionSimple.Length; i++)
        {
            if (i % 2 == 0){
                nuevaOracion+=oracionSimple[i].ToString();//Se le agregaran los caracteres
            }
        }
        Debug.Log("La nueva string es: " + nuevaOracion);
    }
}