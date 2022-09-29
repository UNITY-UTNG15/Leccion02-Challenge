/*
* Universidad Tecnologica del Norte de Guanajuato
* Autor: Rodríguez Flores Raúl Alberto
* Fecha: 28/09/2022
* Funcion del Script: Este Script ayudara a la creacion de objetos con ayuda de
* los prefabs, en este caso los objetos que se crearan seran de tipo pelota,
* en las cuales se crearan varios objetos de pelotas de diferentes colores.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {   
        // Variable para realizar un arreglo, que ayudara a crear las pelotas de diferentes colores
        int bola = Random.Range(0, 3);
        // Generar índice de bola aleatorio y posición de generación aleatoria
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // Instanciar la bola en una ubicación de generación aleatoria
        Instantiate(ballPrefabs[bola], spawnPos, ballPrefabs[bola].transform.rotation);
    }

}
