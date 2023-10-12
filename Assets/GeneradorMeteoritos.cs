using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMeteoritos : MonoBehaviour
{
    public GameObject meteoritoPrefab;
    public float tiempoEntreMeteoritos = 1.0f;
    public float distanciaFrenteNave = 20.0f; // Distancia desde la nave
    public Transform nave; // Asigna la nave desde el Inspector
    public float minX = -16f;
    public float maxX = 16f;
    public float minY = -7f;
    public float maxY = 7f;

    private void Start()
    {
        // Inicia la generaci�n de meteoritos
        StartCoroutine(GenerarMeteoritos());
    }

    IEnumerator GenerarMeteoritos()
    {
        while (true)
        {
            // Calcula una posici�n aleatoria dentro de los l�mites de la c�mara
            Vector3 posicionAleatoria = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), distanciaFrenteNave);

            // Crea un meteorito en la posici�n generada
            GameObject meteorito = Instantiate(meteoritoPrefab, posicionAleatoria, Quaternion.identity);

            yield return new WaitForSeconds(tiempoEntreMeteoritos);
        }
    }
}


