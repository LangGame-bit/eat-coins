using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2;
	public float speed;
	private bool goTo1 = true;
	private float playerSpeed;
	private bool onPlatform;
	private Playerobj player;

	private void Update()
	{
		if (goTo1)
		{
			this.transform.Translate(Vector3.right * speed * Time.deltaTime);
			if (Vector3.Distance(this.transform.position, pos1.position) < 0.05f)
			{
				goTo1 = false;
			}
		}
		else
		{
			this.transform.Translate(Vector3.right * -speed * Time.deltaTime);
			if (Vector3.Distance(this.transform.position, pos2.position) < 0.05f)
			{
				goTo1 = true;
			}
		}
		if (onPlatform)
		{
			playerSpeed = goTo1 ? speed : -speed;
			player.transform.Translate(Vector3.right *  playerSpeed * Time.deltaTime);
		}
	}

	// 让平台带着主玩家移动
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.CompareTag("Player"))
		{
			onPlatform = true;
			player = collision.transform.GetComponent<Playerobj>();
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if(collision.transform.CompareTag("Player"))
		{
			onPlatform = false;
		}
	}
}
