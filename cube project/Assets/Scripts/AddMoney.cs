using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour
{

	public int Money = 10;

	// Use this for initialization
	public void AddMoreMoney (int money)
	{
		Money += money;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
