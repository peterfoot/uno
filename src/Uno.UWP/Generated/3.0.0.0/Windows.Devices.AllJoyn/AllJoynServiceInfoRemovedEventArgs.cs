#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.AllJoyn
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AllJoynServiceInfoRemovedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string UniqueName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AllJoynServiceInfoRemovedEventArgs.UniqueName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20AllJoynServiceInfoRemovedEventArgs.UniqueName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AllJoynServiceInfoRemovedEventArgs( string uniqueName) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.AllJoyn.AllJoynServiceInfoRemovedEventArgs", "AllJoynServiceInfoRemovedEventArgs.AllJoynServiceInfoRemovedEventArgs(string uniqueName)");
		}
		#endif
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfoRemovedEventArgs.AllJoynServiceInfoRemovedEventArgs(string)
		// Forced skipping of method Windows.Devices.AllJoyn.AllJoynServiceInfoRemovedEventArgs.UniqueName.get
	}
}
