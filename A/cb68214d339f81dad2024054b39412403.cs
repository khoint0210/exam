using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace A
{
	internal class cb68214d339f81dad2024054b39412403
	{
		public delegate int cdefba311c56065748af27e4ba4da0546(int Code, int wParam, ref cb68214d339f81dad2024054b39412403.c5fa40ac0f3e6fc06299ef2dbc02cff11 lParam);

		public struct c5fa40ac0f3e6fc06299ef2dbc02cff11
		{
			public int cd28bfc5b0bf35ed31d398891e6a8b56e;

			public int c3a0f0a3d56ed8c46b70fe2f8b7541bc6;

			public int c8ac9354f59eb399b63b6548682c3df35;

			public int c06a5d0a3c384f262e7756c3b37f944e5;

			public int c2eb244748ff843562042980d2fd19cd1;
		}

		private const int c53eff9c61cc0bb9083509b3b99de8bcb = 13;

		private const int c6de6a529b81427a88429d1e0514b23f5 = 256;

		private const int cee4f8fb7753f7c5b5ccbf2dd517bc2ec = 257;

		private const int cf51ee072ca2b7003e4e66d0e6c8efb53 = 260;

		private const int cd3b3fe24af9965e87a854e8fdf999c1f = 261;

		private cb68214d339f81dad2024054b39412403.cdefba311c56065748af27e4ba4da0546 cc40b412fa7d551d6055e2bfc10472d06;

		public List<Keys> c151d47083d85cae542ad97ba9891496d = new List<Keys>();

		private IntPtr c95a6c653f802cfa43de2bce80ca76ff2 = IntPtr.Zero;

		private const int c42151566e25f7c59de90163003750bd8 = 16;

		private const int cfdafd9301ce4346d14cce1a3072228f4 = 17;

		private const int c9f32c14dd1fd872d74f64724bd2b597d = 18;

		private const int c37ac777e38641f7c1e464e981e8f985a = 20;

		[method: CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		public event KeyEventHandler c3c9b2ce27fa8d94826eff82d0574e862;

		[method: CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never), CompilerGenerated]
		public event KeyEventHandler c5b38322f42404828c5df527240be43a9;

		public cb68214d339f81dad2024054b39412403()
		{
			this.cc40b412fa7d551d6055e2bfc10472d06 = new cb68214d339f81dad2024054b39412403.cdefba311c56065748af27e4ba4da0546(this.c6b8ec260663ae79ff7233203a0e1145b);
		}

		[DllImport("user32.dll", EntryPoint = "CallNextHookEx")]
		private static extern int cd2de35974097402192c4ddd752724c8a(IntPtr c346b6cde99c747599080e7e529f8187f, int c071e669d6161b0a84f642b1651c79cb3, int ccb64ec54c4725b424a10c510544a5718, ref cb68214d339f81dad2024054b39412403.c5fa40ac0f3e6fc06299ef2dbc02cff11 c0e6cb9e1a6cfa653a439e8ddad62da00);

		[DllImport("user32.dll", EntryPoint = "SetWindowsHookEx")]
		private static extern IntPtr c05ddeec6a7c4bbf2d961388b4ee292db(int c30f8f694bd9e0aa6468bc14247d97f0a, cb68214d339f81dad2024054b39412403.cdefba311c56065748af27e4ba4da0546 c95f12029c753ccf805b694132e554643, IntPtr cc17d57eb56e0d208df05493231574bc6, uint c2cb252286d47ac585cf65eddd58f181e);

		[DllImport("user32.dll", EntryPoint = "UnhookWindowsHookEx")]
		private static extern bool c554d98576c0dd02a9bcfdb4017415872(IntPtr cc17d57eb56e0d208df05493231574bc6);

		[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
		private static extern IntPtr cd51cb79a35624553e158881c34fe3d73(string c7789f849a598c748a40d5e47dcfc9d25);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetKeyState", ExactSpelling = true)]
		public static extern short c70459ee3126037805b02d974b059748b(int cded8e315ed3348df09f60b74b447d7c2);

		~cb68214d339f81dad2024054b39412403()
		{
			this.c2449c7b396349942c452fa173ac73161();
		}

		public void c0b377274dd642494427bf19a4e379eee()
		{
			IntPtr cc17d57eb56e0d208df05493231574bc = cb68214d339f81dad2024054b39412403.cd51cb79a35624553e158881c34fe3d73(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84166));
			this.c95a6c653f802cfa43de2bce80ca76ff2 = cb68214d339f81dad2024054b39412403.c05ddeec6a7c4bbf2d961388b4ee292db(13, this.cc40b412fa7d551d6055e2bfc10472d06, cc17d57eb56e0d208df05493231574bc, 0u);
		}

		public void c2449c7b396349942c452fa173ac73161()
		{
			cb68214d339f81dad2024054b39412403.c554d98576c0dd02a9bcfdb4017415872(this.c95a6c653f802cfa43de2bce80ca76ff2);
		}

		public unsafe int c6b8ec260663ae79ff7233203a0e1145b(int c849f92c284f061e8916b024149b52bd9, int ccb64ec54c4725b424a10c510544a5718, ref cb68214d339f81dad2024054b39412403.c5fa40ac0f3e6fc06299ef2dbc02cff11 c0e6cb9e1a6cfa653a439e8ddad62da00)
		{
			bool flag = c849f92c284f061e8916b024149b52bd9 >= 0;
			int result;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_21_0 = methodof(cb68214d339f81dad2024054b39412403.c6b8ec260663ae79ff7233203a0e1145b(int, int, cb68214d339f81dad2024054b39412403.c5fa40ac0f3e6fc06299ef2dbc02cff11*)).MethodHandle;
				}
				Keys keys = (Keys)c0e6cb9e1a6cfa653a439e8ddad62da00.cd28bfc5b0bf35ed31d398891e6a8b56e;
				bool flag2 = this.c151d47083d85cae542ad97ba9891496d.Contains(keys);
				if (flag2)
				{
					keys = this.c2dcb0a12efbe51174888f698b4bb90ec(keys);
					KeyEventArgs keyEventArgs = new KeyEventArgs(keys);
					bool flag3 = (ccb64ec54c4725b424a10c510544a5718 == 256 || ccb64ec54c4725b424a10c510544a5718 == 260) && this.c3c9b2ce27fa8d94826eff82d0574e862 != null;
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
						this.c3c9b2ce27fa8d94826eff82d0574e862(this, keyEventArgs);
					}
					else
					{
						bool arg_B1_0;
						if (ccb64ec54c4725b424a10c510544a5718 != 257)
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
							if (ccb64ec54c4725b424a10c510544a5718 != 261)
							{
								arg_B1_0 = false;
								goto IL_B1;
							}
						}
						arg_B1_0 = (this.c5b38322f42404828c5df527240be43a9 != null);
						IL_B1:
						bool flag4 = arg_B1_0;
						if (flag4)
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
							this.c5b38322f42404828c5df527240be43a9(this, keyEventArgs);
						}
					}
					bool handled = keyEventArgs.Handled;
					if (handled)
					{
						result = 1;
						return result;
					}
				}
			}
			result = cb68214d339f81dad2024054b39412403.cd2de35974097402192c4ddd752724c8a(this.c95a6c653f802cfa43de2bce80ca76ff2, c849f92c284f061e8916b024149b52bd9, ccb64ec54c4725b424a10c510544a5718, ref c0e6cb9e1a6cfa653a439e8ddad62da00);
			return result;
		}

		private Keys c2dcb0a12efbe51174888f698b4bb90ec(Keys c981a74dad40bfd37bf51def99f9fa4b9)
		{
			bool flag = (cb68214d339f81dad2024054b39412403.c70459ee3126037805b02d974b059748b(20) & 1) != 0;
			if (flag)
			{
				c981a74dad40bfd37bf51def99f9fa4b9 |= Keys.Capital;
			}
			bool flag2 = ((int)cb68214d339f81dad2024054b39412403.c70459ee3126037805b02d974b059748b(16) & 32768) != 0;
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
				if (!true)
				{
					RuntimeMethodHandle arg_41_0 = methodof(cb68214d339f81dad2024054b39412403.c2dcb0a12efbe51174888f698b4bb90ec(Keys)).MethodHandle;
				}
				c981a74dad40bfd37bf51def99f9fa4b9 |= Keys.Shift;
			}
			bool flag3 = ((int)cb68214d339f81dad2024054b39412403.c70459ee3126037805b02d974b059748b(17) & 32768) != 0;
			if (flag3)
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
				c981a74dad40bfd37bf51def99f9fa4b9 |= Keys.Control;
			}
			bool flag4 = ((int)cb68214d339f81dad2024054b39412403.c70459ee3126037805b02d974b059748b(18) & 32768) != 0;
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
				c981a74dad40bfd37bf51def99f9fa4b9 |= Keys.Alt;
			}
			return c981a74dad40bfd37bf51def99f9fa4b9;
		}
	}
}
