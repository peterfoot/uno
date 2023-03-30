#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Miracast
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MiracastReceiverMediaSourceCreatedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Miracast.MiracastReceiverConnection Connection
		{
			get
			{
				throw new global::System.NotImplementedException("The member MiracastReceiverConnection MiracastReceiverMediaSourceCreatedEventArgs.Connection is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MiracastReceiverConnection%20MiracastReceiverMediaSourceCreatedEventArgs.Connection");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Miracast.MiracastReceiverCursorImageChannelSettings CursorImageChannelSettings
		{
			get
			{
				throw new global::System.NotImplementedException("The member MiracastReceiverCursorImageChannelSettings MiracastReceiverMediaSourceCreatedEventArgs.CursorImageChannelSettings is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MiracastReceiverCursorImageChannelSettings%20MiracastReceiverMediaSourceCreatedEventArgs.CursorImageChannelSettings");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Core.MediaSource MediaSource
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaSource MiracastReceiverMediaSourceCreatedEventArgs.MediaSource is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaSource%20MiracastReceiverMediaSourceCreatedEventArgs.MediaSource");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs.Connection.get
		// Forced skipping of method Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs.MediaSource.get
		// Forced skipping of method Windows.Media.Miracast.MiracastReceiverMediaSourceCreatedEventArgs.CursorImageChannelSettings.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Deferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member Deferral MiracastReceiverMediaSourceCreatedEventArgs.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Deferral%20MiracastReceiverMediaSourceCreatedEventArgs.GetDeferral%28%29");
		}
		#endif
	}
}
