using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMapCamera : MonoBehaviour
{
    public Transform player;
	public float height = 10;
	private Vector3 v;

	private void Update()
	{
		v.x = player.position.x;
		v.y = player.transform.position.y + height;
		v.z = player.position.z;
		this.transform.position = v;
	}
}
