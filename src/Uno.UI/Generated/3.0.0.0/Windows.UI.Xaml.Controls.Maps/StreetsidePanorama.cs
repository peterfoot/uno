#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Xaml.Controls.Maps
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class StreetsidePanorama : global::Windows.UI.Xaml.DependencyObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Geolocation.Geopoint Location
		{
			get
			{
				throw new global::System.NotImplementedException("The member Geopoint StreetsidePanorama.Location is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Geopoint%20StreetsidePanorama.Location");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Xaml.Controls.Maps.StreetsidePanorama.Location.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.UI.Xaml.Controls.Maps.StreetsidePanorama> FindNearbyAsync( global::Windows.Devices.Geolocation.Geopoint location)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StreetsidePanorama> StreetsidePanorama.FindNearbyAsync(Geopoint location) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStreetsidePanorama%3E%20StreetsidePanorama.FindNearbyAsync%28Geopoint%20location%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<global::Windows.UI.Xaml.Controls.Maps.StreetsidePanorama> FindNearbyAsync( global::Windows.Devices.Geolocation.Geopoint location,  double radiusInMeters)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<StreetsidePanorama> StreetsidePanorama.FindNearbyAsync(Geopoint location, double radiusInMeters) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3CStreetsidePanorama%3E%20StreetsidePanorama.FindNearbyAsync%28Geopoint%20location%2C%20double%20radiusInMeters%29");
		}
		#endif
	}
}
