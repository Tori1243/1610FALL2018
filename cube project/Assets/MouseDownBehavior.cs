using UnityEngine.Events;
using UnityEngine;

public class MouseDownBehavior : MonoBehaviour
{
	public UnityEvent MouseDown;
	public UnityEvent MouseUp;
	
	private void OnMouseDown()
	{
		MouseDown.Invoke();
	}
	private void OnMouseup()
	{
		MouseUp.Invoke();
	}
}
