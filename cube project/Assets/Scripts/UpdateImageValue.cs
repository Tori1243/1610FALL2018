using UnityEngine;
using UnityEngine.UI;

public class UpdateImageValue : MonoBehaviour
{

	public FloatData Data;
	private Image image;
	
	
	// Use this for initialization
	void Start ()
	{
		image = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		image.fillAmount = Data.Value;
		
	}
}
