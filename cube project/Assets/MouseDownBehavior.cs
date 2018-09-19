using UnityEngine.Events;
using UnityEngine;

public class MouseDownBehavior : MonoBehaviour
{
	public UnityEvent Event;
	
	private void OnMouseDown()
	{
		Event.Invoke();
	}
}
