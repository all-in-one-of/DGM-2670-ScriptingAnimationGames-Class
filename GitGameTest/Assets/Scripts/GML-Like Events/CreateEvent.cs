using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CreateEvent : MonoBehaviour
{
    public UnityEvent OnCreateEvent;

    private void Awake()
    {
        OnCreateEvent.Invoke();
    }
}
