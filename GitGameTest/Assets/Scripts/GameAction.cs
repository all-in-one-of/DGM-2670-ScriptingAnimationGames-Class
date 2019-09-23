using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class GameAction : ScriptableObject
{
    public UnityAction action;

    public void Raize()
    {
        action?.Invoke(); //if there is nothing listening for Invoke then don't even call it
    }
}
