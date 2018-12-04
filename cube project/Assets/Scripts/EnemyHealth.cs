using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour 
{
    public int startingHealth = 100;
    public int currentHealth;

    Animator anim;
    // ParticleSystem hitParticles;
    BoxCollider boxCollider;
    bool isDead;

}


