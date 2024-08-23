using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

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
    [Tooltip("Lista de numeros repetidos a ser ordenados en un hashset")]
    public List<string> stringsRepetidos = new List<string>() {"hola","you","hola","tambor","banana","you"};

    /*Variables inciso 4*/
    //Stack o Pila que sera pasada a una cola
    Stack<string> pilaPalabras = new Stack<string>();

    // Start is called before the first frame update
    void Start()
    {
        generacionDeNumeros(tamanio, inferior, superior);
        ordenadoArray(arrayChiquito);
        listToHashSet(stringsRepetidos);
        
        /*Se le agregaran datos a la pilaPalabras*/
        pilaPalabras.Push("Vamos");
        pilaPalabras.Push("a");
        pilaPalabras.Push("ver");
        pilaPalabras.Push("One");
        pilaPalabras.Push("Piece");
        DePilaACola(pilaPalabras);
    }

    // Update is called once per frame

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
    void listToHashSet(List<string> lista)
    {
        //Aqui se le estan pasando los datos de la lista al HashSet dado que ambos son de tipo entero
        HashSet<string> nuevoHash = new HashSet<string>(lista);//La lista se pasa a un hashset para que este remueva los duplicados
        //List<string> listaDistinta = nuevoHash.ToList();//Se regresa a lista para imprimirlo

        //Tras pruebas confirme que igual se puede imprimir de la misma forma que una lista, asi que lo deje como HashSet
        Debug.Log("Contenidos del HashSet: ");        
        //Imprimir en consola el hashset
        foreach(var palabra in nuevoHash)
        {
            Debug.Log(palabra);
        }   
    }

    void DePilaACola(Stack<string> pila)
    {
        //Se crea la cola
        Queue<string> cola = new Queue<string>();

        Debug.Log("Pila antes de pasarse a una cola: ");
        while(pila.Count > 0)//Mientras la pila no este vacia
        {
            Debug.Log(pila.Peek());
            cola.Enqueue(pila.Peek());//Se le pasara el valor de peek?
            pila.Pop();
        }
        Debug.Log("Cola despues de recibir la pila: ");
        while(cola.Count > 0)
        {
            Debug.Log(cola.Peek());
            cola.Dequeue();//Se saca el valor de la cola
        }
        /*Me percate que los valores... quedan iguales hahaha
         hice unas pruebas de pura logica con unos libros en fisico y en teoria queda igual
        si hubiese sido de cola a pila, seria mas notorio el cambio de ordenamiento*/
    }

}
