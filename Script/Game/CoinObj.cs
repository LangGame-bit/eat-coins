using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinObj : MonoBehaviour
{
    public int value;
    public GameObject eff;

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Instantiate(eff, this.transform.position, this.transform.rotation);
			if (SceneManager.GetActiveScene().name == "GameScene")
			{
				GamePanel.Instance.AddScore(value);
				GamePanel.Instance.coinNum--;
				GamePanel.Instance.labelCoinNum.content.text = "剩余金币：" + GamePanel.Instance.coinNum + "个";
				if (GamePanel.Instance.coinNum == 0)
				{
					Time.timeScale = 0;
					GamePanel.Instance.HideMe();
					SuccPanel.Instance.ShowMe();
					SuccPanel.Instance.labelTime.content.text =
						"时间：" + GamePanel.Instance.labelTimeNum.content.text;
					SuccPanel.Instance.labelScore.content.text =
						"分数：" + GamePanel.Instance.labelScoreNum.content.text;
				}
			}
			Destroy(this.gameObject);
		}
	}
}
