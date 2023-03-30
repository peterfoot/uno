#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Networking.Vpn
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class VpnManagementAgent 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public VpnManagementAgent() 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Networking.Vpn.VpnManagementAgent", "VpnManagementAgent.VpnManagementAgent()");
		}
		#endif
		// Forced skipping of method Windows.Networking.Vpn.VpnManagementAgent.VpnManagementAgent()
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> AddProfileFromXmlAsync( string xml)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.AddProfileFromXmlAsync(string xml) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.AddProfileFromXmlAsync%28string%20xml%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> AddProfileFromObjectAsync( global::Windows.Networking.Vpn.IVpnProfile profile)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.AddProfileFromObjectAsync(IVpnProfile profile) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.AddProfileFromObjectAsync%28IVpnProfile%20profile%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> UpdateProfileFromXmlAsync( string xml)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.UpdateProfileFromXmlAsync(string xml) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.UpdateProfileFromXmlAsync%28string%20xml%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> UpdateProfileFromObjectAsync( global::Windows.Networking.Vpn.IVpnProfile profile)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.UpdateProfileFromObjectAsync(IVpnProfile profile) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.UpdateProfileFromObjectAsync%28IVpnProfile%20profile%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::System.Collections.Generic.IReadOnlyList<global::Windows.Networking.Vpn.IVpnProfile>> GetProfilesAsync()
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<IReadOnlyList<IVpnProfile>> VpnManagementAgent.GetProfilesAsync() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CIReadOnlyList%3CIVpnProfile%3E%3E%20VpnManagementAgent.GetProfilesAsync%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> DeleteProfileAsync( global::Windows.Networking.Vpn.IVpnProfile profile)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.DeleteProfileAsync(IVpnProfile profile) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.DeleteProfileAsync%28IVpnProfile%20profile%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> ConnectProfileAsync( global::Windows.Networking.Vpn.IVpnProfile profile)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.ConnectProfileAsync(IVpnProfile profile) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.ConnectProfileAsync%28IVpnProfile%20profile%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> ConnectProfileWithPasswordCredentialAsync( global::Windows.Networking.Vpn.IVpnProfile profile,  global::Windows.Security.Credentials.PasswordCredential passwordCredential)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.ConnectProfileWithPasswordCredentialAsync(IVpnProfile profile, PasswordCredential passwordCredential) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.ConnectProfileWithPasswordCredentialAsync%28IVpnProfile%20profile%2C%20PasswordCredential%20passwordCredential%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncOperation<global::Windows.Networking.Vpn.VpnManagementErrorStatus> DisconnectProfileAsync( global::Windows.Networking.Vpn.IVpnProfile profile)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<VpnManagementErrorStatus> VpnManagementAgent.DisconnectProfileAsync(IVpnProfile profile) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CVpnManagementErrorStatus%3E%20VpnManagementAgent.DisconnectProfileAsync%28IVpnProfile%20profile%29");
		}
		#endif
	}
}
