using System;
using System.Runtime.InteropServices;

namespace UltralightNet
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	public unsafe delegate void ULDOMReadyCallback__PInvoke__(
		IntPtr user_data,
		IntPtr caller,
		ulong frame_id,
		byte is_main_frame,
		ULString* url
	);
	public delegate void ULDOMReadyCallback(
		IntPtr user_data,
		View caller,
		ulong frame_id,
		bool is_main_frame,
		string url
	);
	public delegate void ULDOMReadyCallbackEvent(
		ulong frameId,
		bool isMainFrame,
		string url
	);
}
