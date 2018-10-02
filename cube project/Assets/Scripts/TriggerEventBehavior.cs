using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent Enable;
    public UnityEvent Trigger;
    
    void OnEnable()
    {
        Enable.Invoke();
    }
    
    void OnTriggerEnter()
    {
        Trigger.Invoke();
    }
}

