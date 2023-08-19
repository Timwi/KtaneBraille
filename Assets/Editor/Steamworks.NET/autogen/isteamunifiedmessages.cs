// This file is provided under The MIT License as part of Steamworks.NET.
// Copyright (c) 2013-2015 Riley Labrecque
// Please see the included LICENSE.txt for additional information.

// This file is automatically generated.
// Changes to this file will be reverted when you update Steamworks.NET

#pragma warning disable 436
using System;
using System.Runtime.InteropServices;

namespace Steamworks {
	public static class SteamUnifiedMessages {
		/// <summary>
		/// <para> Sends a service method (in binary serialized form) using the Steam Client.</para>
		/// <para> Returns a unified message handle (k_InvalidUnifiedMessageHandle if could not send the message).</para>
		/// </summary>
		public static ClientUnifiedMessageHandle SendMethod(string pchServiceMethod, byte[] pRequestBuffer, uint unRequestBufferSize, ulong unContext) {
			InteropHelp.TestIfAvailableClient();
			using (var pchServiceMethod2 = new InteropHelp.UTF8StringHandle(pchServiceMethod)) {
				return (ClientUnifiedMessageHandle)NativeMethods.ISteamUnifiedMessages_SendMethod(pchServiceMethod2, pRequestBuffer, unRequestBufferSize, unContext);
			}
		}

		/// <summary>
		/// <para> Gets the size of the response and the EResult. Returns false if the response is not ready yet.</para>
		/// </summary>
		public static bool GetMethodResponseInfo(ClientUnifiedMessageHandle hHandle, out uint punResponseSize, out EResult peResult) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_GetMethodResponseInfo(hHandle, out punResponseSize, out peResult);
		}

		/// <summary>
		/// <para> Gets a response in binary serialized form (and optionally release the corresponding allocated memory).</para>
		/// </summary>
		public static bool GetMethodResponseData(ClientUnifiedMessageHandle hHandle, byte[] pResponseBuffer, uint unResponseBufferSize, bool bAutoRelease) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_GetMethodResponseData(hHandle, pResponseBuffer, unResponseBufferSize, bAutoRelease);
		}

		/// <summary>
		/// <para> Releases the message and its corresponding allocated memory.</para>
		/// </summary>
		public static bool ReleaseMethod(ClientUnifiedMessageHandle hHandle) {
			InteropHelp.TestIfAvailableClient();
			return NativeMethods.ISteamUnifiedMessages_ReleaseMethod(hHandle);
		}

		/// <summary>
		/// <para> Sends a service notification (in binary serialized form) using the Steam Client.</para>
		/// <para> Returns true if the notification was sent successfully.</para>
		/// </summary>
		public static bool SendNotification(string pchServiceNotification, byte[] pNotificationBuffer, uint unNotificationBufferSize) {
			InteropHelp.TestIfAvailableClient();
			using (var pchServiceNotification2 = new InteropHelp.UTF8StringHandle(pchServiceNotification)) {
				return NativeMethods.ISteamUnifiedMessages_SendNotification(pchServiceNotification2, pNotificationBuffer, unNotificationBufferSize);
			}
		}
	}
}