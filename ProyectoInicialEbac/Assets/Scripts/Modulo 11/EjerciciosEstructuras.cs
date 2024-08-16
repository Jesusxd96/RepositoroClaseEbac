using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjerciciosEstructuras : MonoBehaviour
{
    /*Variables inciso 1*/
    [Tooltip("Tamaño de la lista a generarse del inciso 1.")]
    public int tamanio = 5;
    [Tooltip("Numero inferior para el generado aleatorio")]
    public int inferior = 1;
    [Tooltip("Numero superior para el generado aleatorio")]
    public int superior = 20;

    /*Variables inciso 2*/
    [Tooltip("Array a ordernar de mayor a menor del inciso 2.")]
    public int[] arrayChiquito = new int[] { 2, 7, 3, 8, 2, 5, 3, 5, 3};//Se puede editar para ver como cambia en runtime

    /*Variables inciso 3*/

    // Start is called before the first frame update
    void Start()
    {
        generacionDeNumeros(tamanio, inferior, superior);
        ordenadoArray(arrayChiquito);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public List<int> generacionDeNumeros(int tam,int rangoInferior,int rangoSuperior)
    {
        //int[] array = new int [tam];//Se generara un array del tamaño mandado
        List<int> listaValores = new List<int>();//Se genera una lista donde se guardaran los valores.
        int valorRandom = 0;

        for(int i = 0; i < tam; i++)//Dependiendo del "tamaño" se repetira el ciclo las veces necesarias
        {
            valorRandom = Random.Range(rangoInferior, rangoSuperior);//Se generara un numero aleatoreo
            listaValores.Add(valorRandom);//El numero generado se agregara a la lista
        }
        Debug.Log("Los valores generados fueron: ");
        foreach(var valor in listaValores)
        {
            Debug.Log(valor);
        }
        return listaValores;
    }
    void ordenadoArray(int[] array)
    {
        int temp = 0;
        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int j = i + 1; j < array.Length; j++){
                if (array[i] < array[j])
                {//Si el numero en la posicion i es menor al numero posicion j, este se actualiza
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Debug.Log("Los numeros ya ordenados son: ");//Se imprimiran los numeros ya ordenados
        foreach (var num in array)
            Debug.Log(num);
    }
}
