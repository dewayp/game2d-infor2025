using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameManager.HealthDecrease(1);
        }
        else if (collision.gameObject.CompareTag("Water"))
        {
            gameManager.HealthDecrease(3);
        }
    }
}
