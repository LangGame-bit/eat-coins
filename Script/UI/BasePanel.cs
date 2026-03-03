using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePanel<T> : MonoBehaviour where T : BasePanel<T>
{
    private static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

	private void Awake()
	{
        instance = this as T;
	}

    public void ShowMe()
    {
        this.gameObject.SetActive(true);
    }

    public void HideMe()
    {
		this.gameObject.SetActive(false);
	}
}
