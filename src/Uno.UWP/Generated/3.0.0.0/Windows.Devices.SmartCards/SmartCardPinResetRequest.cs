#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.SmartCards
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SmartCardPinResetRequest 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer Challenge
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer SmartCardPinResetRequest.Challenge is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IBuffer%20SmartCardPinResetRequest.Challenge");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.DateTimeOffset Deadline
		{
			get
			{
				throw new global::System.NotImplementedException("The member DateTimeOffset SmartCardPinResetRequest.Deadline is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=DateTimeOffset%20SmartCardPinResetRequest.Deadline");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.SmartCards.SmartCardPinResetRequest.Challenge.get
		// Forced skipping of method Windows.Devices.SmartCards.SmartCardPinResetRequest.Deadline.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.SmartCards.SmartCardPinResetDeferral GetDeferral()
		{
			throw new global::System.NotImplementedException("The member SmartCardPinResetDeferral SmartCardPinResetRequest.GetDeferral() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SmartCardPinResetDeferral%20SmartCardPinResetRequest.GetDeferral%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void SetResponse( global::Windows.Storage.Streams.IBuffer response)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Devices.SmartCards.SmartCardPinResetRequest", "void SmartCardPinResetRequest.SetResponse(IBuffer response)");
		}
		#endif
	}
}
