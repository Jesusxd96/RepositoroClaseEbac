using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColores : MonoBehaviour
{
    //En este codigo se le cambiara el color a distintos objetos dependiendo de su designacion.
    public int tipo;
    /*Habra 3 tipos de objetos, 0, 1 y 2, dependiendo del numero, el cambio de color se hara en awake
     * update o fixedUpdate respectivamente.*/
    GameObject prefabObjeto;//El objeto al cual esta ligado el script.


    // Start is called before the first frame update
    void Awake()
    {
        prefabObjeto = this.gameObject;
        Debug.Log("Este objeto es: " + prefabObjeto.name);

        /*Cambio de color en awake*/
        if (tipo == 0) {
        Color c = new Color(Random.value, Random.value, Random.value);
        prefabObjeto.GetComponent<MeshRenderer>().material.color = c;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (tipo == 1){
            Color c = new Color(Random.value, Random.value, Random.value);
            prefabObjeto.GetComponent<MeshRenderer>().material.color = c;
        }
    }

    private void FixedUpdate() {
        if (tipo == 2){
            Color c = new Color(Random.value, Random.value, Random.value);
            prefabObjeto.GetComponent<MeshRenderer>().material.color = c;
        }
    }
}
