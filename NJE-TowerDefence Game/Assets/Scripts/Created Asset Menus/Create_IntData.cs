using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Create_IntData : ScriptableObject
{
    public int value = 0;
    public int maxValue = 2;

    public void UpdateToMaxValue()
    {
        value = maxValue;
    }

    public void UpdateToNumber(int number)
    {
        value = number;
    }
}