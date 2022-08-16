using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoulderScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Health>() != null)
        {
            Debug.Log("Ouch!");

            collision.gameObject.GetComponent<Health>().health -= 10;
            collision.gameObject.GetComponent<Health>().Death();
            

        }
        


    }
}
