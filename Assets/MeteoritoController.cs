using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoritoController : MonoBehaviour
{
    public float velocidad;
    public float tiempoDeVida = 10.0f; // Tiempo en segundos antes de destruir el meteorito
    private Rigidbody rb;
    public Fade fade;

    void Start()
    {
        Destroy(gameObject, tiempoDeVida);
        transform.forward = -transform.forward;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Mueve el meteorito a lo largo del eje Z
        transform.Translate(Vector3.forward * velocidad * Time.deltaTime);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            print("impacto");
            fade.FadeHit();
        }
    }
}


