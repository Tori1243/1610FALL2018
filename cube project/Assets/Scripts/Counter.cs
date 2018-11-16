using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter: MonoBehaviour {

    private Text counterLabel;

	// Use this for initialization
    IEnumerator Start () {
        counterLabel = GetComponent<Text>();
        counterLabel.text = "3";
        yield return new WaitForSeconds(1);
        counterLabel.text = "2";
        yield return new WaitForSeconds(1);
        counterLabel.text = "1";
        yield return new WaitForSeconds(1);
        counterLabel.text = "GO!";
        yield return new WaitForSeconds(1);
        counterLabel.text = "";

    }
	
}
