#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class AudioFrame : global::Windows.Media.IMediaFrame,global::System.IDisposable
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan? SystemRelativeTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? AudioFrame.SystemRelativeTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%3F%20AudioFrame.SystemRelativeTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.AudioFrame", "TimeSpan? AudioFrame.SystemRelativeTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan? RelativeTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? AudioFrame.RelativeTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%3F%20AudioFrame.RelativeTime");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.AudioFrame", "TimeSpan? AudioFrame.RelativeTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsDiscontinuous
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AudioFrame.IsDiscontinuous is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20AudioFrame.IsDiscontinuous");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.AudioFrame", "bool AudioFrame.IsDiscontinuous");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan? Duration
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? AudioFrame.Duration is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%3F%20AudioFrame.Duration");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.AudioFrame", "TimeSpan? AudioFrame.Duration");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Foundation.Collections.IPropertySet ExtendedProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IPropertySet AudioFrame.ExtendedProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IPropertySet%20AudioFrame.ExtendedProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsReadOnly
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool AudioFrame.IsReadOnly is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20AudioFrame.IsReadOnly");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string Type
		{
			get
			{
				throw new global::System.NotImplementedException("The member string AudioFrame.Type is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20AudioFrame.Type");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public AudioFrame( uint capacity) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.AudioFrame", "AudioFrame.AudioFrame(uint capacity)");
		}
		#endif
		// Forced skipping of method Windows.Media.AudioFrame.AudioFrame(uint)
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.AudioBuffer LockBuffer( global::Windows.Media.AudioBufferAccessMode mode)
		{
			throw new global::System.NotImplementedException("The member AudioBuffer AudioFrame.LockBuffer(AudioBufferAccessMode mode) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AudioBuffer%20AudioFrame.LockBuffer%28AudioBufferAccessMode%20mode%29");
		}
		#endif
		// Forced skipping of method Windows.Media.AudioFrame.Type.get
		// Forced skipping of method Windows.Media.AudioFrame.IsReadOnly.get
		// Forced skipping of method Windows.Media.AudioFrame.RelativeTime.set
		// Forced skipping of method Windows.Media.AudioFrame.RelativeTime.get
		// Forced skipping of method Windows.Media.AudioFrame.SystemRelativeTime.set
		// Forced skipping of method Windows.Media.AudioFrame.SystemRelativeTime.get
		// Forced skipping of method Windows.Media.AudioFrame.Duration.set
		// Forced skipping of method Windows.Media.AudioFrame.Duration.get
		// Forced skipping of method Windows.Media.AudioFrame.IsDiscontinuous.set
		// Forced skipping of method Windows.Media.AudioFrame.IsDiscontinuous.get
		// Forced skipping of method Windows.Media.AudioFrame.ExtendedProperties.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void Dispose()
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.AudioFrame", "void AudioFrame.Dispose()");
		}
		#endif
		// Processing: Windows.Media.IMediaFrame
		// Processing: System.IDisposable
	}
}
