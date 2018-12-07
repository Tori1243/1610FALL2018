using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
    public int AttackAmount;
    public void OnTriggerEnter(Collider other)
    {
        print("attacking");
        if (other.GetComponent<Health>())
            other.GetComponent<Health>().ChangeHealth(AttackAmount);
    }
}
