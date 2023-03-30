#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Devices.Sensors
{
	#if false || false || false || false || false || false || false
	[global::Uno.NotImplemented]
	#endif
	public  partial class GyrometerReading 
	{
		// Skipping already declared property AngularVelocityX
		// Skipping already declared property AngularVelocityY
		// Skipping already declared property AngularVelocityZ
		// Skipping already declared property Timestamp
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan? PerformanceCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? GyrometerReading.PerformanceCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%3F%20GyrometerReading.PerformanceCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyDictionary<string, object> Properties
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyDictionary<string, object> GyrometerReading.Properties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyDictionary%3Cstring%2C%20object%3E%20GyrometerReading.Properties");
			}
		}
		#endif
		// Forced skipping of method Windows.Devices.Sensors.GyrometerReading.Timestamp.get
		// Forced skipping of method Windows.Devices.Sensors.GyrometerReading.AngularVelocityX.get
		// Forced skipping of method Windows.Devices.Sensors.GyrometerReading.AngularVelocityY.get
		// Forced skipping of method Windows.Devices.Sensors.GyrometerReading.AngularVelocityZ.get
		// Forced skipping of method Windows.Devices.Sensors.GyrometerReading.PerformanceCount.get
		// Forced skipping of method Windows.Devices.Sensors.GyrometerReading.Properties.get
	}
}
