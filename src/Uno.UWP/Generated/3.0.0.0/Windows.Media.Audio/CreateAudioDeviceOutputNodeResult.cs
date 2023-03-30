#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Audio
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class CreateAudioDeviceOutputNodeResult 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Audio.AudioDeviceOutputNode DeviceOutputNode
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceOutputNode CreateAudioDeviceOutputNodeResult.DeviceOutputNode is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AudioDeviceOutputNode%20CreateAudioDeviceOutputNodeResult.DeviceOutputNode");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Audio.AudioDeviceNodeCreationStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member AudioDeviceNodeCreationStatus CreateAudioDeviceOutputNodeResult.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AudioDeviceNodeCreationStatus%20CreateAudioDeviceOutputNodeResult.Status");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Exception ExtendedError
		{
			get
			{
				throw new global::System.NotImplementedException("The member Exception CreateAudioDeviceOutputNodeResult.ExtendedError is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Exception%20CreateAudioDeviceOutputNodeResult.ExtendedError");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceOutputNodeResult.Status.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceOutputNodeResult.DeviceOutputNode.get
		// Forced skipping of method Windows.Media.Audio.CreateAudioDeviceOutputNodeResult.ExtendedError.get
	}
}
