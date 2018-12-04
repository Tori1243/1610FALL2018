using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{

    public int Score = 100;
    public float Health = 100f;
   

    public string PlayerName = "Girl";

    public Vector3 Movement;

    public Animation Anims;

    public UnityEvent Event;

}