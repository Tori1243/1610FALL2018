using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour {
    public UnityEvent DeathEvent;

    public int health = 100;
    public void ChangeHealth(int NewHealth){
        health = health + NewHealth;
        KillPlayer();
    
    }
    public void KillPlayer()
    {
        if (health < 1 && gameObject.tag == "Player")
        {
            DeathEvent.Invoke();
        }
        else
        {
            return;
        }
    }

}
