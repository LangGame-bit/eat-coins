using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AI : MonoBehaviour
{
	public float velocity = 5;
    public Transform[] pos;
	public GameObject[] coins;
	int i;

	private void Update()
	{
		if (i == pos.Length)
		{
			for (i = 0; i < coins.Length; i++)
			{
				Instantiate(coins[i], pos[i].transform.position, pos[i].transform.rotation);
			}
			this.transform.position = new Vector3(1.5f, 0.5f, -3.3f);
			i = 0;
		}
		this.transform.LookAt(pos[i]);
		this.transform.Translate(Vector3.forward * velocity * Time.deltaTime);
		if (Vector3.Distance(this.transform.position, pos[i].position) < 0.05f)
		{
			i++;
		}
	}
}
