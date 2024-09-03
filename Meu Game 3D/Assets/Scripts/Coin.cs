using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coin : MonoBehaviour
{
  
   public int giro =50;

   private void OnTriggerEnter(Collider other)
   {
       if(other.gameObject.tag == "Player"){}
       Destroy(gameObject);
   }

   void Update()
    {
       transform.Rotate(Vector3.forward * giro * Time.deltaTime);
    }
}
