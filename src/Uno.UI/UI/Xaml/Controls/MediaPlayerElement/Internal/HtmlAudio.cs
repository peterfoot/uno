﻿namespace Windows.UI.Xaml.Controls;

internal class HtmlAudio : UIElement
{
	public HtmlAudio() : base("audio")
	{
		SetAttribute("background-color", "transparent");
	}

	internal void SetAnonymousCORS(bool enable)
	{
		if (enable)
		{
			SetAttribute("crossorigin", "anonymous");
		}
		else
		{
			if (string.IsNullOrEmpty(GetAttribute("controls")))
			{
				RemoveAttribute("controls");
			}
		}
	}
}