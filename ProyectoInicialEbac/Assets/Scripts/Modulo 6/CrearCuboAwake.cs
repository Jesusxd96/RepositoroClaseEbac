using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboAwake : MonoBehaviour
{
    [SerializeField] public GameObject objToSpawn;/*Este sera el prefab del cubo, se asignara en el inspector*/
    [SerializeField] Vector3 spawnPosition;//Posicion donde se instanciara el cubo.
    void SpawnCube()
    {
        /*var meshRendererMaterial = objToSpawn.GetComponent<MeshRenderer>().material;//Se le otorga un material al renderer
        meshRendererMaterial.color = Color.HSVToRGB(Random.value, Random.value, Random.value);//Color para dicho material*/
        Instantiate(objToSpawn, spawnPosition, objToSpawn.transform.rotation);//Se instanciara el objeto dentro de la variable objToSpawn
        //objToSpawn.transform.position = this.transform.position;//Se le otorga una posicion inicial
    }

    void Awake()
    {
        spawnPosition = this.transform.position;
        SpawnCube();
    }

}
