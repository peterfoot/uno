#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.SpeechRecognition
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class SpeechContinuousRecognitionCompletedEventArgs 
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.SpeechRecognition.SpeechRecognitionResultStatus Status
		{
			get
			{
				throw new global::System.NotImplementedException("The member SpeechRecognitionResultStatus SpeechContinuousRecognitionCompletedEventArgs.Status is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=SpeechRecognitionResultStatus%20SpeechContinuousRecognitionCompletedEventArgs.Status");
			}
		}
		#endif
		// Forced skipping of method Windows.Media.SpeechRecognition.SpeechContinuousRecognitionCompletedEventArgs.Status.get
	}
}
