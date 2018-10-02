using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpChecker : MonoBehaviour
{

    public PowerUp_SO powerUp;
    public string nametocheck;
    public void Start()
    {
        CheckPowerUp();
    }
    public void CheckPowerUp(){
        if (powerUp.powerupName == nametocheck){
            print("Name Matches!");
        }
        else {
            print("Name Does Not Match!");
        }
    }
}
 
