﻿using System.Threading.Tasks;
using MUXControlsTestApp.Utilities;
using Private.Infrastructure;
using Uno.UI.RuntimeTests.Helpers;
using Microsoft.UI.Xaml.Controls;

namespace Uno.UI.RuntimeTests.MUX.Microsoft_UI_Xaml_Controls.ProgressRingTests;

[TestClass]
public class ProgressRingTests
{
	[TestMethod]
	[DataRow(true)]
	[DataRow(false)]
	[RunsOnUIThread]
#if __MACOS__
	[Ignore("Currently fails on macOS, part of #9282 epic")]
#endif
	public async Task ProgressRingDefaultHeightShouldBe32(bool useFluent)
	{
		using (useFluent ? StyleHelper.UseFluentStyles() : null)
		{
			var grid = new Grid();
			grid.Width = 100;
			grid.Height = 100;
			var progressRing = new Microsoft.UI.Xaml.Controls.ProgressRing() { IsActive = true };
			grid.Children.Add(progressRing);
			RunOnUIThread.Execute(() => TestServices.WindowHelper.WindowContent = grid);

			await TestServices.WindowHelper.WaitForLoaded(progressRing);

#if __MACOS__
			Assert.AreEqual(16, progressRing.ActualHeight);
			Assert.AreEqual(16, progressRing.ActualWidth);
#else
			Assert.AreEqual(32, progressRing.ActualHeight);
			Assert.AreEqual(32, progressRing.ActualWidth);
#endif
		}
	}
}