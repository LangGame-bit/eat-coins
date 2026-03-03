using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccPanel : BasePanel<SuccPanel>
{
    public CustomGUIButton buttonExit;
    public CustomGUIButton buttonGoOn;
	public CustomGUILabel labelTime;
	public CustomGUILabel labelScore;

	private void Start()
	{
		buttonExit.clickEvent += () =>
		{
			Time.timeScale = 1;
			SceneManager.LoadScene("BeginScene");
		};
		buttonGoOn.clickEvent += () =>
		{
			Time.timeScale = 1;
			SceneManager.LoadScene("GameScene");
		};
		HideMe();
	}
}
