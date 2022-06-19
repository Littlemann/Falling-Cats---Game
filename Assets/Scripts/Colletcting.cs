using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Colletcting : MonoBehaviour
{
    public int coins =0;
    public TextMeshProUGUI textCoins;

     void Start() 
    {
       
        coins = PlayerPrefs.GetInt("Coins", coins);            
  
    }
    void Update()
    {
  
        PlayerPrefs.SetInt("Coins", + coins);
    
    }

    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag =="Coin")
        {
            coins ++;
            textCoins.text = coins.ToString();
            other.gameObject.SetActive(false);
        }
    }

  
}
