using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesNumericas : MonoBehaviour
{
    sbyte miByteConSigno = 0;
    byte miByte = 0;
    //short miShort = 1;
    //ushort miShortSinSigno = 0;
    int miInt = 0;
    uint miIntSinSigno = 0;
    long miLong = long.MaxValue;
    //ulong miLongSinSigno = 0;

    // Start is called before the first frame update
    void Start()
    {
        miByteConSigno = -25;
        miInt = miByteConSigno;
        miByte = 200 + 2;
        Debug.Log("El valor de mi Byte sin signo es: " + miByte);
        miIntSinSigno = (uint)miByteConSigno;//Eso es un casteo explicito
        Debug.Log("El valor de mi Int sin signo es: " + miIntSinSigno);
        miLong = long.MaxValue;
        miInt = (int)miLong;
        Debug.Log("El valor de mi Int es: " + miInt);

        int a, b, c;
        float f;
        a = 5;
        b = 10;
        c = a + b;
        Debug.Log("El valor de C es: " + c);
        c = a * b;
        Debug.Log("El valor de C es: " + c);
        c = a * b;
        Debug.Log("El valor de C es: " + c);
        f = (a / b);
        Debug.Log("El valor de C es(Division): " + f);

        miInt = Random.Range(a, b);
        if (miInt % 2 == 0){
            Debug.Log("El numero " + miInt + " es par.");
        }
        else{
            Debug.Log("El numero " + miInt + " es non.");
        }
    
    }

    // Update is called once per frame
    void Update()
    {

    }
}
