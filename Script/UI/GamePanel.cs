using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class GamePanel : BasePanel<GamePanel>
{
    public CustomGUILabel labelScoreNum;
    public CustomGUILabel labelTimeNum;
	public CustomGUIButton buttonExit;
	public CustomGUILabel labelCoinNum;
	[HideInInspector] public int life;
    private float nowTime;
	private int score;
	public int coinNum;

	private void Start()
	{
		life = 3;
		buttonExit.clickEvent += () =>
		{
			Time.timeScale = 0;
			HideMe();
			ExitPanel.Instance.ShowMe();
		};
		labelCoinNum.content.text = "剩余金币：" + coinNum + "个";
		HideMe();
	}

	private void Update()
	{
		labelTimeNum.content.text = "";
		nowTime += Time.deltaTime;
		int time = (int)nowTime;
		if (time >= 3600)
		{
			labelTimeNum.content.text += time / 3600 + "时";
			time %= 3600;
		}
		if (time >= 60)
		{
			labelTimeNum.content.text += time / 60 + "分";
			time %= 60;
		}
		if (time >= 0)
		{
			labelTimeNum.content.text += time + "秒";
		}
	}

	public void AddScore(int deltaValue)
	{
		score += deltaValue;
		labelScoreNum.content.text = "";
		labelScoreNum.content.text += score + "分";
	}
}
