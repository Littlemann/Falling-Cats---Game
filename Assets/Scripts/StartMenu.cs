using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public Button playButton;
    public Button mybutton2;
    private Sprite soundOnImage;
    public Sprite soundOffImage;
    private bool isOn= true;
    public AudioSource audioSource;

    void Start()
    {
       
        playButton.onClick.AddListener(TaskOnClick);
        soundOnImage = mybutton2.image.sprite;
        
    }

    public void ButtonClicked()
    {
        if(isOn)
        {
            mybutton2.image.sprite =soundOffImage;
            isOn = false;
            audioSource.mute =true;

        }
        else
        {
            mybutton2.image.sprite = soundOnImage;
            isOn = true;
            audioSource.mute = false;
        }
    }

    
    void TaskOnClick()
    {
        
        SceneManager.LoadScene(1);
        
        
    }
}
