using UnityEngine;
using UnityEngine.SceneManagement;

public class DeadPanel : BasePanel<DeadPanel>
{
	private float nowTime;
	public CustomGUITexture textureHeart;
	public CustomGUILabel labelLife;
	public CustomGUILabel labelWord;
	public Transform player;
	public LongStep longStep;

	private void Start()
	{
		labelWord.content.text = "";
	}

	private void Update()
	{
		nowTime += Time.deltaTime;
		if (nowTime > 3)
		{
			if (GamePanel.Instance.life > 0)
			{
				GamePanel.Instance.ShowMe();
				player.position = new Vector3(0, 1.1f, -35);
				player.transform.eulerAngles = Vector3.zero;
				nowTime = 0;
				longStep.begin = false;
				longStep.end = false;
				longStep.v = Vector3.zero;
				HideMe();
			}
			else
			{
				SceneManager.LoadScene("GameScene");
			}
		}
	}
}