using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ebac.Core.Singleton;

public class ItemManager : Singleton<ItemManager>
{

    public SOInt coins;
    public SOInt stars;
    public TextMeshProUGUI uiTextCoins;
    public TextMeshProUGUI uiTextStars;



    private void Start()
    {
            Reset();

    }


    private void Reset()
    {
        coins.value = 0;
        stars.value = 0;
        UpdateUI();
    }

    public void AddCoins(int amount = 1)
    {
        coins.value += amount;
        UpdateUI();
    }

    public void AddStars(int amount = 1)
    {
        stars.value += amount;
        UpdateUI();

    }

    private void UpdateUI()
    {
        //uiTextCoins.text = coins.ToString();
        //UIInGameManager.UpdateTextCoins(coins.value.ToString());
    }
    
    
}
