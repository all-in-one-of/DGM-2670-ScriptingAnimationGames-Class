using System;
using UnityEngine;

public class TransformController : MonoBehaviour
{
	public Create_Float speed ;
	
	private void Update()
	{
		var speedVector = new Vector3(speed.value, 0 , 0)*Time.deltaTime;
		transform.Translate(speedVector);
	}
	
}