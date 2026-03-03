using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPanel : BasePanel<ExitPanel>
{
	public CustomGUIButton buttonExit;
	public CustomGUIButton buttonGoOn;

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
			HideMe();
			GamePanel.Instance.ShowMe();
		};
		HideMe();
	}
}
