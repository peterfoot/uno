#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class MobileBroadbandDeviceServiceTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DeviceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string MobileBroadbandDeviceServiceTriggerDetails.DeviceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20MobileBroadbandDeviceServiceTriggerDetails.DeviceId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Guid DeviceServiceId
		{
			get
			{
				throw new global::System.NotImplementedException("The member Guid MobileBroadbandDeviceServiceTriggerDetails.DeviceServiceId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Guid%20MobileBroadbandDeviceServiceTriggerDetails.DeviceServiceId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Storage.Streams.IBuffer ReceivedData
		{
			get
			{
				throw new global::System.NotImplementedException("The member IBuffer MobileBroadbandDeviceServiceTriggerDetails.ReceivedData is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IBuffer%20MobileBroadbandDeviceServiceTriggerDetails.ReceivedData");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceTriggerDetails.DeviceId.get
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceTriggerDetails.DeviceServiceId.get
		// Forced skipping of method Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceTriggerDetails.ReceivedData.get
	}
}
