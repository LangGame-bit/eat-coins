using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginPanel : BasePanel<BeginPanel>
{
    public CustomGUIButton buttonStart;
    public CustomGUIButton buttonExit;
	public CustomGUIButton buttonInstruction;

	private void Start()
	{
		buttonStart.clickEvent += () =>
		{
			SceneManager.LoadScene("GameScene");
		};
		buttonExit.clickEvent += () =>
		{
			Application.Quit();
		};
		buttonInstruction.clickEvent += () =>
		{
			HideMe();
			InstructionPanel.Instance.ShowMe();
		};
	}
}
