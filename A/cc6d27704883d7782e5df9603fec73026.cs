using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace A
{
	internal class cc6d27704883d7782e5df9603fec73026 : IDisposable, ICloneable
	{
		private delegate bool c9502035f955d6687641bc15b785c968b(string lpszDesktop, IntPtr lParam);

		private delegate bool c02ae15c5fc8f695ebe30bf12365cda06(IntPtr desktopHandle, IntPtr lParam);

		private struct cf880b8c8095d85036b7910db3b96be51
		{
			public IntPtr c25b9ea0d0133a1e310d2d4d2cb4da266;

			public IntPtr cb83f2b7052c492cc4a721ecb7563f865;

			public int c07bed445be3a11bb1d9de6196879453c;

			public int ce23f78f0a0060ae3a2c74f3d3ff90ed8;
		}

		private struct cc5ed8c565990020331729a21928c93c0
		{
			public int cd6665a9052b61ac52257222c74a1c85e;

			public string cefe5aa6b6e583e5de64841320afaeed0;

			public string c231ec477e5a712ba1b8d05f49ca9279e;

			public string c5f833291b948a9172f18a44ea93e4d1d;

			public int c0e6a354deae9dbf895d8274dd4150f9f;

			public int c9d289c73af9396b325ec427a6b4d6fa2;

			public int ca32d34ef56683098df63cca95496ea0a;

			public int c77b7a047e38c64a4503ef233e67967d8;

			public int c2396cbb9360192afd333af53157cbee1;

			public int c81854fd3f446df3c2afdb5fd5d680e7e;

			public int ca1cadce9239dbea2527e5febc05c47d1;

			public int cc5609e97e40db9ae1837bbd7f5dac533;

			public short c8f7e406fe552447f8882be230d6a7096;

			public short c6cf64ce8d40ec4b711bfb27094795ad4;

			public IntPtr cbe12921239ca3f2f00d758554758e6da;

			public IntPtr c26872191a6b4a0d5f047519521921046;

			public IntPtr c244ae1828e67614fcbd0181fb9003b97;

			public IntPtr cbe9c657c6b828e6ee7dcad1e72132331;
		}

		public struct c301d9a56f4ec4dd4503f97ce80c35bda
		{
			private IntPtr c147c36a838d0e5b04589a012ee7f11bb;

			private string cb56fd004f0bd7d9c16a0edb0c49480b8;

			public IntPtr c361b4f402da27c523b129aeeb200362c
			{
				get
				{
					return this.c147c36a838d0e5b04589a012ee7f11bb;
				}
			}

			public string cca004646941057afdc8dd04145963285
			{
				get
				{
					return this.cb56fd004f0bd7d9c16a0edb0c49480b8;
				}
			}

			public c301d9a56f4ec4dd4503f97ce80c35bda(IntPtr cef7d7313483af6c489d8e3305730f819, string c4df74c6692f714e53ca05e4404590690)
			{
				this.c147c36a838d0e5b04589a012ee7f11bb = cef7d7313483af6c489d8e3305730f819;
				this.cb56fd004f0bd7d9c16a0edb0c49480b8 = c4df74c6692f714e53ca05e4404590690;
			}
		}

		[DefaultMember("Item")]
		public class c9cacbf4ba6943be95efbf3bd674c210d : CollectionBase
		{
			public cc6d27704883d7782e5df9603fec73026.c301d9a56f4ec4dd4503f97ce80c35bda c44d93e294460e6bfcb571b739de39f49
			{
				get
				{
					return (cc6d27704883d7782e5df9603fec73026.c301d9a56f4ec4dd4503f97ce80c35bda)base.List[c1fff428e8f58c2beabf3ef39593a9b72];
				}
			}

			public void cfbe003770f86889b5d1a3d352d283d77(cc6d27704883d7782e5df9603fec73026.c301d9a56f4ec4dd4503f97ce80c35bda cf7db47fbaa49894bd246e53414622379)
			{
				base.List.Add(cf7db47fbaa49894bd246e53414622379);
			}
		}

		public const int cd25c30e2ab6e549d6ea617a979129af5 = 100;

		private const short c8480f68158fb2361ff728fe59465dc23 = 0;

		private const short c06237d5cd8a2b4d04ad3dac9ba847db6 = 1;

		private const int c769989571c948c5e72c3e5ac1e6afb10 = 256;

		private const int c840fb426d13c3885bf29cde8b2e55ce7 = 1;

		private const int c5f9fdac60e272bfae4e582c779f5ea3c = 2;

		private const int cf0664715390255db6cfa3b60996de3a4 = 4;

		private const int c1511c1469e56a9ce62357af4305005ce = 32;

		private const long c2ce0917b6b7fd9196fde3cc2aa86f9e4 = 2L;

		private const long c18b2ffd1deaf156c21fbf124414f5513 = 64L;

		private const long c373a759dfca9d94fb96ad3225beaab01 = 128L;

		private const long c0553d152674d47f05a9c7467ae1b9417 = 256L;

		private const long caba441f394a435c544108184e6b9a408 = 4L;

		private const long c6fc4a44cf495026f6fd262385fe3bc15 = 8L;

		private const long c659e65eb4eed3894b69420eb1b113348 = 1L;

		private const long c31001539004fe6137f5f76fb9e547942 = 16L;

		private const long cfb2dd98a569a24d67263421570ed9f5d = 32L;

		private const long cefc4a874f506f483905cf2c4e7e135b1 = 511L;

		private IntPtr c451f2a504e7bb1790347bf20079829b3;

		private string c07fd463328beb69882c5f5abf304761d;

		private static StringCollection cf67c17e57c0436f9a725ee49742f2bf7;

		private ArrayList c6dfde8564643365996f751010c7a2819;

		private bool c0d7fe0ebc5cb727122479609db8dc632;

		public static readonly cc6d27704883d7782e5df9603fec73026 c1772e9b1285bbc240668c3f78e24bef7 = cc6d27704883d7782e5df9603fec73026.cb55e52b55052587165bf0def31a177a5();

		public static readonly cc6d27704883d7782e5df9603fec73026 c61a52af03cc9aab290279cdfd5770132 = cc6d27704883d7782e5df9603fec73026.c55a0a09af4ce3ee2072f0edd49d9ae0e();

		public bool cc11fb07a909d9529b4790c9c45e0f738
		{
			get
			{
				return this.c451f2a504e7bb1790347bf20079829b3 != IntPtr.Zero;
			}
		}

		public string c5b8e19ac8bbe9bd9329ed58856ff30c0
		{
			get
			{
				return this.c07fd463328beb69882c5f5abf304761d;
			}
		}

		public IntPtr c64b6942adfe7f41a06ac889222c286fd
		{
			get
			{
				return this.c451f2a504e7bb1790347bf20079829b3;
			}
		}

		public cc6d27704883d7782e5df9603fec73026()
		{
			this.c451f2a504e7bb1790347bf20079829b3 = IntPtr.Zero;
			this.c07fd463328beb69882c5f5abf304761d = string.Empty;
			this.c6dfde8564643365996f751010c7a2819 = new ArrayList();
			this.c0d7fe0ebc5cb727122479609db8dc632 = false;
		}

		private cc6d27704883d7782e5df9603fec73026(IntPtr c79824cd743ab343b260dda3e87592238)
		{
			this.c451f2a504e7bb1790347bf20079829b3 = c79824cd743ab343b260dda3e87592238;
			this.c07fd463328beb69882c5f5abf304761d = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(c79824cd743ab343b260dda3e87592238);
			this.c6dfde8564643365996f751010c7a2819 = new ArrayList();
			this.c0d7fe0ebc5cb727122479609db8dc632 = false;
		}

		[DllImport("kernel32.dll", EntryPoint = "GetThreadId")]
		private static extern int c2d9dc510fbc273556014955e06d4964b(IntPtr cf99a40bc2ff2ed25c52315fb407ba9d8);

		[DllImport("kernel32.dll", EntryPoint = "GetProcessId")]
		private static extern int cff3f4a4f84c93d7577d92a2e805ee9f7(IntPtr c97d7ae6d8728e4cd8e063c8fba67bb85);

		[DllImport("user32.dll", EntryPoint = "CreateDesktop")]
		private static extern IntPtr c58461e17eafdce0f31abc2303e78c1c1(string c61eeecebbdf662d000f9d5523361c570, IntPtr cae3d91890abb16f4e9677e9e4ef3a8a0, IntPtr c01f766087065501d6e60e73d98728c70, int cc5609e97e40db9ae1837bbd7f5dac533, long ce48357353ab2822da1ac20ca6819c622, IntPtr cac4f2b81389e1ddfa7cb7aa7d5b8a649);

		[DllImport("user32.dll", EntryPoint = "CloseDesktop")]
		private static extern bool c751ed8cb67dc23e990cd1d0023b3fa01(IntPtr c33ab52deab6caab27fce0512d095622b);

		[DllImport("user32.dll", EntryPoint = "OpenDesktop")]
		private static extern IntPtr c84c59b2e6a2b94e695854b232ba0cad2(string c61eeecebbdf662d000f9d5523361c570, int cc5609e97e40db9ae1837bbd7f5dac533, bool c7e91a3dfcff29bed542bd374848ef66c, long ce48357353ab2822da1ac20ca6819c622);

		[DllImport("user32.dll", EntryPoint = "OpenInputDesktop")]
		private static extern IntPtr c55a0a09af4ce3ee2072f0edd49d9ae0e(int cc5609e97e40db9ae1837bbd7f5dac533, bool c7e91a3dfcff29bed542bd374848ef66c, long ce48357353ab2822da1ac20ca6819c622);

		[DllImport("user32.dll", EntryPoint = "SwitchDesktop")]
		private static extern bool cff469801168d4dc64f22407419d97550(IntPtr c33ab52deab6caab27fce0512d095622b);

		[DllImport("user32.dll", EntryPoint = "EnumDesktops")]
		private static extern bool c100768189496ca05c2ecbb0961ad1c9b(IntPtr ceeaa98e3ae1417ed636932ea001abaff, cc6d27704883d7782e5df9603fec73026.c9502035f955d6687641bc15b785c968b cfebeca846a12b653a4cc27408eed9af5, IntPtr c366d1104d6f8ec3eb359e6b31326e674);

		[DllImport("user32.dll", EntryPoint = "GetProcessWindowStation")]
		private static extern IntPtr ce808b0462e548db4bf35b070c67fc90b();

		[DllImport("user32.dll", EntryPoint = "EnumDesktopWindows")]
		private static extern bool c429aafcd552a50953e3cb7457cb92c57(IntPtr c33ab52deab6caab27fce0512d095622b, cc6d27704883d7782e5df9603fec73026.c02ae15c5fc8f695ebe30bf12365cda06 c8dc47bab1d0abe1374f2aaeef4ae9392, IntPtr c366d1104d6f8ec3eb359e6b31326e674);

		[DllImport("user32.dll", EntryPoint = "SetThreadDesktop")]
		private static extern bool cf8da301d3bdbd8af61487f3acfa83804(IntPtr c33ab52deab6caab27fce0512d095622b);

		[DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
		private static extern IntPtr cb8fe049137d3b430f7f67832c7669556(int ce23f78f0a0060ae3a2c74f3d3ff90ed8);

		[DllImport("user32.dll", EntryPoint = "GetUserObjectInformation")]
		private static extern bool c17e8bfc20f292071104908fa1abad872(IntPtr c0c729cfbff9a128e8c0b42d2bc1be515, int c602c902d3440e5d1ff6ad50c55b7be80, IntPtr c013d510a548f7f4b62ed994717901ede, int cc76672990cebf2bff6c16394b24b9115, ref int c20bda1bacdf09ef8e092f26ecab3fe5e);

		[DllImport("kernel32.dll", EntryPoint = "CreateProcess")]
		private static extern bool c50ee25c9382d445ea99400e156df8105(string c6ddab1b11d744c41a8d4ec2aa0d9c52b, string cd61f389ce958443be399e98e7bde6ea0, IntPtr c5dcc07ca98a86fdf55f11b206811ac77, IntPtr c21ac03d8a591fdaaf390bff47f8107d2, bool c4f43cf27ae6277c92b4f86fa9b41b642, int cd745a84b797ef77c9dad0f652d9f4e9c, IntPtr cb53f85457f14f3bf21b6daa607990002, string c995ebf085c0970558b838d33402caa3c, ref cc6d27704883d7782e5df9603fec73026.cc5ed8c565990020331729a21928c93c0 c09ebffa4f44c26f23de2f0c39fb4f8ac, ref cc6d27704883d7782e5df9603fec73026.cf880b8c8095d85036b7910db3b96be51 c2c0f2382e8a22192a23722b0d97cb563);

		[DllImport("user32.dll", EntryPoint = "GetWindowText")]
		private static extern int c90d3243d65cd6b8796d8016a570cb523(IntPtr c45a9b28c9a05fdcd93c0902792e53a1f, IntPtr cc8c9740923d9eb2651cb1740b51e875e, int c532b85410a747779d40525395377cd37);

		~cc6d27704883d7782e5df9603fec73026()
		{
			this.cd7c36a907b606f70262d2841af9404cc();
		}

		public bool c60c9471886a04fe6500d204ab659b946(string c4dedb7816e1384806490715c43d6f478)
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool flag = this.c451f2a504e7bb1790347bf20079829b3 != IntPtr.Zero;
			bool result;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_30_0 = methodof(cc6d27704883d7782e5df9603fec73026.c60c9471886a04fe6500d204ab659b946(string)).MethodHandle;
				}
				bool flag2 = !this.cd7c36a907b606f70262d2841af9404cc();
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
					result = false;
					return result;
				}
			}
			bool flag3 = cc6d27704883d7782e5df9603fec73026.c8ac753abcf15e568429deb29ba12230e(c4dedb7816e1384806490715c43d6f478);
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
				result = this.cf549f4524757b110599fa74d43cc2993(c4dedb7816e1384806490715c43d6f478);
			}
			else
			{
				this.c451f2a504e7bb1790347bf20079829b3 = cc6d27704883d7782e5df9603fec73026.c58461e17eafdce0f31abc2303e78c1c1(c4dedb7816e1384806490715c43d6f478, IntPtr.Zero, IntPtr.Zero, 0, 511L, IntPtr.Zero);
				this.c07fd463328beb69882c5f5abf304761d = c4dedb7816e1384806490715c43d6f478;
				bool flag4 = this.c451f2a504e7bb1790347bf20079829b3 == IntPtr.Zero;
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
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		public bool cd7c36a907b606f70262d2841af9404cc()
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool flag = this.c451f2a504e7bb1790347bf20079829b3 != IntPtr.Zero;
			bool result;
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
					RuntimeMethodHandle arg_30_0 = methodof(cc6d27704883d7782e5df9603fec73026.cd7c36a907b606f70262d2841af9404cc()).MethodHandle;
				}
				bool flag2 = cc6d27704883d7782e5df9603fec73026.c751ed8cb67dc23e990cd1d0023b3fa01(this.c451f2a504e7bb1790347bf20079829b3);
				bool flag3 = flag2;
				if (flag3)
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
					this.c451f2a504e7bb1790347bf20079829b3 = IntPtr.Zero;
					this.c07fd463328beb69882c5f5abf304761d = string.Empty;
				}
				result = flag2;
			}
			else
			{
				result = true;
			}
			return result;
		}

		public bool cf549f4524757b110599fa74d43cc2993(string c4dedb7816e1384806490715c43d6f478)
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool flag = this.c451f2a504e7bb1790347bf20079829b3 != IntPtr.Zero;
			bool result;
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
					RuntimeMethodHandle arg_30_0 = methodof(cc6d27704883d7782e5df9603fec73026.cf549f4524757b110599fa74d43cc2993(string)).MethodHandle;
				}
				bool flag2 = !this.cd7c36a907b606f70262d2841af9404cc();
				if (flag2)
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
					result = false;
					return result;
				}
			}
			this.c451f2a504e7bb1790347bf20079829b3 = cc6d27704883d7782e5df9603fec73026.c84c59b2e6a2b94e695854b232ba0cad2(c4dedb7816e1384806490715c43d6f478, 0, true, 511L);
			bool flag3 = this.c451f2a504e7bb1790347bf20079829b3 == IntPtr.Zero;
			if (flag3)
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
				result = false;
			}
			else
			{
				this.c07fd463328beb69882c5f5abf304761d = c4dedb7816e1384806490715c43d6f478;
				result = true;
			}
			return result;
		}

		public bool c30f54af4b76670ad3161c694e1822bc2()
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool flag = this.c451f2a504e7bb1790347bf20079829b3 != IntPtr.Zero;
			bool result;
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
					RuntimeMethodHandle arg_30_0 = methodof(cc6d27704883d7782e5df9603fec73026.c30f54af4b76670ad3161c694e1822bc2()).MethodHandle;
				}
				bool flag2 = !this.cd7c36a907b606f70262d2841af9404cc();
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
					result = false;
					return result;
				}
			}
			this.c451f2a504e7bb1790347bf20079829b3 = cc6d27704883d7782e5df9603fec73026.c55a0a09af4ce3ee2072f0edd49d9ae0e(0, true, 511L);
			bool flag3 = this.c451f2a504e7bb1790347bf20079829b3 == IntPtr.Zero;
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
				result = false;
			}
			else
			{
				this.c07fd463328beb69882c5f5abf304761d = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(this.c451f2a504e7bb1790347bf20079829b3);
				result = true;
			}
			return result;
		}

		public bool c421c010e5322eac110ef5896695989c8()
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool flag = this.c451f2a504e7bb1790347bf20079829b3 == IntPtr.Zero;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				bool flag2 = cc6d27704883d7782e5df9603fec73026.cff469801168d4dc64f22407419d97550(this.c451f2a504e7bb1790347bf20079829b3);
				result = flag2;
			}
			return result;
		}

		public cc6d27704883d7782e5df9603fec73026.c9cacbf4ba6943be95efbf3bd674c210d c31e06330e66352637f44a00b7809cc5b()
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool flag = !this.cc11fb07a909d9529b4790c9c45e0f738;
			cc6d27704883d7782e5df9603fec73026.c9cacbf4ba6943be95efbf3bd674c210d result;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_27_0 = methodof(cc6d27704883d7782e5df9603fec73026.c31e06330e66352637f44a00b7809cc5b()).MethodHandle;
				}
				result = null;
			}
			else
			{
				this.c6dfde8564643365996f751010c7a2819.Clear();
				cc6d27704883d7782e5df9603fec73026.c9cacbf4ba6943be95efbf3bd674c210d c9cacbf4ba6943be95efbf3bd674c210d = new cc6d27704883d7782e5df9603fec73026.c9cacbf4ba6943be95efbf3bd674c210d();
				bool flag2 = cc6d27704883d7782e5df9603fec73026.c429aafcd552a50953e3cb7457cb92c57(this.c451f2a504e7bb1790347bf20079829b3, new cc6d27704883d7782e5df9603fec73026.c02ae15c5fc8f695ebe30bf12365cda06(this.cf6f2634d4cb14e80df2ec2b04139b3f0), IntPtr.Zero);
				bool flag3 = !flag2;
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
					result = null;
				}
				else
				{
					c9cacbf4ba6943be95efbf3bd674c210d = new cc6d27704883d7782e5df9603fec73026.c9cacbf4ba6943be95efbf3bd674c210d();
					IntPtr intPtr = Marshal.AllocHGlobal(100);
					foreach (IntPtr intPtr2 in this.c6dfde8564643365996f751010c7a2819)
					{
						cc6d27704883d7782e5df9603fec73026.c90d3243d65cd6b8796d8016a570cb523(intPtr2, intPtr, 100);
						c9cacbf4ba6943be95efbf3bd674c210d.cfbe003770f86889b5d1a3d352d283d77(new cc6d27704883d7782e5df9603fec73026.c301d9a56f4ec4dd4503f97ce80c35bda(intPtr2, Marshal.PtrToStringAnsi(intPtr)));
					}
					Marshal.FreeHGlobal(intPtr);
					result = c9cacbf4ba6943be95efbf3bd674c210d;
				}
			}
			return result;
		}

		private bool cf6f2634d4cb14e80df2ec2b04139b3f0(IntPtr cff328166390ef2fc210220ac878d1e27, IntPtr c366d1104d6f8ec3eb359e6b31326e674)
		{
			this.c6dfde8564643365996f751010c7a2819.Add(cff328166390ef2fc210220ac878d1e27);
			return true;
		}

		public Process c50ee25c9382d445ea99400e156df8105(string c833fb49637f16a63c5b4ea4413bad494)
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool flag = !this.cc11fb07a909d9529b4790c9c45e0f738;
			Process result;
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
					RuntimeMethodHandle arg_29_0 = methodof(cc6d27704883d7782e5df9603fec73026.c50ee25c9382d445ea99400e156df8105(string)).MethodHandle;
				}
				result = null;
			}
			else
			{
				cc6d27704883d7782e5df9603fec73026.cc5ed8c565990020331729a21928c93c0 structure = default(cc6d27704883d7782e5df9603fec73026.cc5ed8c565990020331729a21928c93c0);
				structure.cd6665a9052b61ac52257222c74a1c85e = Marshal.SizeOf<cc6d27704883d7782e5df9603fec73026.cc5ed8c565990020331729a21928c93c0>(structure);
				structure.c231ec477e5a712ba1b8d05f49ca9279e = this.c07fd463328beb69882c5f5abf304761d;
				cc6d27704883d7782e5df9603fec73026.cf880b8c8095d85036b7910db3b96be51 cf880b8c8095d85036b7910db3b96be = default(cc6d27704883d7782e5df9603fec73026.cf880b8c8095d85036b7910db3b96be51);
				bool flag2 = cc6d27704883d7782e5df9603fec73026.c50ee25c9382d445ea99400e156df8105(null, c833fb49637f16a63c5b4ea4413bad494, IntPtr.Zero, IntPtr.Zero, true, 32, IntPtr.Zero, null, ref structure, ref cf880b8c8095d85036b7910db3b96be);
				bool flag3 = !flag2;
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
					result = null;
				}
				else
				{
					result = Process.GetProcessById(cf880b8c8095d85036b7910db3b96be.c07bed445be3a11bb1d9de6196879453c);
				}
			}
			return result;
		}

		public void c21bc8b949847115b8d18b6659b70f438()
		{
			this.ccead173904051acf8103bfc760ff25c1();
			bool cc11fb07a909d9529b4790c9c45e0f = this.cc11fb07a909d9529b4790c9c45e0f738;
			if (cc11fb07a909d9529b4790c9c45e0f)
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
					RuntimeMethodHandle arg_26_0 = methodof(cc6d27704883d7782e5df9603fec73026.c21bc8b949847115b8d18b6659b70f438()).MethodHandle;
				}
				this.c50ee25c9382d445ea99400e156df8105(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84021));
			}
		}

		public static string[] c39996e6baa29146f1b88dbe0ed133778()
		{
			IntPtr intPtr = cc6d27704883d7782e5df9603fec73026.ce808b0462e548db4bf35b070c67fc90b();
			bool flag = intPtr == IntPtr.Zero;
			string[] result;
			if (flag)
			{
				result = new string[0];
			}
			else
			{
				StringCollection obj = cc6d27704883d7782e5df9603fec73026.cf67c17e57c0436f9a725ee49742f2bf7 = new StringCollection();
				bool flag2 = false;
				string[] array;
				try
				{
					Monitor.Enter(obj, ref flag2);
					bool flag3 = cc6d27704883d7782e5df9603fec73026.c100768189496ca05c2ecbb0961ad1c9b(intPtr, new cc6d27704883d7782e5df9603fec73026.c9502035f955d6687641bc15b785c968b(cc6d27704883d7782e5df9603fec73026.c7bae0172a30da9f8cd6f1a7d3f2269f3), IntPtr.Zero);
					bool flag4 = !flag3;
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
						if (!true)
						{
							RuntimeMethodHandle arg_77_0 = methodof(cc6d27704883d7782e5df9603fec73026.c39996e6baa29146f1b88dbe0ed133778()).MethodHandle;
						}
						result = new string[0];
						return result;
					}
					array = new string[cc6d27704883d7782e5df9603fec73026.cf67c17e57c0436f9a725ee49742f2bf7.Count];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = cc6d27704883d7782e5df9603fec73026.cf67c17e57c0436f9a725ee49742f2bf7[i];
					}
				}
				finally
				{
					if (flag2)
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
						Monitor.Exit(obj);
					}
				}
				result = array;
			}
			return result;
		}

		private static bool c7bae0172a30da9f8cd6f1a7d3f2269f3(string c61eeecebbdf662d000f9d5523361c570, IntPtr c366d1104d6f8ec3eb359e6b31326e674)
		{
			cc6d27704883d7782e5df9603fec73026.cf67c17e57c0436f9a725ee49742f2bf7.Add(c61eeecebbdf662d000f9d5523361c570);
			return true;
		}

		public static bool c421c010e5322eac110ef5896695989c8(string c4dedb7816e1384806490715c43d6f478)
		{
			bool flag = false;
			bool result;
			using (cc6d27704883d7782e5df9603fec73026 cc6d27704883d7782e5df9603fec = new cc6d27704883d7782e5df9603fec73026())
			{
				flag = cc6d27704883d7782e5df9603fec.cf549f4524757b110599fa74d43cc2993(c4dedb7816e1384806490715c43d6f478);
				bool flag2 = !flag;
				if (flag2)
				{
					result = false;
					return result;
				}
				flag = cc6d27704883d7782e5df9603fec.c421c010e5322eac110ef5896695989c8();
			}
			result = flag;
			return result;
		}

		public static bool c17f9e9380386a1a7d042e742be364af3(cc6d27704883d7782e5df9603fec73026 c79824cd743ab343b260dda3e87592238)
		{
			bool flag = !c79824cd743ab343b260dda3e87592238.cc11fb07a909d9529b4790c9c45e0f738;
			bool result;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_20_0 = methodof(cc6d27704883d7782e5df9603fec73026.c17f9e9380386a1a7d042e742be364af3(cc6d27704883d7782e5df9603fec73026)).MethodHandle;
				}
				result = false;
			}
			else
			{
				result = cc6d27704883d7782e5df9603fec73026.cf8da301d3bdbd8af61487f3acfa83804(c79824cd743ab343b260dda3e87592238.c64b6942adfe7f41a06ac889222c286fd);
			}
			return result;
		}

		public static cc6d27704883d7782e5df9603fec73026 c84c59b2e6a2b94e695854b232ba0cad2(string c4dedb7816e1384806490715c43d6f478)
		{
			cc6d27704883d7782e5df9603fec73026 cc6d27704883d7782e5df9603fec = new cc6d27704883d7782e5df9603fec73026();
			bool flag = cc6d27704883d7782e5df9603fec.cf549f4524757b110599fa74d43cc2993(c4dedb7816e1384806490715c43d6f478);
			bool flag2 = !flag;
			cc6d27704883d7782e5df9603fec73026 result;
			if (flag2)
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
					RuntimeMethodHandle arg_2B_0 = methodof(cc6d27704883d7782e5df9603fec73026.c84c59b2e6a2b94e695854b232ba0cad2(string)).MethodHandle;
				}
				result = null;
			}
			else
			{
				result = cc6d27704883d7782e5df9603fec;
			}
			return result;
		}

		public static cc6d27704883d7782e5df9603fec73026 c55a0a09af4ce3ee2072f0edd49d9ae0e()
		{
			cc6d27704883d7782e5df9603fec73026 cc6d27704883d7782e5df9603fec = new cc6d27704883d7782e5df9603fec73026();
			bool flag = cc6d27704883d7782e5df9603fec.c30f54af4b76670ad3161c694e1822bc2();
			bool flag2 = !flag;
			cc6d27704883d7782e5df9603fec73026 result;
			if (flag2)
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
				if (!true)
				{
					RuntimeMethodHandle arg_2A_0 = methodof(cc6d27704883d7782e5df9603fec73026.c55a0a09af4ce3ee2072f0edd49d9ae0e()).MethodHandle;
				}
				result = null;
			}
			else
			{
				result = cc6d27704883d7782e5df9603fec;
			}
			return result;
		}

		public static cc6d27704883d7782e5df9603fec73026 cb55e52b55052587165bf0def31a177a5()
		{
			return cc6d27704883d7782e5df9603fec73026.c84c59b2e6a2b94e695854b232ba0cad2(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84046));
		}

		public static cc6d27704883d7782e5df9603fec73026 c58461e17eafdce0f31abc2303e78c1c1(string c4dedb7816e1384806490715c43d6f478)
		{
			cc6d27704883d7782e5df9603fec73026 cc6d27704883d7782e5df9603fec = new cc6d27704883d7782e5df9603fec73026();
			bool flag = cc6d27704883d7782e5df9603fec.c60c9471886a04fe6500d204ab659b946(c4dedb7816e1384806490715c43d6f478);
			bool flag2 = !flag;
			cc6d27704883d7782e5df9603fec73026 result;
			if (flag2)
			{
				result = null;
			}
			else
			{
				result = cc6d27704883d7782e5df9603fec;
			}
			return result;
		}

		public static string c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026 c79824cd743ab343b260dda3e87592238)
		{
			bool cc11fb07a909d9529b4790c9c45e0f = c79824cd743ab343b260dda3e87592238.cc11fb07a909d9529b4790c9c45e0f738;
			string result;
			if (cc11fb07a909d9529b4790c9c45e0f)
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
				if (!true)
				{
					RuntimeMethodHandle arg_1F_0 = methodof(cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026)).MethodHandle;
				}
				result = null;
			}
			else
			{
				result = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(c79824cd743ab343b260dda3e87592238.c64b6942adfe7f41a06ac889222c286fd);
			}
			return result;
		}

		public static string c36fbbc1f680e88365e7b204edfb471aa(IntPtr c95eba6015d19bd7c0515b75623010ff3)
		{
			bool flag = c95eba6015d19bd7c0515b75623010ff3 == IntPtr.Zero;
			string result;
			if (flag)
			{
				result = null;
			}
			else
			{
				int num = 0;
				string text = string.Empty;
				cc6d27704883d7782e5df9603fec73026.c17e8bfc20f292071104908fa1abad872(c95eba6015d19bd7c0515b75623010ff3, 2, IntPtr.Zero, 0, ref num);
				IntPtr intPtr = Marshal.AllocHGlobal(num);
				bool flag2 = cc6d27704883d7782e5df9603fec73026.c17e8bfc20f292071104908fa1abad872(c95eba6015d19bd7c0515b75623010ff3, 2, intPtr, num, ref num);
				text = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
				bool flag3 = !flag2;
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
					if (!true)
					{
						RuntimeMethodHandle arg_74_0 = methodof(cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(IntPtr)).MethodHandle;
					}
					result = null;
				}
				else
				{
					result = text;
				}
			}
			return result;
		}

		public static bool c8ac753abcf15e568429deb29ba12230e(string c4dedb7816e1384806490715c43d6f478)
		{
			return cc6d27704883d7782e5df9603fec73026.c8ac753abcf15e568429deb29ba12230e(c4dedb7816e1384806490715c43d6f478, false);
		}

		public static bool c8ac753abcf15e568429deb29ba12230e(string c4dedb7816e1384806490715c43d6f478, bool ccfd27c907c74421f5de9b552d6e2bc6a)
		{
			string[] array = cc6d27704883d7782e5df9603fec73026.c39996e6baa29146f1b88dbe0ed133778();
			string[] array2 = array;
			bool result;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = array2[i];
				if (ccfd27c907c74421f5de9b552d6e2bc6a)
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
						RuntimeMethodHandle arg_31_0 = methodof(cc6d27704883d7782e5df9603fec73026.c8ac753abcf15e568429deb29ba12230e(string, bool)).MethodHandle;
					}
					bool flag = text.ToLower() == c4dedb7816e1384806490715c43d6f478.ToLower();
					if (flag)
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
						result = true;
						return result;
					}
				}
				else
				{
					bool flag2 = text == c4dedb7816e1384806490715c43d6f478;
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
						result = true;
						return result;
					}
				}
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
			result = false;
			return result;
		}

		public static Process c50ee25c9382d445ea99400e156df8105(string c833fb49637f16a63c5b4ea4413bad494, string c79824cd743ab343b260dda3e87592238)
		{
			bool flag = !cc6d27704883d7782e5df9603fec73026.c8ac753abcf15e568429deb29ba12230e(c79824cd743ab343b260dda3e87592238);
			Process result;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_22_0 = methodof(cc6d27704883d7782e5df9603fec73026.c50ee25c9382d445ea99400e156df8105(string, string)).MethodHandle;
				}
				result = null;
			}
			else
			{
				cc6d27704883d7782e5df9603fec73026 cc6d27704883d7782e5df9603fec = cc6d27704883d7782e5df9603fec73026.c84c59b2e6a2b94e695854b232ba0cad2(c79824cd743ab343b260dda3e87592238);
				result = cc6d27704883d7782e5df9603fec.c50ee25c9382d445ea99400e156df8105(c833fb49637f16a63c5b4ea4413bad494);
			}
			return result;
		}

		public static Process[] c9c460168d627fd160babce4ef6157d97()
		{
			Process[] processes = Process.GetProcesses();
			ArrayList arrayList = new ArrayList();
			string b = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.c61a52af03cc9aab290279cdfd5770132.c64b6942adfe7f41a06ac889222c286fd);
			Process[] array = processes;
			for (int i = 0; i < array.Length; i++)
			{
				Process process = array[i];
				using (IEnumerator enumerator = process.Threads.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ProcessThread processThread = (ProcessThread)enumerator.Current;
						bool flag = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) == b;
						if (flag)
						{
							arrayList.Add(process);
							goto IL_BD;
						}
					}
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
						RuntimeMethodHandle arg_A4_0 = methodof(cc6d27704883d7782e5df9603fec73026.c9c460168d627fd160babce4ef6157d97()).MethodHandle;
					}
				}
				IL_BD:;
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
			Process[] array2 = new Process[arrayList.Count];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = (Process)arrayList[j];
			}
			return array2;
		}

		public static void cdf7821b0cb38b86584002c6bc6be499e(string[] ca105d0d06c776de47895dbb11de8dd94)
		{
			Process[] processes = Process.GetProcesses();
			ArrayList arrayList = new ArrayList();
			string b = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.c61a52af03cc9aab290279cdfd5770132.c64b6942adfe7f41a06ac889222c286fd);
			Process[] array = processes;
			for (int i = 0; i < array.Length; i++)
			{
				Process process = array[i];
				using (IEnumerator enumerator = process.Threads.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ProcessThread processThread = (ProcessThread)enumerator.Current;
						bool flag = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) == b;
						if (flag)
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
							if (!true)
							{
								RuntimeMethodHandle arg_96_0 = methodof(cc6d27704883d7782e5df9603fec73026.cdf7821b0cb38b86584002c6bc6be499e(string[])).MethodHandle;
							}
							for (int j = 0; j <= ca105d0d06c776de47895dbb11de8dd94.Length - 1; j++)
							{
								bool arg_DF_0;
								if (process.ProcessName == ca105d0d06c776de47895dbb11de8dd94[j].ToString())
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
									arg_DF_0 = (cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) == b);
								}
								else
								{
									arg_DF_0 = false;
								}
								bool flag2 = arg_DF_0;
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
									process.Kill();
								}
							}
							while (true)
							{
								switch (1)
								{
								case 0:
									continue;
								}
								break;
							}
							arrayList.Add(process);
						}
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
				}
			}
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
		}

		public static void cdf7821b0cb38b86584002c6bc6be499e(DataTable ca105d0d06c776de47895dbb11de8dd94)
		{
			bool flag = ca105d0d06c776de47895dbb11de8dd94.Rows.Count < 1;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_29_0 = methodof(cc6d27704883d7782e5df9603fec73026.cdf7821b0cb38b86584002c6bc6be499e(DataTable)).MethodHandle;
				}
			}
			else
			{
				Process[] processes = Process.GetProcesses();
				ArrayList arrayList = new ArrayList();
				string str = "";
				string b = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.c61a52af03cc9aab290279cdfd5770132.c64b6942adfe7f41a06ac889222c286fd);
				Process[] array = processes;
				for (int i = 0; i < array.Length; i++)
				{
					Process process = array[i];
					using (IEnumerator enumerator = process.Threads.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							ProcessThread processThread = (ProcessThread)enumerator.Current;
							bool flag2 = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) == b;
							if (flag2)
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
								for (int j = 0; j <= ca105d0d06c776de47895dbb11de8dd94.Rows.Count - 1; j++)
								{
									bool flag3 = process.ProcessName == ca105d0d06c776de47895dbb11de8dd94.Rows[j].ItemArray[1].ToString() && cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) == b;
									if (flag3)
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
										try
										{
											str += process.ProcessName;
											process.Kill();
										}
										catch
										{
										}
									}
								}
							}
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
				}
				while (true)
				{
					switch (6)
					{
					case 0:
						continue;
					}
					break;
				}
			}
		}

		public void Dispose()
		{
			this.c5cea734cb593591bccd77e81ed4750d3(true);
			GC.SuppressFinalize(this);
		}

		public virtual void c5cea734cb593591bccd77e81ed4750d3(bool c96e8994401c49e3ff4b61e36865a4609)
		{
			bool flag = !this.c0d7fe0ebc5cb727122479609db8dc632;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_20_0 = methodof(cc6d27704883d7782e5df9603fec73026.c5cea734cb593591bccd77e81ed4750d3(bool)).MethodHandle;
				}
				this.cd7c36a907b606f70262d2841af9404cc();
			}
			this.c0d7fe0ebc5cb727122479609db8dc632 = true;
		}

		private void ccead173904051acf8103bfc760ff25c1()
		{
			bool flag = this.c0d7fe0ebc5cb727122479609db8dc632;
			if (flag)
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
				if (!true)
				{
					RuntimeMethodHandle arg_1D_0 = methodof(cc6d27704883d7782e5df9603fec73026.ccead173904051acf8103bfc760ff25c1()).MethodHandle;
				}
				throw new ObjectDisposedException("");
			}
		}

		public object Clone()
		{
			this.ccead173904051acf8103bfc760ff25c1();
			cc6d27704883d7782e5df9603fec73026 cc6d27704883d7782e5df9603fec = new cc6d27704883d7782e5df9603fec73026();
			bool cc11fb07a909d9529b4790c9c45e0f = this.cc11fb07a909d9529b4790c9c45e0f738;
			if (cc11fb07a909d9529b4790c9c45e0f)
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
				if (!true)
				{
					RuntimeMethodHandle arg_2C_0 = methodof(cc6d27704883d7782e5df9603fec73026.Clone()).MethodHandle;
				}
				cc6d27704883d7782e5df9603fec.cf549f4524757b110599fa74d43cc2993(this.c07fd463328beb69882c5f5abf304761d);
			}
			return cc6d27704883d7782e5df9603fec;
		}

		public override string ToString()
		{
			return this.c07fd463328beb69882c5f5abf304761d;
		}
	}
}
