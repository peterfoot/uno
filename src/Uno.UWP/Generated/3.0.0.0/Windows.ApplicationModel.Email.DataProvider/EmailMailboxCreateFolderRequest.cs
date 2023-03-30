#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.ApplicationModel.Email.DataProvider
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class EmailMailboxCreateFolderRequest 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string EmailMailboxId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string EmailMailboxCreateFolderRequest.EmailMailboxId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20EmailMailboxCreateFolderRequest.EmailMailboxId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Name
		{
			get
			{
				throw new global::System.NotImplementedException("The member string EmailMailboxCreateFolderRequest.Name is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20EmailMailboxCreateFolderRequest.Name");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string ParentFolderId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string EmailMailboxCreateFolderRequest.ParentFolderId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20EmailMailboxCreateFolderRequest.ParentFolderId");
			}
		}
		#endif
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequest.EmailMailboxId.get
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequest.ParentFolderId.get
		// Forced skipping of method Windows.ApplicationModel.Email.DataProvider.EmailMailboxCreateFolderRequest.Name.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportCompletedAsync( global::Windows.ApplicationModel.Email.EmailFolder folder)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction EmailMailboxCreateFolderRequest.ReportCompletedAsync(EmailFolder folder) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20EmailMailboxCreateFolderRequest.ReportCompletedAsync%28EmailFolder%20folder%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.IAsyncAction ReportFailedAsync( global::Windows.ApplicationModel.Email.EmailMailboxCreateFolderStatus status)
		{
			throw new global::System.NotImplementedException("The member IAsyncAction EmailMailboxCreateFolderRequest.ReportFailedAsync(EmailMailboxCreateFolderStatus status) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IAsyncAction%20EmailMailboxCreateFolderRequest.ReportFailedAsync%28EmailMailboxCreateFolderStatus%20status%29");
		}
		#endif
	}
}
