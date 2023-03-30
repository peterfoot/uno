#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.NetworkOperators
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NetworkOperatorTetheringClient 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.HostName> HostNames
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<HostName> NetworkOperatorTetheringClient.HostNames is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CHostName%3E%20NetworkOperatorTetheringClient.HostNames");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string MacAddress
		{
			get
			{
				throw new global::System.NotImplementedException("The member string NetworkOperatorTetheringClient.MacAddress is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20NetworkOperatorTetheringClient.MacAddress");
			}
		}
		#endif
		// Forced skipping of method Windows.Networking.NetworkOperators.NetworkOperatorTetheringClient.MacAddress.get
		// Forced skipping of method Windows.Networking.NetworkOperators.NetworkOperatorTetheringClient.HostNames.get
	}
}
