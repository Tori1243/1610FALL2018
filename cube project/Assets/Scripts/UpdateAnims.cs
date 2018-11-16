using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateAnims : MonoBehaviour
{
	private Animator anims;
	public float speed;
	
	// Use this for initialization
	void Start ()
	{
		anims = GetComponent<Animator>();
	}	
	// Update is called once per frame
	void Update () {
		anims.SetFloat("Speed", speed);	
	}
}
