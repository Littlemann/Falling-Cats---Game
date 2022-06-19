using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KillPlayer : MonoBehaviour
{   
    
    public GameObject deathParticule;
    public Rigidbody2D myrigibody;
    public float respawntime=1f;
    
    
    
    
    void Start()
    {
        myrigibody = GetComponent<Rigidbody2D>();
        
        
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag =="Trap")
        {
           
            Instantiate (deathParticule, transform.position, transform.rotation);
            this.gameObject.SetActive(false);
            Invoke("EndGame",respawntime);
              
        }
    }

    public void EndGame()
    { 
    
     
     SceneManager.LoadScene(4);
    
    }


 

    


   

}
