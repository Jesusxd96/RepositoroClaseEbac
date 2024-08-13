using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructuraDeDatos : MonoBehaviour
{
    List<int> listaNumeros = new List<int>();//Lista de enteros
    List<string> listaStrings = new List<string>();//Lista de strings
    HashSet<int> hashSetInt = new HashSet<int>();//Hash set, es como una lista pero no se repiten valores
    Queue<string> colaStrings = new Queue<string>();//Colas o Filas
    Stack<string> pilaStrings = new Stack<string>();// Pilas
    Dictionary<string, float> poderArmas = new Dictionary<string, float>();//Diccionario... de datos?


    // Start is called before the first frame update
    void Start()
    {
        //EjemploLista();
        //EjemploHashSet();
        //EjemploColas();
        //EjemploPilas();
        EjemploDiccionario("escopeta");
        EjemploDiccionario("espada");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EjemploLista() {
        for (int i = 0; i < 20; i++)
        {
            listaNumeros.Add(Random.Range(0, 20));
        }
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaNumeros.Sort();
        foreach (var numero in listaNumeros)
        {
            Debug.Log(numero);
        }
        listaStrings.Add("Diego");
        listaStrings.Add("Sofia");
        listaStrings.Add("Daniel");
        listaStrings.Add("Javier");
        listaStrings.Add("Diana");
        listaStrings.Add("Pedro");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
        listaStrings.Remove("Javier");
        listaStrings.Remove("Daniel");
        foreach (var nombre in listaStrings)
        {
            Debug.Log(nombre);
        }
    }
    void EjemploHashSet()
    {
        for(int i=0; i < 20; i++)
        {
            hashSetInt.Add(i);
        }
        if (hashSetInt.Contains(5))
        {
            hashSetInt.Remove(5);
        }
        else
        {
            Debug.Log("El HashSet no contiene este elemento");
        }
    }
    void EjemploColas() {//FIFO - First In First Out
        colaStrings.Enqueue("Proyectil 1");//Push
        colaStrings.Enqueue("Proyectil 2");
        colaStrings.Enqueue("Proyectil 3");
        colaStrings.Enqueue("Proyectil 4");
        colaStrings.Enqueue("Proyectil 5");
        Debug.Log(colaStrings.Peek());//Regresa el primer elemento de la cola
        colaStrings.Dequeue();//Pop
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
        colaStrings.Dequeue();
        Debug.Log(colaStrings.Peek());
    }
    void EjemploPilas() {//FILO - First In Last Out
        pilaStrings.Push("As");
        pilaStrings.Push("CincoEspadas");
        pilaStrings.Push("TresCorazones");
        pilaStrings.Push("CuatroTrebol");
        pilaStrings.Push("ReyEspadas");
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();//Pop es para sacar de la pila al ultimo entrar
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
        Debug.Log(pilaStrings.Peek());
        pilaStrings.Pop();
    }
    void EjemploDiccionario(string arma)
    {//Colecciones de datos, llave y valor
        float temporal = 0;
        if (!poderArmas.ContainsKey("rifle")){
            poderArmas.Add("rifle", 7.0f); 
        }
        if (!poderArmas.ContainsKey("pistola"))
        {
            poderArmas.Add("pistola", 3.0f);
        }
        if (!poderArmas.ContainsKey("escopeta"))
        {
            poderArmas.Add("escopeta", 5.0f);
        }
        if (!poderArmas.ContainsKey("rifleFrancotirador"))
        {
            poderArmas.Add("rifleFrancotirador", 10.0f);
        }
        if (!poderArmas.ContainsKey("cuchillo"))
        {
            poderArmas.Add("cuchillo", 2.0f);
        }

        if(poderArmas.TryGetValue(arma,out temporal))
        {//El TryGetValue se usa para comprobar si tiene un valor, sino, mandara otra variable, en este caso 0
            Debug.Log(temporal);
        }
        else
        {
            Debug.Log("Esa arma no existe");
        }
    }
}
