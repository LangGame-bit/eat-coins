using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class InstructionPanel : BasePanel<InstructionPanel>
{
    public CustomGUIButton buttonExit;

	private void Start()
	{
		buttonExit.clickEvent += () =>
		{
			HideMe();
			BeginPanel.Instance.ShowMe();
		};
		HideMe();
	}
}
