using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMovements : MonoBehaviour
{
    public Button mybutton;
    private bool moveRight = true;
    private bool buttonDown = false;
    public Rigidbody2D myrigibody;
    private float speed;
   
    
    void Start()
    {
        myrigibody = GetComponent<Rigidbody2D>();
        speed =10f;
        
       
        
       
    }
    void Trasnparent() 
    {
        Color col = GetComponent<Image>().color;
        col.a = 0;
        GetComponent<Image>().color = col;
    }
    
    public void ButtonIsDown()
     {
         buttonDown = true;
     }
 
    public void ButtonIsUp()
     {
         buttonDown = false;
     }
     
    public void SwitchDirection()
     {
          moveRight = !moveRight;
          
     }
     
    void Update()
     {

         if (buttonDown && moveRight)
         {
             
             transform.Translate(Vector3.right * Time.deltaTime * speed);
             
            
                      
         } 
         else if (buttonDown) 
         {
             
             transform.Translate(Vector3.left * Time.deltaTime * speed);
             
            
             
             
         }
          
         
     }

     

        
}
