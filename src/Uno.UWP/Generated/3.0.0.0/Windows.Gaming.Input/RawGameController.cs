#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Gaming.Input
{
	#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
	[global::Uno.NotImplemented]
	#endif
	public  partial class RawGameController : global::Windows.Gaming.Input.IGameController,global::Windows.Gaming.Input.IGameControllerBatteryInfo
	{
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Gaming.Input.Headset Headset
		{
			get
			{
				throw new global::System.NotImplementedException("The member Headset RawGameController.Headset is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=Headset%20RawGameController.Headset");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsWireless
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool RawGameController.IsWireless is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20RawGameController.IsWireless");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.System.User User
		{
			get
			{
				throw new global::System.NotImplementedException("The member User RawGameController.User is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=User%20RawGameController.User");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int AxisCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int RawGameController.AxisCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20RawGameController.AxisCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int ButtonCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int RawGameController.ButtonCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20RawGameController.ButtonCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Gaming.Input.ForceFeedback.ForceFeedbackMotor> ForceFeedbackMotors
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<ForceFeedbackMotor> RawGameController.ForceFeedbackMotors is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CForceFeedbackMotor%3E%20RawGameController.ForceFeedbackMotors");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ushort HardwareProductId
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort RawGameController.HardwareProductId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ushort%20RawGameController.HardwareProductId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ushort HardwareVendorId
		{
			get
			{
				throw new global::System.NotImplementedException("The member ushort RawGameController.HardwareVendorId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ushort%20RawGameController.HardwareVendorId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  int SwitchCount
		{
			get
			{
				throw new global::System.NotImplementedException("The member int RawGameController.SwitchCount is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=int%20RawGameController.SwitchCount");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string DisplayName
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RawGameController.DisplayName is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20RawGameController.DisplayName");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  string NonRoamableId
		{
			get
			{
				throw new global::System.NotImplementedException("The member string RawGameController.NonRoamableId is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=string%20RawGameController.NonRoamableId");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.Collections.Generic.IReadOnlyList<global::Windows.Devices.Haptics.SimpleHapticsController> SimpleHapticsControllers
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<SimpleHapticsController> RawGameController.SimpleHapticsControllers is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CSimpleHapticsController%3E%20RawGameController.SimpleHapticsControllers");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::System.Collections.Generic.IReadOnlyList<global::Windows.Gaming.Input.RawGameController> RawGameControllers
		{
			get
			{
				throw new global::System.NotImplementedException("The member IReadOnlyList<RawGameController> RawGameController.RawGameControllers is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=IReadOnlyList%3CRawGameController%3E%20RawGameController.RawGameControllers");
			}
		}
		#endif
		// Forced skipping of method Windows.Gaming.Input.RawGameController.AxisCount.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.ButtonCount.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.ForceFeedbackMotors.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.HardwareProductId.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.HardwareVendorId.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.SwitchCount.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Gaming.Input.GameControllerButtonLabel GetButtonLabel( int buttonIndex)
		{
			throw new global::System.NotImplementedException("The member GameControllerButtonLabel RawGameController.GetButtonLabel(int buttonIndex) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=GameControllerButtonLabel%20RawGameController.GetButtonLabel%28int%20buttonIndex%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  ulong GetCurrentReading( bool[] buttonArray,  global::Windows.Gaming.Input.GameControllerSwitchPosition[] switchArray,  double[] axisArray)
		{
			throw new global::System.NotImplementedException("The member ulong RawGameController.GetCurrentReading(bool[] buttonArray, GameControllerSwitchPosition[] switchArray, double[] axisArray) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=ulong%20RawGameController.GetCurrentReading%28bool%5B%5D%20buttonArray%2C%20GameControllerSwitchPosition%5B%5D%20switchArray%2C%20double%5B%5D%20axisArray%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Gaming.Input.GameControllerSwitchKind GetSwitchKind( int switchIndex)
		{
			throw new global::System.NotImplementedException("The member GameControllerSwitchKind RawGameController.GetSwitchKind(int switchIndex) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=GameControllerSwitchKind%20RawGameController.GetSwitchKind%28int%20switchIndex%29");
		}
		#endif
		// Forced skipping of method Windows.Gaming.Input.RawGameController.HeadsetConnected.add
		// Forced skipping of method Windows.Gaming.Input.RawGameController.HeadsetConnected.remove
		// Forced skipping of method Windows.Gaming.Input.RawGameController.HeadsetDisconnected.add
		// Forced skipping of method Windows.Gaming.Input.RawGameController.HeadsetDisconnected.remove
		// Forced skipping of method Windows.Gaming.Input.RawGameController.UserChanged.add
		// Forced skipping of method Windows.Gaming.Input.RawGameController.UserChanged.remove
		// Forced skipping of method Windows.Gaming.Input.RawGameController.Headset.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.IsWireless.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.User.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Devices.Power.BatteryReport TryGetBatteryReport()
		{
			throw new global::System.NotImplementedException("The member BatteryReport RawGameController.TryGetBatteryReport() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=BatteryReport%20RawGameController.TryGetBatteryReport%28%29");
		}
		#endif
		// Forced skipping of method Windows.Gaming.Input.RawGameController.SimpleHapticsControllers.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.NonRoamableId.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.DisplayName.get
		// Forced skipping of method Windows.Gaming.Input.RawGameController.RawGameControllerAdded.add
		// Forced skipping of method Windows.Gaming.Input.RawGameController.RawGameControllerAdded.remove
		// Forced skipping of method Windows.Gaming.Input.RawGameController.RawGameControllerRemoved.add
		// Forced skipping of method Windows.Gaming.Input.RawGameController.RawGameControllerRemoved.remove
		// Forced skipping of method Windows.Gaming.Input.RawGameController.RawGameControllers.get
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Gaming.Input.RawGameController FromGameController( global::Windows.Gaming.Input.IGameController gameController)
		{
			throw new global::System.NotImplementedException("The member RawGameController RawGameController.FromGameController(IGameController gameController) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=RawGameController%20RawGameController.FromGameController%28IGameController%20gameController%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Gaming.Input.IGameController, global::Windows.Gaming.Input.Headset> HeadsetConnected
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event TypedEventHandler<IGameController, Headset> RawGameController.HeadsetConnected");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event TypedEventHandler<IGameController, Headset> RawGameController.HeadsetConnected");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Gaming.Input.IGameController, global::Windows.Gaming.Input.Headset> HeadsetDisconnected
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event TypedEventHandler<IGameController, Headset> RawGameController.HeadsetDisconnected");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event TypedEventHandler<IGameController, Headset> RawGameController.HeadsetDisconnected");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Gaming.Input.IGameController, global::Windows.System.UserChangedEventArgs> UserChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event TypedEventHandler<IGameController, UserChangedEventArgs> RawGameController.UserChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event TypedEventHandler<IGameController, UserChangedEventArgs> RawGameController.UserChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::System.EventHandler<global::Windows.Gaming.Input.RawGameController> RawGameControllerAdded
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event EventHandler<RawGameController> RawGameController.RawGameControllerAdded");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event EventHandler<RawGameController> RawGameController.RawGameControllerAdded");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static event global::System.EventHandler<global::Windows.Gaming.Input.RawGameController> RawGameControllerRemoved
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event EventHandler<RawGameController> RawGameController.RawGameControllerRemoved");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Gaming.Input.RawGameController", "event EventHandler<RawGameController> RawGameController.RawGameControllerRemoved");
			}
		}
		#endif
		// Processing: Windows.Gaming.Input.IGameController
		// Processing: Windows.Gaming.Input.IGameControllerBatteryInfo
	}
}
