#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Usb
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class UsbInterruptOutEndpointDescriptor 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  byte EndpointNumber
		{
			get
			{
				throw new global::System.NotImplementedException("The member byte UsbInterruptOutEndpointDescriptor.EndpointNumber is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=byte%20UsbInterruptOutEndpointDescriptor.EndpointNumber");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan Interval
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan UsbInterruptOutEndpointDescriptor.Interval is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20UsbInterruptOutEndpointDescriptor.Interval");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint MaxPacketSize
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint UsbInterruptOutEndpointDescriptor.MaxPacketSize is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20UsbInterruptOutEndpointDescriptor.MaxPacketSize");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Usb.UsbInterruptOutPipe Pipe
		{
			get
			{
				throw new global::System.NotImplementedException("The member UsbInterruptOutPipe UsbInterruptOutEndpointDescriptor.Pipe is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=UsbInterruptOutPipe%20UsbInterruptOutEndpointDescriptor.Pipe");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptOutEndpointDescriptor.MaxPacketSize.get
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptOutEndpointDescriptor.EndpointNumber.get
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptOutEndpointDescriptor.Interval.get
		// Forced skipping of method Windows.Devices.Usb.UsbInterruptOutEndpointDescriptor.Pipe.get
	}
}
