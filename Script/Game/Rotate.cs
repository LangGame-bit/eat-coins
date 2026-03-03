using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float velocity = 5;

	private void Update()
	{
		this.transform.Rotate(Vector3.up * velocity * Time.deltaTime, Space.World);
	}
}
