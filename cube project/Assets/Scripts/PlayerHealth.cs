using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    // public Slider healthSlider;
    // public Image damageImage;
    // public Color FlashColour = new Color(1f, 0f, 0f, 0.1f);

    Animator anim;
    bool isDead;
    bool damaged;

  void Update()
    {
        if(damaged)
        {
            //damageImage.color = flashColour;
        }
        else
        {
            //damageImage.color = Color.Lerp(damagedImage.color, Color.clear, flashSpeedn * Time.deltaTime);
        }
        damaged = false;
    }

    public void TakeDamage (int amount){
        damaged = true;
        currentHealth -= amount;
       //healthSlider.value = currentHealth;

    }

}

