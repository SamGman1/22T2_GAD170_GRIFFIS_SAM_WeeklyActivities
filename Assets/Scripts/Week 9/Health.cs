using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health = 10;

    public void Death()
    {

        if (health <= 0) 
        {

            DestroyGameObject();




        }


    }
    
        
     void DestroyGameObject()
    {
        Destroy(gameObject);
    }

}
