using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NetFwTypeLib
{
	[CompilerGenerated, Guid("9C27C8DA-189B-4DDE-89F7-8B39A316782C"), TypeIdentifier]
	[ComImport]
	public interface INetFwRule2 : INetFwRule
	{
		[DispId(1)]
		string Name
		{
			[DispId(1)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(3)]
		string ApplicationName
		{
			[DispId(3)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(3)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(11)]
		NET_FW_RULE_DIRECTION_ Direction
		{
			[DispId(11)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(11)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[DispId(14)]
		bool Enabled
		{
			[DispId(14)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(14)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[DispId(16)]
		int Profiles
		{
			[DispId(16)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(16)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		[DispId(18)]
		NET_FW_ACTION_ Action
		{
			[DispId(18)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
			[DispId(18)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			set;
		}

		void _VtblGap1_2();

		void _VtblGap2_14();

		void _VtblGap3_4();

		void _VtblGap4_2();

		void _VtblGap5_2();
	}
}
