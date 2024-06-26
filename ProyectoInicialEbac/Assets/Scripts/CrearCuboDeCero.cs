using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboDeCero : MonoBehaviour
{
    //Creando un Cubo, se necesitan vertices y triangulos
    GameObject objToSpawn;
    Vector3[] vertices = {
        new Vector3(0,0,0), //vertice 0
        new Vector3(1,0,0), //vertice 1
        new Vector3(1,1,0), //vertice 2
        new Vector3(0,1,0), //vertice 3
        new Vector3(0,1,1), //vertice 4
        new Vector3(1,1,1), //vertice 5
        new Vector3(1,0,1), //vertice 6
        new Vector3(0,0,1), //vertice 7
    };
    int[] triangulos = {
        0,2,1, //cara1
        0,3,2,
        2,3,4, //cara 2
        2,4,5,
        1,2,5, //cara 3
        1,5,6,
        0,7,4, //cara 4
        0,4,3,
        5,4,7, //cara 5
        5,7,6,
        0,6,7, //cara 6
        0,1,6,
    };
    // Start is called before the first frame update
    void Start()
    {
        objToSpawn = new GameObject("Nuestro Primer Cubo"); //Se crea el gameobject
        objToSpawn.AddComponent<MeshFilter>(); //Se le agrega un meshfilter al objeto a crear
        var meshFilter = objToSpawn.GetComponent<MeshFilter>().mesh;
        meshFilter.Clear();//Se limpia el meshfilter
        /*Se le hace referencia a los vertices y triangulos determinados arriba*/
        meshFilter.vertices = vertices;
        meshFilter.triangles = triangulos;
        meshFilter.Optimize();
        meshFilter.RecalculateNormals();
        objToSpawn.AddComponent<BoxCollider>();//Se le agrega el componente de BoxCollider
        var boxCollider = objToSpawn.GetComponent<BoxCollider>();
        boxCollider.center = new Vector3(0.5f, 0.5f, 0.5f);//Se le otorga un centro al box collider
        objToSpawn.AddComponent<MeshRenderer>();//Se le agrega un Renderer para que se vea el gameobject
        var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;//Se le otorga un material al renderer
        meshRendererMaterial.color = Color.white;//Color para dicho material
        objToSpawn.transform.position = Vector3.one;//Se le otorga una posicion inicial.
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
