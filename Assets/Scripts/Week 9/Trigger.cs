using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
    {

        Debug.Log("Hey! " + other.name + " has triggered this trigger!");

        other.transform.position = new Vector3(0, 5, 0);
      
    }
}
