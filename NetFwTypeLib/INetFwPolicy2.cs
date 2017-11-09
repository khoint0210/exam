using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NetFwTypeLib
{
	[CompilerGenerated, Guid("98325047-C671-4174-8D81-DEFCD3F03186"), TypeIdentifier]
	[ComImport]
	public interface INetFwPolicy2
	{
		[DispId(1)]
		int CurrentProfileTypes
		{
			[DispId(1)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(7)]
		INetFwRules Rules
		{
			[DispId(7)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[DispId(12)]
		NET_FW_ACTION_ DefaultInboundAction
		{
			[DispId(12)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(12)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[DispId(13)]
		NET_FW_ACTION_ DefaultOutboundAction
		{
			[DispId(13)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(13)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		void _VtblGap1_10();

		void _VtblGap2_3();

		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RestoreLocalFirewallDefaults();
	}
}
