using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCuboUpdate : MonoBehaviour
{
    public GameObject PrefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numeroDeCubos = 0;

    // Start is called before the first frame update
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        numeroDeCubos++;
        GameObject tempGameObject = Instantiate<GameObject>(PrefabCubo);
        tempGameObject.name = "CuboNumero" + numeroDeCubos;
        Color c = new Color(Random.value, Random.value, Random.value);
        tempGameObject.GetComponent<MeshRenderer>().material.color = c;
        tempGameObject.transform.position = this.transform.position;
        //para limitar los cubos en pantalla
        listaDeCubos.Add(tempGameObject);
        List<GameObject> objetosParaEliminar = new List<GameObject>();
        foreach (GameObject go in listaDeCubos) //El "go" es de gameobject
        {
            float scale = go.transform.localScale.x;
            scale *= factorDeEscalamiento;
            go.transform.localScale = Vector3.one * scale;

            if (scale <= 0.1)
            {
                objetosParaEliminar.Add(go);
            }
        }

        foreach (GameObject go in objetosParaEliminar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }
    }
}
