using System;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class AddValue : ScriptableObject
{
	public FloatData ValueObj;
	public FloatData MaxValue;
	public FloatData MinValue;

	public UnityEvent EventMax;
	public UnityEvent EventMin;

	public void AddValueToObj(FloatData data)
	{
		ValueObj.Value += data.Value;

		if (ValueObj.Value >= MaxValue.Value)
		{
			EventMax.Invoke();
		}

		if (ValueObj.Value <= MinValue.Value) 
		{
			EventMin.Invoke();
		}
	}
}
