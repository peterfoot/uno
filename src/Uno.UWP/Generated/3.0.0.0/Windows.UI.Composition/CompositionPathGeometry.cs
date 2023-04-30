#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.UI.Composition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CompositionPathGeometry : global::Windows.UI.Composition.CompositionGeometry
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.UI.Composition.CompositionPath Path
		{
			get
			{
				throw new global::System.NotImplementedException("The member CompositionPath CompositionPathGeometry.Path is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=CompositionPath%20CompositionPathGeometry.Path");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.UI.Composition.CompositionPathGeometry", "CompositionPath CompositionPathGeometry.Path");
			}
		}
		#endif
		// Forced skipping of method Windows.UI.Composition.CompositionPathGeometry.Path.get
		// Forced skipping of method Windows.UI.Composition.CompositionPathGeometry.Path.set
	}
}