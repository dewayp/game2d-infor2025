using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterMovement : MonoBehaviour
{
    public float speed = 2f; // Kecepatan gerakan
    public float moveDistance = 3f; // Jarak gerakan dari posisi awal

    private Vector3 startPosition;
    private bool movingRight = true;

    void Start()
    {
        // Menyimpan posisi awal GameObject
        startPosition = transform.position;
    }

    void Update()
    {
        // Menggerakkan GameObject ke kanan atau kiri
        if (movingRight)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            if (transform.position.x >= startPosition.x + moveDistance)
            {
                transform.position = startPosition;
            }
        }
    }
}