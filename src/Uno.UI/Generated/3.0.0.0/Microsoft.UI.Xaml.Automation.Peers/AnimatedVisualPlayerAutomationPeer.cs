#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Microsoft.UI.Xaml.Automation.Peers
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AnimatedVisualPlayerAutomationPeer : global::Microsoft.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AnimatedVisualPlayerAutomationPeer( global::Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer owner) : base(owner)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Microsoft.UI.Xaml.Automation.Peers.AnimatedVisualPlayerAutomationPeer", "AnimatedVisualPlayerAutomationPeer.AnimatedVisualPlayerAutomationPeer(AnimatedVisualPlayer owner)");
		}
		#endif
		// Forced skipping of method Microsoft.UI.Xaml.Automation.Peers.AnimatedVisualPlayerAutomationPeer.AnimatedVisualPlayerAutomationPeer(Microsoft.UI.Xaml.Controls.AnimatedVisualPlayer)
	}
}