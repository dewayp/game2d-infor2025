using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject finishPortal;
    public int coinsHave;
    public int health;
    public GameObject losePanel;
    public GameObject winPanel;
    public PlayerMovements playerMovement;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (coinsHave == 3)
        {
            finishPortal.SetActive(true);
        }

        if (health == 0)
        {
            losePanel.SetActive(true);
            playerMovement.enabled = false;
        }
    }


    public void CoinsGet()
    {
        coinsHave++;
    }

    public void HealthDecrease(int decrease)
    {
        health = health - decrease;
    }

    public void Finish()
    {
        winPanel.SetActive(true);
        playerMovement.enabled = false;
    }
}
