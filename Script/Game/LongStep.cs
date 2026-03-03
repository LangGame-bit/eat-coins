using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongStep : MonoBehaviour
{
	[HideInInspector]public bool end;
	[HideInInspector] public bool begin;
	public float velocity;
	[HideInInspector] public Vector3 v;
	private Playerobj player;

	private void Start()
	{
		v = new Vector3(0, 0, 0);
	}

	private void Update()
	{
		if (begin == true && end == false)
		{
			v.y += velocity * Time.deltaTime;
			player.transform.eulerAngles = v;
			if (v.y >= 90)
			{
				end = true;
			}
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.CompareTag("Player") && begin == false)
		{
			player = collision.transform.GetComponent<Playerobj>();
			begin = true;
		}
	}
}
