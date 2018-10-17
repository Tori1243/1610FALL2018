using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float Value;
    public object ValueObj { get; set; }
}
