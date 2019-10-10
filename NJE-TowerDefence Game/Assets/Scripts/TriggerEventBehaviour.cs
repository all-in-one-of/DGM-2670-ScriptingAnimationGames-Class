using UnityEngine;
using UnityEngine.Events;

public class TriggerEventBehaviour : MonoBehaviour
{
	public UnityEvent TriggerEnterEvent;
	public UnityEvent TriggerExitEvent;
	
	private void OnTriggerEnter(Collider self)
	{
		TriggerEnterEvent.Invoke();
	}
}