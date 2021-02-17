using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practica1 : MonoBehaviour
{
    void Start()
    {
        int[] arreglo = {8, 1, 2, 2, 3};            //Inicializar el arreglo.
        int[] arregloOrden = funcionOrden(arreglo); //Enviar la referencia del retorno del método a "arregloOrden". 

        for(int i=0; i<arregloOrden.Length; i++)    //Bucle para mostrar en pantalla el contenido del arreglo.
            Debug.Log(arregloOrden[i]);             //Imprimir en consola de unity.
    }

    public int[] funcionOrden(int[] arreglo)            //Definición de la función.
    {
        int[] arregloOrden = new int[arreglo.Length];   //Variables locales.
        int contador;

        for(int i=0; i<arreglo.Length; i++)             //Bucle para recorrer el arreglo.
        {
            for(int j=contador=0; j<arreglo.Length; j++)
                if(arreglo[j] < arreglo[i])              //Condicional para indentificar el menor.
                    ++contador;                         //Conteno se incrementa en más 1.

            arregloOrden[i] = contador;                 //Se almacena en la posicón iésima la cantidad.
        }    

        return arregloOrden;                           //Regresa el arreglo, (referencia).
    }

}
