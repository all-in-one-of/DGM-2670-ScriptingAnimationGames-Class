using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 0f;
    public float maxValue = 1f;

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

    public void UpdateValueLimitZero(float amount)
    {
        if ((value + amount) > 0)
        {
            AddValue(amount);
        }
        else
        {
            value = 0;
        }
    }

    public void UpdateValueLimitZeroAndMaxValue(float amount)
    {
        if ((value + amount) > 0 && (value + amount) < maxValue)
        {
            AddValue(amount);
        }
        else if ((value + amount) <= 0)
        {
            value = 0;
        }
        else if ((value + amount) >= maxValue)
        {
            value = maxValue;
        }
    }
}
