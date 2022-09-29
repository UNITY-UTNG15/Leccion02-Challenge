/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion del Script: Este Script ayudara a detectar las coliciones, esto quiere decir
* que cuando una pelota toque un perro esta colicionara y debera ser destruida.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    // Funcion que ayuda a destruir los objetos al momento de colicionar.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
