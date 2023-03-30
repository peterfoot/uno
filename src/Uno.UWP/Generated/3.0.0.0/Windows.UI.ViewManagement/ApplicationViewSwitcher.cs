#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.ViewManagement
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class ApplicationViewSwitcher 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> TryShowAsViewModeAsync( int viewId,  global::Windows.UI.ViewManagement.ApplicationViewMode viewMode)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationViewSwitcher.TryShowAsViewModeAsync(int viewId, ApplicationViewMode viewMode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20ApplicationViewSwitcher.TryShowAsViewModeAsync%28int%20viewId%2C%20ApplicationViewMode%20viewMode%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> TryShowAsViewModeAsync( int viewId,  global::Windows.UI.ViewManagement.ApplicationViewMode viewMode,  global::Windows.UI.ViewManagement.ViewModePreferences viewModePreferences)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationViewSwitcher.TryShowAsViewModeAsync(int viewId, ApplicationViewMode viewMode, ViewModePreferences viewModePreferences) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20ApplicationViewSwitcher.TryShowAsViewModeAsync%28int%20viewId%2C%20ApplicationViewMode%20viewMode%2C%20ViewModePreferences%20viewModePreferences%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void DisableSystemViewActivationPolicy()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationViewSwitcher", "void ApplicationViewSwitcher.DisableSystemViewActivationPolicy()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static void DisableShowingMainViewOnActivation()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.ViewManagement.ApplicationViewSwitcher", "void ApplicationViewSwitcher.DisableShowingMainViewOnActivation()");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> TryShowAsStandaloneAsync( int viewId)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationViewSwitcher.TryShowAsStandaloneAsync(int viewId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20ApplicationViewSwitcher.TryShowAsStandaloneAsync%28int%20viewId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> TryShowAsStandaloneAsync( int viewId,  global::Windows.UI.ViewManagement.ViewSizePreference sizePreference)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationViewSwitcher.TryShowAsStandaloneAsync(int viewId, ViewSizePreference sizePreference) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20ApplicationViewSwitcher.TryShowAsStandaloneAsync%28int%20viewId%2C%20ViewSizePreference%20sizePreference%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> TryShowAsStandaloneAsync( int viewId,  global::Windows.UI.ViewManagement.ViewSizePreference sizePreference,  int anchorViewId,  global::Windows.UI.ViewManagement.ViewSizePreference anchorSizePreference)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationViewSwitcher.TryShowAsStandaloneAsync(int viewId, ViewSizePreference sizePreference, int anchorViewId, ViewSizePreference anchorSizePreference) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20ApplicationViewSwitcher.TryShowAsStandaloneAsync%28int%20viewId%2C%20ViewSizePreference%20sizePreference%2C%20int%20anchorViewId%2C%20ViewSizePreference%20anchorSizePreference%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SwitchAsync( int viewId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ApplicationViewSwitcher.SwitchAsync(int viewId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ApplicationViewSwitcher.SwitchAsync%28int%20viewId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SwitchAsync( int toViewId,  int fromViewId)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ApplicationViewSwitcher.SwitchAsync(int toViewId, int fromViewId) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ApplicationViewSwitcher.SwitchAsync%28int%20toViewId%2C%20int%20fromViewId%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction SwitchAsync( int toViewId,  int fromViewId,  global::Windows.UI.ViewManagement.ApplicationViewSwitchingOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ApplicationViewSwitcher.SwitchAsync(int toViewId, int fromViewId, ApplicationViewSwitchingOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ApplicationViewSwitcher.SwitchAsync%28int%20toViewId%2C%20int%20fromViewId%2C%20ApplicationViewSwitchingOptions%20options%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncOperation<bool> PrepareForCustomAnimatedSwitchAsync( int toViewId,  int fromViewId,  global::Windows.UI.ViewManagement.ApplicationViewSwitchingOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncOperation<bool> ApplicationViewSwitcher.PrepareForCustomAnimatedSwitchAsync(int toViewId, int fromViewId, ApplicationViewSwitchingOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncOperation%3Cbool%3E%20ApplicationViewSwitcher.PrepareForCustomAnimatedSwitchAsync%28int%20toViewId%2C%20int%20fromViewId%2C%20ApplicationViewSwitchingOptions%20options%29");
		}
		#endif
	}
}
