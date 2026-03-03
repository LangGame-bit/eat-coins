using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRemove : MonoBehaviour
{
	private void Start()
	{
		Destroy(this.gameObject, 2);
	}
}
