#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Geolocation
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class GeovisitTriggerDetails 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Geolocation.Geovisit> ReadReports()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<Geovisit> GeovisitTriggerDetails.ReadReports() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CGeovisit%3E%20GeovisitTriggerDetails.ReadReports%28%29");
		}
		#endif
	}
}
