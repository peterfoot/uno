#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.System.Threading
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public static partial class ThreadPool 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction RunAsync( global::Windows.System.Threading.WorkItemHandler handler)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ThreadPool.RunAsync(WorkItemHandler handler) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ThreadPool.RunAsync%28WorkItemHandler%20handler%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction RunAsync( global::Windows.System.Threading.WorkItemHandler handler,  global::Windows.System.Threading.WorkItemPriority priority)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ThreadPool.RunAsync(WorkItemHandler handler, WorkItemPriority priority) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ThreadPool.RunAsync%28WorkItemHandler%20handler%2C%20WorkItemPriority%20priority%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Foundation.IAsyncAction RunAsync( global::Windows.System.Threading.WorkItemHandler handler,  global::Windows.System.Threading.WorkItemPriority priority,  global::Windows.System.Threading.WorkItemOptions options)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction ThreadPool.RunAsync(WorkItemHandler handler, WorkItemPriority priority, WorkItemOptions options) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20ThreadPool.RunAsync%28WorkItemHandler%20handler%2C%20WorkItemPriority%20priority%2C%20WorkItemOptions%20options%29");
		}
		#endif
	}
}
