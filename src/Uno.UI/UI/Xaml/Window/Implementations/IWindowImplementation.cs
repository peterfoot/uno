﻿#nullable enable

using Microsoft.UI.Xaml;
using Windows.Foundation;
using Windows.UI.Core;

#if !HAS_UNO_WINUI
using Windows.UI.Xaml;
#endif

namespace Uno.UI.Xaml.Controls;

internal interface IWindowImplementation
{
	bool Visible { get; }

	XamlRoot? XamlRoot { get; }

	Rect Bounds { get; }

	CoreWindow? CoreWindow { get; }

	UIElement? Content { get; set; }

	event WindowActivatedEventHandler? Activated;

	event TypedEventHandler<object, WindowEventArgs>? Closed;

	event WindowSizeChangedEventHandler? SizeChanged;

	event WindowVisibilityChangedEventHandler? VisibilityChanged;

	void Activate();

	void Close();
}
