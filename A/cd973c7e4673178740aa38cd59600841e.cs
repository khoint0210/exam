using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace A
{
	internal class cd973c7e4673178740aa38cd59600841e
	{
		public delegate int c06045e9b3447c52c4b733ab4f593f7c6(int Code, int wParam, ref cd973c7e4673178740aa38cd59600841e.c7f17b78c5fed2a8d59350a6a27101cad lParam);

		public struct c7f17b78c5fed2a8d59350a6a27101cad
		{
			public int c1b16106051005d077ac990dc9c5e88e3;

			public int c0a8bd60f501c19c6acf1b9321e793ea2;

			public int ca200e669a920aed90d2d806a8e0036e4;

			public int c4af43eaad25f6542ff2d9cd754d2554d;

			public int cf34e03307d87d72534b62723bf8c4b15;
		}

		private const int cbd82846369793103a435e1ce4fedb4a2 = 13;

		private const int c733711774de7343f3e213632cd9e18ea = 256;

		private const int c8e4a900cb7271f6250b8d0fd902266d5 = 257;

		private const int cb226477227e6f2ea0579c32f01154d17 = 260;

		private const int cf913e23d760b7e798825fbd32755840d = 261;

		private cd973c7e4673178740aa38cd59600841e.c06045e9b3447c52c4b733ab4f593f7c6 cb1874f7bccadbab9b5efb5deb4f13582;

		public List<Keys> c7669885977e29b76a528e233c632949b = new List<Keys>();

		private IntPtr cb66ae2796060f727c2171dde4fe05c44 = IntPtr.Zero;

		private const int c3738e82d636d420c8fa6f36e00380cdb = 16;

		private const int ce83489682abaafa61c7621dc1b1eccc5 = 17;

		private const int cac24f2089321beef5c4a30e09e55d913 = 18;

		private const int c9eb713f1c6525a15e01e96ee4e92edac = 20;

		public event KeyEventHandler c643e61c722fafcb9a92c2d97a5807396
		{
			[CompilerGenerated]
			add
			{
				KeyEventHandler keyEventHandler = this.c643e61c722fafcb9a92c2d97a5807396;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.c643e61c722fafcb9a92c2d97a5807396, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				KeyEventHandler keyEventHandler = this.c643e61c722fafcb9a92c2d97a5807396;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.c643e61c722fafcb9a92c2d97a5807396, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3C_0 = methodof(cd973c7e4673178740aa38cd59600841e.remove_c643e61c722fafcb9a92c2d97a5807396(KeyEventHandler)).MethodHandle;
				}
			}
		}

		public event KeyEventHandler c57899a88505fef08af74aecfea2dd2bc
		{
			[CompilerGenerated]
			add
			{
				KeyEventHandler keyEventHandler = this.c57899a88505fef08af74aecfea2dd2bc;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.c57899a88505fef08af74aecfea2dd2bc, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (!true)
				{
					RuntimeMethodHandle arg_3C_0 = methodof(cd973c7e4673178740aa38cd59600841e.add_c57899a88505fef08af74aecfea2dd2bc(KeyEventHandler)).MethodHandle;
				}
			}
			[CompilerGenerated]
			remove
			{
				KeyEventHandler keyEventHandler = this.c57899a88505fef08af74aecfea2dd2bc;
				KeyEventHandler keyEventHandler2;
				do
				{
					keyEventHandler2 = keyEventHandler;
					KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove(keyEventHandler2, value);
					keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.c57899a88505fef08af74aecfea2dd2bc, value2, keyEventHandler2);
				}
				while (keyEventHandler != keyEventHandler2);
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
					RuntimeMethodHandle arg_3E_0 = methodof(cd973c7e4673178740aa38cd59600841e.remove_c57899a88505fef08af74aecfea2dd2bc(KeyEventHandler)).MethodHandle;
				}
			}
		}

		public cd973c7e4673178740aa38cd59600841e()
		{
			this.cb1874f7bccadbab9b5efb5deb4f13582 = new cd973c7e4673178740aa38cd59600841e.c06045e9b3447c52c4b733ab4f593f7c6(this.cb078ca17eceaf791009e2f32364229c0);
		}

		[DllImport("user32.dll", EntryPoint = "CallNextHookEx")]
		private static extern int c3156e6e6a77d317b98e78c499941d839(IntPtr cd8ccf065f177de42855d99d181abd426, int c818dc7cfdb5b3e06ef546f7f27e90cb8, int c3c92c57e2548b098aa1568ded461d951, ref cd973c7e4673178740aa38cd59600841e.c7f17b78c5fed2a8d59350a6a27101cad c366d1104d6f8ec3eb359e6b31326e674);

		[DllImport("user32.dll", EntryPoint = "SetWindowsHookEx")]
		private static extern IntPtr ce60b816943ccbd9d82819c8034753ddc(int c39942457420892e5afea64be3057a051, cd973c7e4673178740aa38cd59600841e.c06045e9b3447c52c4b733ab4f593f7c6 c535c51a302c1c69c2e1c2e294e6a6527, IntPtr c50a5b27241c699b737946a2150b84a5f, uint c2775f7690eb34e27e2177a09a4e121f9);

		[DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx")]
		private static extern bool c4abbfe0d108cd60af1d2762af3e5aeec(IntPtr c50a5b27241c699b737946a2150b84a5f);

		[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
		private static extern IntPtr cc40cf13ee5df401fca40ac32b5e117ad(string c904e06d222805e6f8aa14c656856ba73);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetKeyState", ExactSpelling = true)]
		public static extern short c96a0768f9d0db3a1f7eee7778a692b52(int cd339af39de262e362f011223eb5a6615);

		~cd973c7e4673178740aa38cd59600841e()
		{
			this.c98f5ef25202d271cbbee7952b8dae221();
		}

		public void ca49d50349aa3d15b4d38d9e1d595a984()
		{
			IntPtr c50a5b27241c699b737946a2150b84a5f = cd973c7e4673178740aa38cd59600841e.cc40cf13ee5df401fca40ac32b5e117ad(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83529));
			this.cb66ae2796060f727c2171dde4fe05c44 = cd973c7e4673178740aa38cd59600841e.ce60b816943ccbd9d82819c8034753ddc(13, this.cb1874f7bccadbab9b5efb5deb4f13582, c50a5b27241c699b737946a2150b84a5f, 0u);
		}

		public void c98f5ef25202d271cbbee7952b8dae221()
		{
			cd973c7e4673178740aa38cd59600841e.c4abbfe0d108cd60af1d2762af3e5aeec(this.cb66ae2796060f727c2171dde4fe05c44);
		}

		public unsafe int cb078ca17eceaf791009e2f32364229c0(int cdb08961a55aa27101abe9eb2bfb8b902, int c3c92c57e2548b098aa1568ded461d951, ref cd973c7e4673178740aa38cd59600841e.c7f17b78c5fed2a8d59350a6a27101cad c366d1104d6f8ec3eb359e6b31326e674)
		{
			bool flag = cdb08961a55aa27101abe9eb2bfb8b902 >= 0;
			int result;
			if (flag)
			{
				Keys keys = (Keys)c366d1104d6f8ec3eb359e6b31326e674.c1b16106051005d077ac990dc9c5e88e3;
				bool flag2 = this.c7669885977e29b76a528e233c632949b.Contains(keys);
				if (flag2)
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
					if (!true)
					{
						RuntimeMethodHandle arg_3E_0 = methodof(cd973c7e4673178740aa38cd59600841e.cb078ca17eceaf791009e2f32364229c0(int, int, cd973c7e4673178740aa38cd59600841e.c7f17b78c5fed2a8d59350a6a27101cad*)).MethodHandle;
					}
					keys = this.c19be8b9f51e826d6accfaf4cbb1b67f7(keys);
					KeyEventArgs keyEventArgs = new KeyEventArgs(keys);
					bool arg_77_0;
					if (c3c92c57e2548b098aa1568ded461d951 != 256)
					{
						if (c3c92c57e2548b098aa1568ded461d951 != 260)
						{
							arg_77_0 = false;
							goto IL_77;
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
					arg_77_0 = (this.c643e61c722fafcb9a92c2d97a5807396 != null);
					IL_77:
					bool flag3 = arg_77_0;
					if (flag3)
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
						this.c643e61c722fafcb9a92c2d97a5807396(this, keyEventArgs);
					}
					else
					{
						bool arg_C9_0;
						if (c3c92c57e2548b098aa1568ded461d951 != 257)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							if (c3c92c57e2548b098aa1568ded461d951 != 261)
							{
								arg_C9_0 = false;
								goto IL_C9;
							}
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
						}
						arg_C9_0 = (this.c57899a88505fef08af74aecfea2dd2bc != null);
						IL_C9:
						bool flag4 = arg_C9_0;
						if (flag4)
						{
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							this.c57899a88505fef08af74aecfea2dd2bc(this, keyEventArgs);
						}
					}
					bool handled = keyEventArgs.Handled;
					if (handled)
					{
						while (true)
						{
							switch (2)
							{
							case 0:
								continue;
							}
							break;
						}
						result = 1;
						return result;
					}
				}
			}
			result = cd973c7e4673178740aa38cd59600841e.c3156e6e6a77d317b98e78c499941d839(this.cb66ae2796060f727c2171dde4fe05c44, cdb08961a55aa27101abe9eb2bfb8b902, c3c92c57e2548b098aa1568ded461d951, ref c366d1104d6f8ec3eb359e6b31326e674);
			return result;
		}

		private Keys c19be8b9f51e826d6accfaf4cbb1b67f7(Keys ce1b714dce9ccc60ef6917e9cb7c5b9a6)
		{
			bool flag = (cd973c7e4673178740aa38cd59600841e.c96a0768f9d0db3a1f7eee7778a692b52(20) & 1) != 0;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_25_0 = methodof(cd973c7e4673178740aa38cd59600841e.c19be8b9f51e826d6accfaf4cbb1b67f7(Keys)).MethodHandle;
				}
				ce1b714dce9ccc60ef6917e9cb7c5b9a6 |= Keys.Capital;
			}
			bool flag2 = ((int)cd973c7e4673178740aa38cd59600841e.c96a0768f9d0db3a1f7eee7778a692b52(16) & 32768) != 0;
			if (flag2)
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
				ce1b714dce9ccc60ef6917e9cb7c5b9a6 |= Keys.Shift;
			}
			bool flag3 = ((int)cd973c7e4673178740aa38cd59600841e.c96a0768f9d0db3a1f7eee7778a692b52(17) & 32768) != 0;
			if (flag3)
			{
				ce1b714dce9ccc60ef6917e9cb7c5b9a6 |= Keys.Control;
			}
			bool flag4 = ((int)cd973c7e4673178740aa38cd59600841e.c96a0768f9d0db3a1f7eee7778a692b52(18) & 32768) != 0;
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
				ce1b714dce9ccc60ef6917e9cb7c5b9a6 |= Keys.Alt;
			}
			return ce1b714dce9ccc60ef6917e9cb7c5b9a6;
		}
	}
}
