using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NetFwTypeLib
{
	[CompilerGenerated, Guid("9C4C6277-5027-441E-AFAE-CA1F542DA009"), TypeIdentifier]
	[ComImport]
	public interface INetFwRules : IEnumerable
	{
		[DispId(1)]
		int Count
		{
			[DispId(1)]
			[MethodImpl(MethodImplOptions.InternalCall)]
			get;
		}

		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Add([MarshalAs(UnmanagedType.Interface)] [In] INetFwRule rule);
	}
}
