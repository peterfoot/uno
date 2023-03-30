#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UsbConfigurationDescriptor 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte ConfigurationValue
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbConfigurationDescriptor.ConfigurationValue is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=byte%20UsbConfigurationDescriptor.ConfigurationValue");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxPowerMilliamps
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint UsbConfigurationDescriptor.MaxPowerMilliamps is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20UsbConfigurationDescriptor.MaxPowerMilliamps");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool RemoteWakeup
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool UsbConfigurationDescriptor.RemoteWakeup is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20UsbConfigurationDescriptor.RemoteWakeup");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool SelfPowered
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool UsbConfigurationDescriptor.SelfPowered is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20UsbConfigurationDescriptor.SelfPowered");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Usb.UsbConfigurationDescriptor.ConfigurationValue.get
		// Forced skipping of method Windows.Devices.Usb.UsbConfigurationDescriptor.MaxPowerMilliamps.get
		// Forced skipping of method Windows.Devices.Usb.UsbConfigurationDescriptor.SelfPowered.get
		// Forced skipping of method Windows.Devices.Usb.UsbConfigurationDescriptor.RemoteWakeup.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static bool TryParse( global::Windows.Devices.Usb.UsbDescriptor descriptor, out global::Windows.Devices.Usb.UsbConfigurationDescriptor parsed)
		{
			throw new global::System.NotImplementedException("The member bool UsbConfigurationDescriptor.TryParse(UsbDescriptor descriptor, out UsbConfigurationDescriptor parsed) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20UsbConfigurationDescriptor.TryParse%28UsbDescriptor%20descriptor%2C%20out%20UsbConfigurationDescriptor%20parsed%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Devices.Usb.UsbConfigurationDescriptor Parse( global::Windows.Devices.Usb.UsbDescriptor descriptor)
		{
			throw new global::System.NotImplementedException("The member UsbConfigurationDescriptor UsbConfigurationDescriptor.Parse(UsbDescriptor descriptor) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UsbConfigurationDescriptor%20UsbConfigurationDescriptor.Parse%28UsbDescriptor%20descriptor%29");
		}
		#endif
	}
}
