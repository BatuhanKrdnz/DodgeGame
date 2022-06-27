using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int i = 0;
   private void OnCollisionEnter(Collision other) 
   {  
       if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Ground")
       {
           i++;
           Debug.Log("You hit the walls " + i + " time(s)!!");
       }
       
   }
}
