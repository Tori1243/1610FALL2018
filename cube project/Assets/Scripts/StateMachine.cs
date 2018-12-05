using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StateMachine : MonoBehaviour {
    public string GameState;
    public UnityEvent Starting, Playing, Ending, Dying;

	void Start () 
        {
        Run();
        }
    public void ChangeState(string NewState)
        {
           GameState = NewState;
            Run();
        }
	
	
	  
    public void Run() {
       switch (GameState)
        {
            case "Starting":
               Starting.Invoke();
                break;

            case "Dying":
               Dying.Invoke();
                break;

            case "Playing":
               Playing.Invoke();
                break;

            case "Ending":
                Ending.Invoke();
                break;
        }
    }
		
}
