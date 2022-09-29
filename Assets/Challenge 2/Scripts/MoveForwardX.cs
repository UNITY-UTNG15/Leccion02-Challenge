/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion del Script: Este Script ayudara al movimiento que tiene el perro para
* que este corra en linea recta, esto al momento de que el player, crea un nuevo
* objeto de tipo perro.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Esta linea sirve para mover en linea recta al objeto de tipo perro.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
