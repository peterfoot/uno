﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

namespace Uno.UI.Tests.Windows_UI_Xaml;

[TestClass]
public class Given_Window
{
#if WINUI_WINDOWING
	[TestMethod]
	public void New_Window_Becomes_Current()
	{
		// This test expects the created Window to be the first window set.
		// So for it to pass reliably, we need to cleanup current window so that
		// we guarantee that the new window becomes "Current".
		Window.CleanupCurrentForTestsOnly();

		var window = new Windows.UI.Xaml.Window();
		window.Activate();
		Assert.AreEqual(window, Windows.UI.Xaml.Window.Current);
	}
#endif

#if !WINUI_WINDOWING
	[TestMethod]
	public void New_Window_Does_Not_Override_Current()
	{
		var app = UnitTestsApp.App.EnsureApplication();

		Windows.UI.Xaml.Window.InitializeWindowCurrent();
		var existingCurrent = Windows.UI.Xaml.Window.Current;
		var window = new Windows.UI.Xaml.Window();
		window.Activate();
		Assert.AreEqual(existingCurrent, Windows.UI.Xaml.Window.Current);
	}
#endif
}
