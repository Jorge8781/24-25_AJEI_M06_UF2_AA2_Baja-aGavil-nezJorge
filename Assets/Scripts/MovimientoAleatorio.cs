using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAleatorio : MonoBehaviour
{
    public float speed = 4;
    float x = 0;
    float z = 0;
    // Velocidad de rotación en grados por segundo
    public float rotationSpeed = 0;
    float y = 0;
    public Rigidbody2D rb;
    void Start()
    {
        Spawn();

        float randomZRotation = Random.Range(0f, 360f);
        transform.eulerAngles = new Vector3(0, 0, randomZRotation);
    }

    void Update()
    {
        Vector3 dir = new Vector3(x, y) * speed * Time.deltaTime;
        transform.position = transform.position + dir;



    }
    void Spawn()
    {





        x = Random.Range(-1.0f, 1.0f);



        y = Random.Range(-1.0f, 1.0f);
    }
}