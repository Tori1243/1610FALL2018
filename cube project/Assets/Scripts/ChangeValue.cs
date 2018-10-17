using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class ChangeValue : ScriptableObject
{
	public FloatData ValueObj;
	public FloatData MaxValue;
	public FloatData MinValue;

	public UnityEvent EventMax;
	public UnityEvent EventMin;

	public void AddValueToObject(FloatData data)

	{
		ValueObj.Value += data.Value;
	}

	public void SubtractValue(FloatData data)
	{
		ValueObj.Value -= data.Value;
	}
	
	public void MultiplyValueBy(FloatData data)
	{
		ValueObj.Value *= data.Value;
	

	}

	public void DivideValueBy(FloatData data)
	{
		if (ValueObj.Value != 0.0F)
		{
			ValueObj.Value /= data.Value;
		}
	}
}
