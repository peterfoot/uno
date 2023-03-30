#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Resources.Core
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class NamedResource 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Resources.Core.ResourceCandidate> Candidates
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<ResourceCandidate> NamedResource.Candidates is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CResourceCandidate%3E%20NamedResource.Candidates");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Uri Uri
		{
			get
			{
				throw new global::System.NotImplementedException("The member Uri NamedResource.Uri is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Uri%20NamedResource.Uri");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Resources.Core.NamedResource.Uri.get
		// Forced skipping of method Windows.ApplicationModel.Resources.Core.NamedResource.Candidates.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Resources.Core.ResourceCandidate Resolve()
		{
			throw new global::System.NotImplementedException("The member ResourceCandidate NamedResource.Resolve() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ResourceCandidate%20NamedResource.Resolve%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.ApplicationModel.Resources.Core.ResourceCandidate Resolve( global::Windows.ApplicationModel.Resources.Core.ResourceContext resourceContext)
		{
			throw new global::System.NotImplementedException("The member ResourceCandidate NamedResource.Resolve(ResourceContext resourceContext) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ResourceCandidate%20NamedResource.Resolve%28ResourceContext%20resourceContext%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Resources.Core.ResourceCandidate> ResolveAll()
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ResourceCandidate> NamedResource.ResolveAll() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CResourceCandidate%3E%20NamedResource.ResolveAll%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.ApplicationModel.Resources.Core.ResourceCandidate> ResolveAll( global::Windows.ApplicationModel.Resources.Core.ResourceContext resourceContext)
		{
			throw new global::System.NotImplementedException("The member IReadOnlyList<ResourceCandidate> NamedResource.ResolveAll(ResourceContext resourceContext) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CResourceCandidate%3E%20NamedResource.ResolveAll%28ResourceContext%20resourceContext%29");
		}
		#endif
	}
}
