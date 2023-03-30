#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Enumeration
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EnclosureLocation 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool InDock
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool EnclosureLocation.InDock is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20EnclosureLocation.InDock");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool InLid
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool EnclosureLocation.InLid is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20EnclosureLocation.InLid");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Enumeration.Panel Panel
		{
			get
			{
				throw new global::System.NotImplementedException("The member Panel EnclosureLocation.Panel is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Panel%20EnclosureLocation.Panel");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  uint RotationAngleInDegreesClockwise
		{
			get
			{
				throw new global::System.NotImplementedException("The member uint EnclosureLocation.RotationAngleInDegreesClockwise is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=uint%20EnclosureLocation.RotationAngleInDegreesClockwise");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Enumeration.EnclosureLocation.InDock.get
		// Forced skipping of method Windows.Devices.Enumeration.EnclosureLocation.InLid.get
		// Forced skipping of method Windows.Devices.Enumeration.EnclosureLocation.Panel.get
		// Forced skipping of method Windows.Devices.Enumeration.EnclosureLocation.RotationAngleInDegreesClockwise.get
	}
}
