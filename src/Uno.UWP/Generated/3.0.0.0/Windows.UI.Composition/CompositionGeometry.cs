#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionGeometry : global::Windows.UI.Composition.CompositionObject
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float TrimStart
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionGeometry.TrimStart is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20CompositionGeometry.TrimStart");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionGeometry", "float CompositionGeometry.TrimStart");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float TrimOffset
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionGeometry.TrimOffset is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20CompositionGeometry.TrimOffset");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionGeometry", "float CompositionGeometry.TrimOffset");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  float TrimEnd
		{
			get
			{
				throw new global::System.NotImplementedException("The member float CompositionGeometry.TrimEnd is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=float%20CompositionGeometry.TrimEnd");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionGeometry", "float CompositionGeometry.TrimEnd");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionGeometry.TrimEnd.get
		// Forced skipping of method Windows.UI.Composition.CompositionGeometry.TrimEnd.set
		// Forced skipping of method Windows.UI.Composition.CompositionGeometry.TrimOffset.get
		// Forced skipping of method Windows.UI.Composition.CompositionGeometry.TrimOffset.set
		// Forced skipping of method Windows.UI.Composition.CompositionGeometry.TrimStart.get
		// Forced skipping of method Windows.UI.Composition.CompositionGeometry.TrimStart.set
	}
}