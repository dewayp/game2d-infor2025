using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameManager gameManager;
    public TMP_Text healthText;
    public TMP_Text coinsText;


    public void DisplayHealth()
    {
        healthText.text = gameManager.health.ToString();
    }

    public void DisplayCoins()
    {
        coinsText.text = $"{gameManager.coinsHave.ToString()}/3";
    }

}
