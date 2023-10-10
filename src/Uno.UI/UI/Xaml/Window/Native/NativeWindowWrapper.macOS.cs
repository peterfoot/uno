﻿using System;
using System.Linq;
using System.Runtime.InteropServices;
using AppKit;
using CoreGraphics;
using Foundation;
using Uno.UI;
using Uno.UI.Controls;
using Uno.UI.Xaml.Core;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Size = Windows.Foundation.Size;

namespace Uno.UI.Xaml.Controls;

internal class NativeWindowWrapper : NativeWindowWrapperBase
{
	private static readonly Lazy<NativeWindowWrapper> _instance = new(() => new NativeWindowWrapper());

	private Uno.UI.Controls.Window _window;

	private Size _previousWindowSize = new Size(-1, -1);

	private RootViewController _mainController;
	private object _windowResizeNotificationObject;

	public NativeWindowWrapper()
	{
		var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled | NSWindowStyle.Miniaturizable;

		var preferredWindowSize = ApplicationView.PreferredLaunchViewSize;
		if (preferredWindowSize != Windows.Foundation.Size.Empty)
		{
			var rect = new CoreGraphics.CGRect(100, 100, (int)preferredWindowSize.Width, (int)preferredWindowSize.Height);
			_window = new Uno.UI.Controls.Window(rect, style, NSBackingStore.Buffered, false);
		}
		else
		{
			var rect = new CoreGraphics.CGRect(100, 100, 1024, 768);
			_window = new Uno.UI.Controls.Window(rect, style, NSBackingStore.Buffered, false);
		}

		_mainController = Windows.UI.Xaml.Window.ViewControllerGenerator?.Invoke() ?? new RootViewController();

		ObserveOrientationAndSize();
	}

	internal static NativeWindowWrapper Instance => _instance.Value;

	internal NSWindow NativeWindow => _window;

	internal RootViewController MainController => _mainController;

	public override void Activate() { }

	public override void Close() { }

	protected override void ShowCore()
	{
		_window.ContentViewController = _mainController;
		_window.Display();
		_window.MakeKeyAndOrderFront(NSApplication.SharedApplication);
	}

	internal Size GetWindowSize()
	{
#if __IOS__
		var nativeFrame = NativeWindow?.Frame ?? CGRect.Empty;

		return new Size(nativeFrame.Width, nativeFrame.Height);
#else //TODO:MZ: Move to macOS file
		var applicationFrameSize = NSScreen.MainScreen.VisibleFrame;
		return new CGSize(applicationFrameSize.Width, applicationFrameSize.Height);
#endif
	}

	internal void OnNativeVisibilityChanged(bool visible) => Visible = visible;

	internal void OnNativeActivated(CoreWindowActivationState state) => ActivationState = state;

	internal void OnNativeClosed() => RaiseClosed();

	internal void RaiseNativeSizeChanged()
	{
		var newWindowSize = new Size(_window.Frame.Width, _window.Frame.Height);
		Bounds = new Rect(default, newWindowSize);
		VisibleBounds = Bounds;
	}

	private void ObserveOrientationAndSize()
	{
		_windowResizeNotificationObject = NSNotificationCenter.DefaultCenter.AddObserver(
			new NSString("NSWindowDidResizeNotification"), ResizeObserver, null);

		RaiseNativeSizeChanged();
	}

	private void ResizeObserver(NSNotification obj) => RaiseNativeSizeChanged();
}
