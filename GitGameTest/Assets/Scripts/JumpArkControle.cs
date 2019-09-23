using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class JumpArkControle : ScriptableObject
{
    public float value = 0f;

    public void AddValue(float amount)
    {
        value += amount;
    }
    
    public void MultiplyValue(float amount)
    {
        value *= amount;
    }
    
    public void DivideValue(float amount)
    {
        value /= amount;
    }
    
    public void ChangeValue(float amount)
    {
        value = amount;
    }
}