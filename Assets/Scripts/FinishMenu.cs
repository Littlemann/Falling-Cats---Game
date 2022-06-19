using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;


public class FinishMenu : MonoBehaviour
{   
    public int coins =0;
    public Button playAgain;
    public Button menuButton;
    public Button settings;
    public TextMeshProUGUI textCoins;
    
    void Start()
    {
        coins = coins +1;
        playAgain.onClick.AddListener(TaskOnClickPlay);
        menuButton.onClick.AddListener(TaskOnClickMenu);
        coins = PlayerPrefs.GetInt("Coins", coins);
         
        
    }
    void Update()
    {
         PlayerPrefs.SetInt("Coins", + coins);
         textCoins.text = coins.ToString();
         PlayerPrefs.DeleteAll();
         
    }

    void TaskOnClickPlay()
    {   
        SceneManager.LoadScene(1);
          
    }
    void TaskOnClickMenu()
    {   
        SceneManager.LoadScene(0);
          
    }

}   

