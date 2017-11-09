using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;

namespace A
{
	internal class c98d268433aff2e8318ffa81b2310b67e : IDisposable, ICloneable
	{
		private delegate bool cfd11067bce44822f5e5138ce0beef41a(string lpszDesktop, IntPtr lParam);

		private delegate bool c5c6633dcaa56624f830eb953c21b6de4(IntPtr desktopHandle, IntPtr lParam);

		private struct cf5faed29c5415bf43a973ba1c78ce011
		{
			public IntPtr c9aaafbf71ecee0041db45665535a31b3;

			public IntPtr c5d53b52ad163be0d9f8b67672c1325f2;

			public int ceb92aa65bebd3b037b8ac5aa291667c7;

			public int cd6b915b0feec07dccc875043071e70a2;
		}

		private struct cd27d47cf31cfb4c5cd86b3a5f3c14d32
		{
			public int caa33a1a2901e87fdfea8f13d49e776ef;

			public string c42515badef06ebc566815e618375a564;

			public string c5bf0759132f0e222fb5786695b37b58c;

			public string c0712a52f5375e603144f6988f62fbd75;

			public int c944357ceecb3baf52cd530cc413ba3bb;

			public int c55c606ea5c649d85cc2d338c931eb670;

			public int c4bfea45977a29758315fcb94e83bc9c1;

			public int c496fb83934cfdcceca6d30a72ab67b5b;

			public int c63cae7efb84b3a8c7698d1efe0ada755;

			public int c81f920646c13d4204cefac8628f3b7d0;

			public int cdc5667a41b2c307875d6d6b68e14ac76;

			public int ce3c7b0e2f8ea2cbad2f42ba06daa5aa0;

			public short cdcbf8e593f2e13922c2e1bd12068480c;

			public short c2952e7c0b7e414c943ed2f06d3e63fc3;

			public IntPtr cf85b7eb0fd638933888ebc282415f98d;

			public IntPtr c5b1eebd3d7ddbc6a8cbe30d962c522a4;

			public IntPtr ce6171727e4889f4b7541b5d6a24a6a68;

			public IntPtr c1cf14973369afe88af6733d8e09709ea;
		}

		public struct c253aaa426c4801bb0c069f408c8c2a65
		{
			private IntPtr c4e352cea75f673b0960d7ecc5a4a6c8c;

			private string cf3cf97b86c07d45a8214becfffaa9e2e;

			public IntPtr c7cca967c67b309297b28bd06859ae4b1
			{
				get
				{
					return this.c4e352cea75f673b0960d7ecc5a4a6c8c;
				}
			}

			public string cf20e9ca3b031a4a95ee8bb54a1496616
			{
				get
				{
					return this.cf3cf97b86c07d45a8214becfffaa9e2e;
				}
			}

			public c253aaa426c4801bb0c069f408c8c2a65(IntPtr c381171b5a594f6343bfe417250451a79, string cb8e77590439085e88c814916a4c7883b)
			{
				this.c4e352cea75f673b0960d7ecc5a4a6c8c = c381171b5a594f6343bfe417250451a79;
				this.cf3cf97b86c07d45a8214becfffaa9e2e = cb8e77590439085e88c814916a4c7883b;
			}
		}

		[DefaultMember("Item")]
		public class c08d72c45a9009bb2706acdb799cddd64 : CollectionBase
		{
			public c98d268433aff2e8318ffa81b2310b67e.c253aaa426c4801bb0c069f408c8c2a65 c58de8ae6011df4f05d649efc0d7103e1
			{
				get
				{
					return (c98d268433aff2e8318ffa81b2310b67e.c253aaa426c4801bb0c069f408c8c2a65)base.List[cdbb641e3014aef25b4e4c88a6377bff9];
				}
			}

			public void c6478a815ee6c2abf53269b4d389c94b9(c98d268433aff2e8318ffa81b2310b67e.c253aaa426c4801bb0c069f408c8c2a65 cd8be01f1547e123e2f117448a68cded1)
			{
				base.List.Add(cd8be01f1547e123e2f117448a68cded1);
			}
		}

		public const int c064b3e169417d2a04059b8edb9c1daa2 = 100;

		private const short c35ded12df4e3bedec0984c0716b0b17a = 0;

		private const short ca948d1fbf02520a2311d02e7edeef65e = 1;

		private const int c748d126badbf61a154e9e9f59e24b77d = 256;

		private const int ceaf231ca43b0c0c8ebbbaa6f554efe40 = 1;

		private const int cf3e42cd685a9c8ff0a9cffc20e6a84e9 = 2;

		private const int cb210f62215b26f8ecb3fb42ad0548ef9 = 4;

		private const int c74b5e9580a69e9aa156ad7da9f9caaa0 = 32;

		private const long cc7b648575c284fee5a52a3d786bfd8cb = 2L;

		private const long cab39558e64de62ac5f8b6622c9935481 = 64L;

		private const long cf4a6c37eb6c581ac90ef5050ee7ae616 = 128L;

		private const long c95308cec1d2fcefd83b64d0019dfe6fb = 256L;

		private const long cb0e4a9136450c370525bcd9dbd7db3a1 = 4L;

		private const long c1893ee8d39370a613b98f4b5d111adb6 = 8L;

		private const long ccb04b0da19b179ffa3124fddd842c35d = 1L;

		private const long c8ea0e0ce0c49538fbd31e1d5608b584d = 16L;

		private const long cdaab269ea1cfa46d16f753815991f7b9 = 32L;

		private const long ca4ef5eae22f07750bc48ea164d93d698 = 511L;

		private IntPtr c5554a70f6603870bb8aaefdd35dfa0f3;

		private string c935120ebeb441b9bfeedf673a3d846ca;

		private static StringCollection c484f196cf4fb973f5023150f1cac0450;

		private ArrayList c762a0f78bd89025eb0ec1fc2e9c7c0b7;

		private bool cf04bf868ff3d14bf2fee36c7ac0b3613;

		public static readonly c98d268433aff2e8318ffa81b2310b67e cd3a2411ef36df157537179c4ff643cd4 = c98d268433aff2e8318ffa81b2310b67e.caf4cf3b5993ed7c186905bf003bc2eb4();

		public static readonly c98d268433aff2e8318ffa81b2310b67e c199b8958f035a5267b76668d393204af = c98d268433aff2e8318ffa81b2310b67e.ccd7fe69adf763b5e94d688384d1eb935();

		public bool ccbb35f4f55c718883d859cfa18c1281e
		{
			get
			{
				return this.c5554a70f6603870bb8aaefdd35dfa0f3 != IntPtr.Zero;
			}
		}

		public string c9d70f554d3e3dd15cb1209b6b9c49e87
		{
			get
			{
				return this.c935120ebeb441b9bfeedf673a3d846ca;
			}
		}

		public IntPtr c38472f73e6d2fadcdccf0566cd533d8b
		{
			get
			{
				return this.c5554a70f6603870bb8aaefdd35dfa0f3;
			}
		}

		public c98d268433aff2e8318ffa81b2310b67e()
		{
			this.c5554a70f6603870bb8aaefdd35dfa0f3 = IntPtr.Zero;
			this.c935120ebeb441b9bfeedf673a3d846ca = string.Empty;
			this.c762a0f78bd89025eb0ec1fc2e9c7c0b7 = new ArrayList();
			this.cf04bf868ff3d14bf2fee36c7ac0b3613 = false;
		}

		private c98d268433aff2e8318ffa81b2310b67e(IntPtr caa99decb53e932e63090027e99fada6f)
		{
			this.c5554a70f6603870bb8aaefdd35dfa0f3 = caa99decb53e932e63090027e99fada6f;
			this.c935120ebeb441b9bfeedf673a3d846ca = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(caa99decb53e932e63090027e99fada6f);
			this.c762a0f78bd89025eb0ec1fc2e9c7c0b7 = new ArrayList();
			this.cf04bf868ff3d14bf2fee36c7ac0b3613 = false;
		}

		[DllImport("kernel32.dll", EntryPoint = "GetThreadId")]
		private static extern int c080e5dbbea54f7063fdbb0c4671505a1(IntPtr c77674263f75aec4a62fe3afca9570f80);

		[DllImport("kernel32.dll", EntryPoint = "GetProcessId")]
		private static extern int cdd9f7b00775e3bebc4598086563758e7(IntPtr c5c565ba8e6c89830dfb9a4670e517737);

		[DllImport("user32.dll", EntryPoint = "CreateDesktop")]
		private static extern IntPtr c769ec1b5927d71f7326a1cee9f1a3a27(string c5098e7f1f6a140603e8dfadc022b30bb, IntPtr cf3c942f114cfd0488e2bcfa937f0abb7, IntPtr c5cabd845fae9da3e37fa062a74b55d35, int ce3c7b0e2f8ea2cbad2f42ba06daa5aa0, long c3dd4c3c8bd605b268e2941c071b8b8fc, IntPtr ccdbe83b876db6fecbd33e5ab8f4dbb34);

		[DllImport("user32.dll", EntryPoint = "CloseDesktop")]
		private static extern bool cdea27a64ce22759b6783520e3a63db28(IntPtr c88dd916bfe1f040924684a6a65c705e1);

		[DllImport("user32.dll", EntryPoint = "OpenDesktop")]
		private static extern IntPtr ca2cf48a8c071831df41c2df88a96dad5(string c5098e7f1f6a140603e8dfadc022b30bb, int ce3c7b0e2f8ea2cbad2f42ba06daa5aa0, bool c9051751547acda237670378c606e02ab, long c3dd4c3c8bd605b268e2941c071b8b8fc);

		[DllImport("user32.dll", EntryPoint = "OpenInputDesktop")]
		private static extern IntPtr ccd7fe69adf763b5e94d688384d1eb935(int ce3c7b0e2f8ea2cbad2f42ba06daa5aa0, bool c9051751547acda237670378c606e02ab, long c3dd4c3c8bd605b268e2941c071b8b8fc);

		[DllImport("user32.dll", EntryPoint = "SwitchDesktop")]
		private static extern bool c2fd10da5e8a749f884e9cd1e229f76fd(IntPtr c88dd916bfe1f040924684a6a65c705e1);

		[DllImport("user32.dll", EntryPoint = "EnumDesktops")]
		private static extern bool cca395aeb3b1a5106e788ba8509dd369b(IntPtr c7090d14137b293d3dbd535ca66b33b89, c98d268433aff2e8318ffa81b2310b67e.cfd11067bce44822f5e5138ce0beef41a cf73a8c60006a9a1d138896adf78b7f3a, IntPtr c0e6cb9e1a6cfa653a439e8ddad62da00);

		[DllImport("user32.dll", EntryPoint = "GetProcessWindowStation")]
		private static extern IntPtr c2ac9cf444bbc510882a1b8504ee65d0a();

		[DllImport("user32.dll", EntryPoint = "EnumDesktopWindows")]
		private static extern bool ce741324f548a39062be82871adcc5bb2(IntPtr c88dd916bfe1f040924684a6a65c705e1, c98d268433aff2e8318ffa81b2310b67e.c5c6633dcaa56624f830eb953c21b6de4 c0879e47c2331df1d354991bfea3fb0f5, IntPtr c0e6cb9e1a6cfa653a439e8ddad62da00);

		[DllImport("user32.dll", EntryPoint = "SetThreadDesktop")]
		private static extern bool c4ad761069e2403fe6c66e9a905e316e8(IntPtr c88dd916bfe1f040924684a6a65c705e1);

		[DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
		private static extern IntPtr c2d9f17ca4d0e24b7fef811f3de7f9d98(int cd6b915b0feec07dccc875043071e70a2);

		[DllImport("user32.dll", EntryPoint = "GetUserObjectInformation")]
		private static extern bool cfe0039ae4c6f715aae6090c6a94ea683(IntPtr c7d454ed3eee7640470b1efa438eef0a3, int c5787b7110d6d5ba88372bf2da25dbbe5, IntPtr cd9e10542ef14c86c6b83fad3ff93510d, int cca0a280e6fb468f073bfc1ecfd22287c, ref int cd2f1f26543a02fb066b25e0a7beafb05);

		[DllImport("kernel32.dll", EntryPoint = "CreateProcess")]
		private static extern bool ce61fc351dbc70067477abcb78fc3eb3c(string c36fa83d22ddb42290246f54141408bea, string ccd4746d772987fdd29e186ddf36ea5d3, IntPtr cef9b5839211c8e026f62cad17e302ea0, IntPtr cac96aeef7a3988edfd9f26b434339a56, bool ccc9687ab89b32a88bd27d0f4122bc8ef, int c514aa2f5f91e26db509d6b05c97e6f50, IntPtr c5f2f081b92928e3e3861d2817c12a1e4, string cd82f8b497f696dfd4424c08055fd6c14, ref c98d268433aff2e8318ffa81b2310b67e.cd27d47cf31cfb4c5cd86b3a5f3c14d32 c34d6e38b01c5ebbb0d1dcd5a4eb45adb, ref c98d268433aff2e8318ffa81b2310b67e.cf5faed29c5415bf43a973ba1c78ce011 c5cb8eb20b73c58085fc81059dbf15c17);

		[DllImport("user32.dll", EntryPoint = "GetWindowText")]
		private static extern int c6281cc9975c32682beb9e66e62487458(IntPtr ce22792c1c7017cdead08ab20d0ab221e, IntPtr c1d643a34d84a2fb02fd795bb7a952709, int ce468003b9b42265d37d378375e05cbe7);

		~c98d268433aff2e8318ffa81b2310b67e()
		{
			this.c1d06c1e682025f45574ef6cfbd18dbd6();
		}

		public bool c810f8457b884ef078e02f1eefbfe6e56(string c543c9d87b732886afab8a7a74ecaa2e1)
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool flag = this.c5554a70f6603870bb8aaefdd35dfa0f3 != IntPtr.Zero;
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
					RuntimeMethodHandle arg_30_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c810f8457b884ef078e02f1eefbfe6e56(string)).MethodHandle;
				}
				bool flag2 = !this.c1d06c1e682025f45574ef6cfbd18dbd6();
				if (flag2)
				{
					result = false;
					return result;
				}
			}
			bool flag3 = c98d268433aff2e8318ffa81b2310b67e.caa764c76bbfbfcab0b881bc92994b02d(c543c9d87b732886afab8a7a74ecaa2e1);
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
				result = this.c5be9d6cb106c365b33dda7b843648273(c543c9d87b732886afab8a7a74ecaa2e1);
			}
			else
			{
				this.c5554a70f6603870bb8aaefdd35dfa0f3 = c98d268433aff2e8318ffa81b2310b67e.c769ec1b5927d71f7326a1cee9f1a3a27(c543c9d87b732886afab8a7a74ecaa2e1, IntPtr.Zero, IntPtr.Zero, 0, 511L, IntPtr.Zero);
				this.c935120ebeb441b9bfeedf673a3d846ca = c543c9d87b732886afab8a7a74ecaa2e1;
				bool flag4 = this.c5554a70f6603870bb8aaefdd35dfa0f3 == IntPtr.Zero;
				if (flag4)
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
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		public bool c1d06c1e682025f45574ef6cfbd18dbd6()
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool flag = this.c5554a70f6603870bb8aaefdd35dfa0f3 != IntPtr.Zero;
			bool result;
			if (flag)
			{
				bool flag2 = c98d268433aff2e8318ffa81b2310b67e.cdea27a64ce22759b6783520e3a63db28(this.c5554a70f6603870bb8aaefdd35dfa0f3);
				bool flag3 = flag2;
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
						RuntimeMethodHandle arg_44_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c1d06c1e682025f45574ef6cfbd18dbd6()).MethodHandle;
					}
					this.c5554a70f6603870bb8aaefdd35dfa0f3 = IntPtr.Zero;
					this.c935120ebeb441b9bfeedf673a3d846ca = string.Empty;
				}
				result = flag2;
			}
			else
			{
				result = true;
			}
			return result;
		}

		public bool c5be9d6cb106c365b33dda7b843648273(string c543c9d87b732886afab8a7a74ecaa2e1)
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool flag = this.c5554a70f6603870bb8aaefdd35dfa0f3 != IntPtr.Zero;
			bool result;
			if (flag)
			{
				bool flag2 = !this.c1d06c1e682025f45574ef6cfbd18dbd6();
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
						RuntimeMethodHandle arg_3E_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c5be9d6cb106c365b33dda7b843648273(string)).MethodHandle;
					}
					result = false;
					return result;
				}
			}
			this.c5554a70f6603870bb8aaefdd35dfa0f3 = c98d268433aff2e8318ffa81b2310b67e.ca2cf48a8c071831df41c2df88a96dad5(c543c9d87b732886afab8a7a74ecaa2e1, 0, true, 511L);
			bool flag3 = this.c5554a70f6603870bb8aaefdd35dfa0f3 == IntPtr.Zero;
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
				result = false;
			}
			else
			{
				this.c935120ebeb441b9bfeedf673a3d846ca = c543c9d87b732886afab8a7a74ecaa2e1;
				result = true;
			}
			return result;
		}

		public bool c24e26837eb6c8da8ea2e23f5fb8ad29a()
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool flag = this.c5554a70f6603870bb8aaefdd35dfa0f3 != IntPtr.Zero;
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
					RuntimeMethodHandle arg_30_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c24e26837eb6c8da8ea2e23f5fb8ad29a()).MethodHandle;
				}
				bool flag2 = !this.c1d06c1e682025f45574ef6cfbd18dbd6();
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
					result = false;
					return result;
				}
			}
			this.c5554a70f6603870bb8aaefdd35dfa0f3 = c98d268433aff2e8318ffa81b2310b67e.ccd7fe69adf763b5e94d688384d1eb935(0, true, 511L);
			bool flag3 = this.c5554a70f6603870bb8aaefdd35dfa0f3 == IntPtr.Zero;
			if (flag3)
			{
				result = false;
			}
			else
			{
				this.c935120ebeb441b9bfeedf673a3d846ca = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(this.c5554a70f6603870bb8aaefdd35dfa0f3);
				result = true;
			}
			return result;
		}

		public bool c62a26dfc9d51fc5967340b5453831a60()
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool flag = this.c5554a70f6603870bb8aaefdd35dfa0f3 == IntPtr.Zero;
			bool result;
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
				if (!true)
				{
					RuntimeMethodHandle arg_2E_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c62a26dfc9d51fc5967340b5453831a60()).MethodHandle;
				}
				result = false;
			}
			else
			{
				bool flag2 = c98d268433aff2e8318ffa81b2310b67e.c2fd10da5e8a749f884e9cd1e229f76fd(this.c5554a70f6603870bb8aaefdd35dfa0f3);
				result = flag2;
			}
			return result;
		}

		public c98d268433aff2e8318ffa81b2310b67e.c08d72c45a9009bb2706acdb799cddd64 c18b3f62aa503837b142d9a24f72cdc3c()
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool flag = !this.ccbb35f4f55c718883d859cfa18c1281e;
			c98d268433aff2e8318ffa81b2310b67e.c08d72c45a9009bb2706acdb799cddd64 result;
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
					RuntimeMethodHandle arg_29_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c18b3f62aa503837b142d9a24f72cdc3c()).MethodHandle;
				}
				result = null;
			}
			else
			{
				this.c762a0f78bd89025eb0ec1fc2e9c7c0b7.Clear();
				c98d268433aff2e8318ffa81b2310b67e.c08d72c45a9009bb2706acdb799cddd64 c08d72c45a9009bb2706acdb799cddd = new c98d268433aff2e8318ffa81b2310b67e.c08d72c45a9009bb2706acdb799cddd64();
				bool flag2 = c98d268433aff2e8318ffa81b2310b67e.ce741324f548a39062be82871adcc5bb2(this.c5554a70f6603870bb8aaefdd35dfa0f3, new c98d268433aff2e8318ffa81b2310b67e.c5c6633dcaa56624f830eb953c21b6de4(this.c061829e2c6f4f8fca23f9da5296b3975), IntPtr.Zero);
				bool flag3 = !flag2;
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
					result = null;
				}
				else
				{
					c08d72c45a9009bb2706acdb799cddd = new c98d268433aff2e8318ffa81b2310b67e.c08d72c45a9009bb2706acdb799cddd64();
					IntPtr intPtr = Marshal.AllocHGlobal(100);
					using (IEnumerator enumerator = this.c762a0f78bd89025eb0ec1fc2e9c7c0b7.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							IntPtr intPtr2 = (IntPtr)enumerator.Current;
							c98d268433aff2e8318ffa81b2310b67e.c6281cc9975c32682beb9e66e62487458(intPtr2, intPtr, 100);
							c08d72c45a9009bb2706acdb799cddd.c6478a815ee6c2abf53269b4d389c94b9(new c98d268433aff2e8318ffa81b2310b67e.c253aaa426c4801bb0c069f408c8c2a65(intPtr2, Marshal.PtrToStringAnsi(intPtr)));
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
					}
					Marshal.FreeHGlobal(intPtr);
					result = c08d72c45a9009bb2706acdb799cddd;
				}
			}
			return result;
		}

		private bool c061829e2c6f4f8fca23f9da5296b3975(IntPtr c93bd7d654014fd11a086b89295e966b7, IntPtr c0e6cb9e1a6cfa653a439e8ddad62da00)
		{
			this.c762a0f78bd89025eb0ec1fc2e9c7c0b7.Add(c93bd7d654014fd11a086b89295e966b7);
			return true;
		}

		public Process ce61fc351dbc70067477abcb78fc3eb3c(string c345ce88842e864165c4b358ed86d43ab)
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool flag = !this.ccbb35f4f55c718883d859cfa18c1281e;
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
					RuntimeMethodHandle arg_29_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.ce61fc351dbc70067477abcb78fc3eb3c(string)).MethodHandle;
				}
				result = null;
			}
			else
			{
				c98d268433aff2e8318ffa81b2310b67e.cd27d47cf31cfb4c5cd86b3a5f3c14d32 structure = default(c98d268433aff2e8318ffa81b2310b67e.cd27d47cf31cfb4c5cd86b3a5f3c14d32);
				structure.caa33a1a2901e87fdfea8f13d49e776ef = Marshal.SizeOf<c98d268433aff2e8318ffa81b2310b67e.cd27d47cf31cfb4c5cd86b3a5f3c14d32>(structure);
				structure.c5bf0759132f0e222fb5786695b37b58c = this.c935120ebeb441b9bfeedf673a3d846ca;
				c98d268433aff2e8318ffa81b2310b67e.cf5faed29c5415bf43a973ba1c78ce011 cf5faed29c5415bf43a973ba1c78ce = default(c98d268433aff2e8318ffa81b2310b67e.cf5faed29c5415bf43a973ba1c78ce011);
				bool flag2 = c98d268433aff2e8318ffa81b2310b67e.ce61fc351dbc70067477abcb78fc3eb3c(null, c345ce88842e864165c4b358ed86d43ab, IntPtr.Zero, IntPtr.Zero, true, 32, IntPtr.Zero, null, ref structure, ref cf5faed29c5415bf43a973ba1c78ce);
				bool flag3 = !flag2;
				if (flag3)
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
					result = null;
				}
				else
				{
					result = Process.GetProcessById(cf5faed29c5415bf43a973ba1c78ce.ceb92aa65bebd3b037b8ac5aa291667c7);
				}
			}
			return result;
		}

		public void c87944587a0b6079d74731884dd4fc3a3()
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			bool ccbb35f4f55c718883d859cfa18c1281e = this.ccbb35f4f55c718883d859cfa18c1281e;
			if (ccbb35f4f55c718883d859cfa18c1281e)
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
					RuntimeMethodHandle arg_24_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c87944587a0b6079d74731884dd4fc3a3()).MethodHandle;
				}
				this.ce61fc351dbc70067477abcb78fc3eb3c(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84658));
			}
		}

		public static string[] c6cf5db58d9f4c4edc4d9677370581e56()
		{
			IntPtr intPtr = c98d268433aff2e8318ffa81b2310b67e.c2ac9cf444bbc510882a1b8504ee65d0a();
			bool flag = intPtr == IntPtr.Zero;
			string[] result;
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
					RuntimeMethodHandle arg_2C_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c6cf5db58d9f4c4edc4d9677370581e56()).MethodHandle;
				}
				result = new string[0];
			}
			else
			{
				StringCollection obj = c98d268433aff2e8318ffa81b2310b67e.c484f196cf4fb973f5023150f1cac0450 = new StringCollection();
				string[] array;
				lock (obj)
				{
					bool flag3 = c98d268433aff2e8318ffa81b2310b67e.cca395aeb3b1a5106e788ba8509dd369b(intPtr, new c98d268433aff2e8318ffa81b2310b67e.cfd11067bce44822f5e5138ce0beef41a(c98d268433aff2e8318ffa81b2310b67e.c4d3d3032d713793abcbdfa17c80f2dc1), IntPtr.Zero);
					bool flag4 = !flag3;
					if (flag4)
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
						result = new string[0];
						return result;
					}
					array = new string[c98d268433aff2e8318ffa81b2310b67e.c484f196cf4fb973f5023150f1cac0450.Count];
					for (int i = 0; i < array.Length; i++)
					{
						array[i] = c98d268433aff2e8318ffa81b2310b67e.c484f196cf4fb973f5023150f1cac0450[i];
					}
				}
				result = array;
			}
			return result;
		}

		private static bool c4d3d3032d713793abcbdfa17c80f2dc1(string c5098e7f1f6a140603e8dfadc022b30bb, IntPtr c0e6cb9e1a6cfa653a439e8ddad62da00)
		{
			c98d268433aff2e8318ffa81b2310b67e.c484f196cf4fb973f5023150f1cac0450.Add(c5098e7f1f6a140603e8dfadc022b30bb);
			return true;
		}

		public static bool c62a26dfc9d51fc5967340b5453831a60(string c543c9d87b732886afab8a7a74ecaa2e1)
		{
			bool flag = false;
			bool result;
			using (c98d268433aff2e8318ffa81b2310b67e c98d268433aff2e8318ffa81b2310b67e = new c98d268433aff2e8318ffa81b2310b67e())
			{
				flag = c98d268433aff2e8318ffa81b2310b67e.c5be9d6cb106c365b33dda7b843648273(c543c9d87b732886afab8a7a74ecaa2e1);
				bool flag2 = !flag;
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
						RuntimeMethodHandle arg_2E_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c62a26dfc9d51fc5967340b5453831a60(string)).MethodHandle;
					}
					result = false;
					return result;
				}
				flag = c98d268433aff2e8318ffa81b2310b67e.c62a26dfc9d51fc5967340b5453831a60();
			}
			result = flag;
			return result;
		}

		public static bool ce2f644ea85cd96a61a1f1670f7b20c67(c98d268433aff2e8318ffa81b2310b67e caa99decb53e932e63090027e99fada6f)
		{
			bool flag = !caa99decb53e932e63090027e99fada6f.ccbb35f4f55c718883d859cfa18c1281e;
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
					RuntimeMethodHandle arg_20_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.ce2f644ea85cd96a61a1f1670f7b20c67(c98d268433aff2e8318ffa81b2310b67e)).MethodHandle;
				}
				result = false;
			}
			else
			{
				result = c98d268433aff2e8318ffa81b2310b67e.c4ad761069e2403fe6c66e9a905e316e8(caa99decb53e932e63090027e99fada6f.c38472f73e6d2fadcdccf0566cd533d8b);
			}
			return result;
		}

		public static c98d268433aff2e8318ffa81b2310b67e ca2cf48a8c071831df41c2df88a96dad5(string c543c9d87b732886afab8a7a74ecaa2e1)
		{
			c98d268433aff2e8318ffa81b2310b67e c98d268433aff2e8318ffa81b2310b67e = new c98d268433aff2e8318ffa81b2310b67e();
			bool flag = c98d268433aff2e8318ffa81b2310b67e.c5be9d6cb106c365b33dda7b843648273(c543c9d87b732886afab8a7a74ecaa2e1);
			bool flag2 = !flag;
			c98d268433aff2e8318ffa81b2310b67e result;
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
					RuntimeMethodHandle arg_29_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.ca2cf48a8c071831df41c2df88a96dad5(string)).MethodHandle;
				}
				result = null;
			}
			else
			{
				result = c98d268433aff2e8318ffa81b2310b67e;
			}
			return result;
		}

		public static c98d268433aff2e8318ffa81b2310b67e ccd7fe69adf763b5e94d688384d1eb935()
		{
			c98d268433aff2e8318ffa81b2310b67e c98d268433aff2e8318ffa81b2310b67e = new c98d268433aff2e8318ffa81b2310b67e();
			bool flag = c98d268433aff2e8318ffa81b2310b67e.c24e26837eb6c8da8ea2e23f5fb8ad29a();
			bool flag2 = !flag;
			c98d268433aff2e8318ffa81b2310b67e result;
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
				if (!true)
				{
					RuntimeMethodHandle arg_2A_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.ccd7fe69adf763b5e94d688384d1eb935()).MethodHandle;
				}
				result = null;
			}
			else
			{
				result = c98d268433aff2e8318ffa81b2310b67e;
			}
			return result;
		}

		public static c98d268433aff2e8318ffa81b2310b67e caf4cf3b5993ed7c186905bf003bc2eb4()
		{
			return c98d268433aff2e8318ffa81b2310b67e.ca2cf48a8c071831df41c2df88a96dad5(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84683));
		}

		public static c98d268433aff2e8318ffa81b2310b67e c769ec1b5927d71f7326a1cee9f1a3a27(string c543c9d87b732886afab8a7a74ecaa2e1)
		{
			c98d268433aff2e8318ffa81b2310b67e c98d268433aff2e8318ffa81b2310b67e = new c98d268433aff2e8318ffa81b2310b67e();
			bool flag = c98d268433aff2e8318ffa81b2310b67e.c810f8457b884ef078e02f1eefbfe6e56(c543c9d87b732886afab8a7a74ecaa2e1);
			bool flag2 = !flag;
			c98d268433aff2e8318ffa81b2310b67e result;
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
				if (!true)
				{
					RuntimeMethodHandle arg_2B_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c769ec1b5927d71f7326a1cee9f1a3a27(string)).MethodHandle;
				}
				result = null;
			}
			else
			{
				result = c98d268433aff2e8318ffa81b2310b67e;
			}
			return result;
		}

		public static string c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e caa99decb53e932e63090027e99fada6f)
		{
			bool ccbb35f4f55c718883d859cfa18c1281e = caa99decb53e932e63090027e99fada6f.ccbb35f4f55c718883d859cfa18c1281e;
			string result;
			if (ccbb35f4f55c718883d859cfa18c1281e)
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
					RuntimeMethodHandle arg_1F_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e)).MethodHandle;
				}
				result = null;
			}
			else
			{
				result = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(caa99decb53e932e63090027e99fada6f.c38472f73e6d2fadcdccf0566cd533d8b);
			}
			return result;
		}

		public static string c5d6ec0f01c15237862b9e73082547873(IntPtr cf5d6579348a648815e146210a558cbbf)
		{
			bool flag = cf5d6579348a648815e146210a558cbbf == IntPtr.Zero;
			string result;
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
					RuntimeMethodHandle arg_26_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(IntPtr)).MethodHandle;
				}
				result = null;
			}
			else
			{
				int num = 0;
				string text = string.Empty;
				c98d268433aff2e8318ffa81b2310b67e.cfe0039ae4c6f715aae6090c6a94ea683(cf5d6579348a648815e146210a558cbbf, 2, IntPtr.Zero, 0, ref num);
				IntPtr intPtr = Marshal.AllocHGlobal(num);
				bool flag2 = c98d268433aff2e8318ffa81b2310b67e.cfe0039ae4c6f715aae6090c6a94ea683(cf5d6579348a648815e146210a558cbbf, 2, intPtr, num, ref num);
				text = Marshal.PtrToStringAnsi(intPtr);
				Marshal.FreeHGlobal(intPtr);
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
					result = text;
				}
			}
			return result;
		}

		public static bool caa764c76bbfbfcab0b881bc92994b02d(string c543c9d87b732886afab8a7a74ecaa2e1)
		{
			return c98d268433aff2e8318ffa81b2310b67e.caa764c76bbfbfcab0b881bc92994b02d(c543c9d87b732886afab8a7a74ecaa2e1, false);
		}

		public static bool caa764c76bbfbfcab0b881bc92994b02d(string c543c9d87b732886afab8a7a74ecaa2e1, bool c2610af3020ca29fdd556040ddbfb5f4f)
		{
			string[] array = c98d268433aff2e8318ffa81b2310b67e.c6cf5db58d9f4c4edc4d9677370581e56();
			string[] array2 = array;
			bool result;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = array2[i];
				if (c2610af3020ca29fdd556040ddbfb5f4f)
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
						RuntimeMethodHandle arg_2E_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.caa764c76bbfbfcab0b881bc92994b02d(string, bool)).MethodHandle;
					}
					bool flag = text.ToLower() == c543c9d87b732886afab8a7a74ecaa2e1.ToLower();
					if (flag)
					{
						result = true;
						return result;
					}
				}
				else
				{
					bool flag2 = text == c543c9d87b732886afab8a7a74ecaa2e1;
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
						result = true;
						return result;
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
			result = false;
			return result;
		}

		public static Process ce61fc351dbc70067477abcb78fc3eb3c(string c345ce88842e864165c4b358ed86d43ab, string caa99decb53e932e63090027e99fada6f)
		{
			bool flag = !c98d268433aff2e8318ffa81b2310b67e.caa764c76bbfbfcab0b881bc92994b02d(caa99decb53e932e63090027e99fada6f);
			Process result;
			if (flag)
			{
				result = null;
			}
			else
			{
				c98d268433aff2e8318ffa81b2310b67e c98d268433aff2e8318ffa81b2310b67e = c98d268433aff2e8318ffa81b2310b67e.ca2cf48a8c071831df41c2df88a96dad5(caa99decb53e932e63090027e99fada6f);
				result = c98d268433aff2e8318ffa81b2310b67e.ce61fc351dbc70067477abcb78fc3eb3c(c345ce88842e864165c4b358ed86d43ab);
			}
			return result;
		}

		public static Process[] ce09d0988d700d864e8cd4b19d67db275()
		{
			Process[] processes = Process.GetProcesses();
			ArrayList arrayList = new ArrayList();
			string b = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c199b8958f035a5267b76668d393204af.c38472f73e6d2fadcdccf0566cd533d8b);
			Process[] array = processes;
			for (int i = 0; i < array.Length; i++)
			{
				Process process = array[i];
				IEnumerator enumerator = process.Threads.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ProcessThread processThread = (ProcessThread)enumerator.Current;
						bool flag = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) == b;
						if (flag)
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
								RuntimeMethodHandle arg_8C_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.ce09d0988d700d864e8cd4b19d67db275()).MethodHandle;
							}
							arrayList.Add(process);
							break;
						}
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
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
						disposable.Dispose();
					}
				}
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
			Process[] array2 = new Process[arrayList.Count];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = (Process)arrayList[j];
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
			return array2;
		}

		public static void c0886dd794cddcfebe2483d0cb1382851(string[] ca14813068184a71f191113d10ddc0ec5)
		{
			Process[] processes = Process.GetProcesses();
			ArrayList arrayList = new ArrayList();
			string b = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c199b8958f035a5267b76668d393204af.c38472f73e6d2fadcdccf0566cd533d8b);
			Process[] array = processes;
			for (int i = 0; i < array.Length; i++)
			{
				Process process = array[i];
				using (IEnumerator enumerator = process.Threads.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						ProcessThread processThread = (ProcessThread)enumerator.Current;
						bool flag = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) == b;
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
							if (!true)
							{
								RuntimeMethodHandle arg_8A_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c0886dd794cddcfebe2483d0cb1382851(string[])).MethodHandle;
							}
							for (int j = 0; j <= ca14813068184a71f191113d10ddc0ec5.Length - 1; j++)
							{
								bool arg_D7_0;
								if (process.ProcessName == ca14813068184a71f191113d10ddc0ec5[j].ToString())
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
									arg_D7_0 = (c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) == b);
								}
								else
								{
									arg_D7_0 = false;
								}
								bool flag2 = arg_D7_0;
								if (flag2)
								{
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
						switch (6)
						{
						case 0:
							continue;
						}
						break;
					}
				}
			}
		}

		public static void c0886dd794cddcfebe2483d0cb1382851(DataTable ca14813068184a71f191113d10ddc0ec5)
		{
			bool flag = ca14813068184a71f191113d10ddc0ec5.Rows.Count < 1;
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
					RuntimeMethodHandle arg_27_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c0886dd794cddcfebe2483d0cb1382851(DataTable)).MethodHandle;
				}
			}
			else
			{
				Process[] processes = Process.GetProcesses();
				ArrayList arrayList = new ArrayList();
				string str = "";
				string b = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c199b8958f035a5267b76668d393204af.c38472f73e6d2fadcdccf0566cd533d8b);
				Process[] array = processes;
				for (int i = 0; i < array.Length; i++)
				{
					Process process = array[i];
					IEnumerator enumerator = process.Threads.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ProcessThread processThread = (ProcessThread)enumerator.Current;
							bool flag2 = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) == b;
							if (flag2)
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
								for (int j = 0; j <= ca14813068184a71f191113d10ddc0ec5.Rows.Count - 1; j++)
								{
									bool arg_12B_0;
									if (process.ProcessName == ca14813068184a71f191113d10ddc0ec5.Rows[j].ItemArray[1].ToString())
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
										arg_12B_0 = (c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) == b);
									}
									else
									{
										arg_12B_0 = false;
									}
									bool flag3 = arg_12B_0;
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
							switch (6)
							{
							case 0:
								continue;
							}
							break;
						}
					}
					finally
					{
						IDisposable disposable = enumerator as IDisposable;
						if (disposable != null)
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
							disposable.Dispose();
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

		public void Dispose()
		{
			this.c55f903a5e1705250dda9129eb1eec9f2(true);
			GC.SuppressFinalize(this);
		}

		public virtual void c55f903a5e1705250dda9129eb1eec9f2(bool c6194292e42d612e14426ae0f01081663)
		{
			bool flag = !this.cf04bf868ff3d14bf2fee36c7ac0b3613;
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
					RuntimeMethodHandle arg_20_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c55f903a5e1705250dda9129eb1eec9f2(bool)).MethodHandle;
				}
				this.c1d06c1e682025f45574ef6cfbd18dbd6();
			}
			this.cf04bf868ff3d14bf2fee36c7ac0b3613 = true;
		}

		private void c24fc964b57f876fb49c6c65e067712e4()
		{
			bool flag = this.cf04bf868ff3d14bf2fee36c7ac0b3613;
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
					RuntimeMethodHandle arg_1D_0 = methodof(c98d268433aff2e8318ffa81b2310b67e.c24fc964b57f876fb49c6c65e067712e4()).MethodHandle;
				}
				throw new ObjectDisposedException("");
			}
		}

		public object Clone()
		{
			this.c24fc964b57f876fb49c6c65e067712e4();
			c98d268433aff2e8318ffa81b2310b67e c98d268433aff2e8318ffa81b2310b67e = new c98d268433aff2e8318ffa81b2310b67e();
			bool ccbb35f4f55c718883d859cfa18c1281e = this.ccbb35f4f55c718883d859cfa18c1281e;
			if (ccbb35f4f55c718883d859cfa18c1281e)
			{
				c98d268433aff2e8318ffa81b2310b67e.c5be9d6cb106c365b33dda7b843648273(this.c935120ebeb441b9bfeedf673a3d846ca);
			}
			return c98d268433aff2e8318ffa81b2310b67e;
		}

		public override string ToString()
		{
			return this.c935120ebeb441b9bfeedf673a3d846ca;
		}
	}
}
