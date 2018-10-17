using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ValueChange : ScriptableObject
{

	public FloatData Data;

	public void AddValue(FloatData obj)
	{
		Data.Value += obj.Value;
	}

	public void SubtractValue(FloatData obj)
	{
		Data.Value -= obj.Value;
	}
}
