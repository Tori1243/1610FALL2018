using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillEnemy : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Health>())
        {
            if(other.GetComponent<Health>().health < 0)
            Destroy(other.gameObject);
            Debug.Log("It works");
        }
    }

    
    
}