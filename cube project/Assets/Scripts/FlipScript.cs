using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipScript : MonoBehaviour {

    // Use this for initialization
    private Vector3 rot;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {

            rot.y = 180;
            transform.rotation = Quaternion.Euler(rot);


        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {

            rot.y = 0;
            transform.rotation = Quaternion.Euler(rot);


        }

    }
}
