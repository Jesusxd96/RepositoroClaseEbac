using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{

    /*Arreglos unidimensionales - Llenar 2 con Random.Range y sumar sus resultados en un 3er array.*/
    int[] arregloA = new int[5], arregloB = new int [5];//Se llenaran aleatoreamente y luego se sumaran.
    int[] arregloC = new int[5]; //Se usara para guardar el resultado de los 2 anteriores.
    int min=0, max=10;

    /*Array de String y llena cada elemento con una palabra de una oracion, luego usando foreach imprimela en un solo string*/
    string[] palabras;
    string oracion;//Donde se imprimiran las palabras despues del foreach.

    /*Multiplicar arreglo bidimensiona por unidimencional, basicamente matriz por vector*/
    int[,] matrizA;
    int[] arregloMultiplicacion;

    // Start is called before the first frame update
    void Start()
    {
        GenerateVector();
        SumaMatriz(arregloA,arregloB);
    }

    // Update is called once per frame
    

    /********* FUNCIONES **********/
    void GenerateVector()//Esta funcion olamente genera los 2 vectores que se sumaran mas adelante.
    {
        int i = 0;
        for(i = 0; i<5; i++){
            arregloA[i] = Random.Range(min,max);
            arregloB[i] = Random.Range(min,max);
        }
        Debug.Log("Arreglo A: \n");
        for (i = 0; i < 5; i++)//Imprimir la primer matriz
        {
            Debug.Log("["+ arregloA[i] +"] ");
        }
        Debug.Log("Arreglo B: \n");
        for (i = 0; i < 5; i++)
        {
            Debug.Log("[" + arregloB[i] + "] ");
        }
    }
    void SumaMatriz(int[] mat1, int[] mat2)
    {
        Debug.Log("Arreglo Resultante: \n");
        for (int i = 0; i < mat1.GetLength(0); i++){
            arregloC[i] = mat1[i] + mat2[i];
            Debug.Log("[" + arregloC[i] + "] ");
        }
    }

}