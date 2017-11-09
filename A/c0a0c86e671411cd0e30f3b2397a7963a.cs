using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace A
{
	internal class c0a0c86e671411cd0e30f3b2397a7963a
	{
		public enum c7ebde040f2a2e5a8d8d7cc4cce002baf : uint
		{
			cd2b8ce69f6fbd0f9b711536c348986d4 = 2035711u,
			c568ea5a2daa117456f7b34afc4cf91ea = 1u,
			cfa5b70d903ecfa2180106ea8f69b7259,
			c4ebc29e18c2d482dcd7ecc35a18fae1a = 8u,
			c442849dd4ac38f26a235bd1a7db3548b = 16u,
			cc2f3dbc3412fded7107fa26e7ce0bf3b = 64u,
			c50ee25c9382d445ea99400e156df8105 = 128u,
			cc856f3ef4a03129d01c13a385de257d0 = 256u,
			ce1e1b86428bbd47c527dfa9cd665873e = 512u,
			c1e1effa30ad1b488e367f910abb5e13e = 1024u,
			cc8305c2663bed0f568dc860bb17667cd = 4096u,
			c20f40da3da9ae07fabe746ab9bc5eb10 = 1048576u
		}

		public static string c70bb0ace78a0088a84070e6b909ad5cc = "";

		public DateTime cc9457f23c0c287118f95936d8142eec0 = DateTime.Now;

		public static string ca6a7e3a7911816486f286f96f1170280 = "";

		public static string cf79a66c90b48843fdd0bf97620aeab9a = "";

		public static int c9c9526a47ead3713b241c995de8a05a9 = 0;

		[DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
		private static extern IntPtr cb8fe049137d3b430f7f67832c7669556(int ce23f78f0a0060ae3a2c74f3d3ff90ed8);

		[DllImport("kernel32.dll", EntryPoint = "QueryFullProcessImageName")]
		private static extern bool ca6d613d232a3f96ed58749b556cabb74(IntPtr ce2c5594588ba952823d4a0157d00d783, int cc5609e97e40db9ae1837bbd7f5dac533, StringBuilder c3a084f9272cbdbd695ad955d4c846c99, out int c79fa6f2a44107b1c3fac1807f3fd641b);

		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		private static extern IntPtr c0126e9da9c13a81effe11eb8e0cbe6f8(c0a0c86e671411cd0e30f3b2397a7963a.c7ebde040f2a2e5a8d8d7cc4cce002baf ce48357353ab2822da1ac20ca6819c622, bool c52cb34f18fe0a9d59b5fb5aeb468f847, int c07bed445be3a11bb1d9de6196879453c);

		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
		private static extern bool c7a0a041ac987b0e2fa0cc75af4ff98db(IntPtr c119ea42953bfb5893c900b941e474770);

		public static string cf8c90b7371aada9c874529cf078b2d2a(int cb1aebe4161c2a9d460d628730b0fb9ff)
		{
			bool flag = Environment.OSVersion.Version.Major >= 6;
			string result;
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
					RuntimeMethodHandle arg_32_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.cf8c90b7371aada9c874529cf078b2d2a(int)).MethodHandle;
				}
				result = c0a0c86e671411cd0e30f3b2397a7963a.c8ae3234dcc4a047e94b08a1a36878b6c(cb1aebe4161c2a9d460d628730b0fb9ff);
			}
			else
			{
				string queryString = cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84061) + cb1aebe4161c2a9d460d628730b0fb9ff;
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
				{
					ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
					try
					{
						ManagementObject managementObject = managementObjectCollection.Cast<ManagementObject>().FirstOrDefault<ManagementObject>();
						bool flag2 = managementObject != null;
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
							result = (string)managementObject[cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84203)];
							return result;
						}
					}
					finally
					{
						if (managementObjectCollection != null)
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
							((IDisposable)managementObjectCollection).Dispose();
						}
					}
				}
				result = null;
			}
			return result;
		}

		private static string cf7842f3c2483c23c75ec15d81c25461b(Process c1a0adccfabefa4b4dd3377970e5ee0be)
		{
			bool flag = Environment.OSVersion.Version.Major >= 6;
			string result;
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
					RuntimeMethodHandle arg_2E_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.cf7842f3c2483c23c75ec15d81c25461b(Process)).MethodHandle;
				}
				result = c0a0c86e671411cd0e30f3b2397a7963a.c8ae3234dcc4a047e94b08a1a36878b6c(c1a0adccfabefa4b4dd3377970e5ee0be.Id);
			}
			else
			{
				result = c1a0adccfabefa4b4dd3377970e5ee0be.MainModule.FileName;
			}
			return result;
		}

		private static string c8ae3234dcc4a047e94b08a1a36878b6c(int cb689438c6317ca4d7c88f7ab6b782216)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			IntPtr intPtr = c0a0c86e671411cd0e30f3b2397a7963a.c0126e9da9c13a81effe11eb8e0cbe6f8(c0a0c86e671411cd0e30f3b2397a7963a.c7ebde040f2a2e5a8d8d7cc4cce002baf.cc8305c2663bed0f568dc860bb17667cd, false, cb689438c6317ca4d7c88f7ab6b782216);
			bool flag = intPtr != IntPtr.Zero;
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
					RuntimeMethodHandle arg_3E_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.c8ae3234dcc4a047e94b08a1a36878b6c(int)).MethodHandle;
				}
				try
				{
					int capacity = stringBuilder.Capacity;
					bool flag2 = c0a0c86e671411cd0e30f3b2397a7963a.ca6d613d232a3f96ed58749b556cabb74(intPtr, 0, stringBuilder, out capacity);
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
						return stringBuilder.ToString();
					}
				}
				finally
				{
					c0a0c86e671411cd0e30f3b2397a7963a.c7a0a041ac987b0e2fa0cc75af4ff98db(intPtr);
				}
			}
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}

		public static string cc162f98a5f0edf8e4293618cd5951150(int cb1aebe4161c2a9d460d628730b0fb9ff)
		{
			string queryString = cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84232) + cb1aebe4161c2a9d460d628730b0fb9ff;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString);
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			string result;
			using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					string[] array = new string[]
					{
						string.Empty,
						string.Empty
					};
					int num = Convert.ToInt32(managementObject.InvokeMethod(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84325), array));
					bool flag = num == 0;
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
							RuntimeMethodHandle arg_9D_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.cc162f98a5f0edf8e4293618cd5951150(int)).MethodHandle;
						}
						result = array[1] + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84342) + array[0];
						return result;
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
			result = cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84345);
			return result;
		}

		public static float cfe58c009af041ea76ca5ad470a4b19da(string c1fa5e64cf3b654e28da4e04bd58b1b61)
		{
			FileInfo fileInfo = new FileInfo(c1fa5e64cf3b654e28da4e04bd58b1b61);
			return (float)fileInfo.Length;
		}

		public static void cfce870b5c8cd82aacc33c806bb3d907b(DataTable cad02a771c6e71c587f67ec6c34582d13, DataTable c7e935777139b3dba1bd28c4ccd98b592)
		{
			string text = "";
			string a = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.c61a52af03cc9aab290279cdfd5770132.c64b6942adfe7f41a06ac889222c286fd);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			try
			{
				for (int i = 0; i < cad02a771c6e71c587f67ec6c34582d13.Rows.Count; i++)
				{
					text = string.Concat(new string[]
					{
						text,
						cad02a771c6e71c587f67ec6c34582d13.Rows[i][1].ToString().ToUpper(),
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362),
						cad02a771c6e71c587f67ec6c34582d13.Rows[i][2].ToString(),
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362)
					});
				}
			}
			catch
			{
			}
			c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a = Environment.UserDomainName + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84342) + Environment.UserName;
			while (true)
			{
				string text2 = "";
				try
				{
					Process[] processes = Process.GetProcesses();
					string text3 = "";
					Process[] array = processes;
					for (int j = 0; j < array.Length; j++)
					{
						Process process = array[j];
						string text4 = c0a0c86e671411cd0e30f3b2397a7963a.cc162f98a5f0edf8e4293618cd5951150(process.Id);
						int num4 = 0;
						for (int k = 0; k < c7e935777139b3dba1bd28c4ccd98b592.Rows.Count; k++)
						{
							bool arg_1AA_0;
							if (!(text4.ToUpper() == c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a.ToUpper()))
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
									RuntimeMethodHandle arg_16E_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.cfce870b5c8cd82aacc33c806bb3d907b(DataTable, DataTable)).MethodHandle;
								}
								arg_1AA_0 = (text4.ToUpper() == c7e935777139b3dba1bd28c4ccd98b592.Rows[k].ItemArray[1].ToString().ToUpper());
							}
							else
							{
								arg_1AA_0 = true;
							}
							bool flag = arg_1AA_0;
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
								num4++;
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
						bool flag2 = num4 > 0;
						if (!flag2)
						{
							Environment.Exit(0);
							Application.Exit();
							break;
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
						c0a0c86e671411cd0e30f3b2397a7963a.c9c9526a47ead3713b241c995de8a05a9 = 0;
						bool flag3 = c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a.ToUpper() == text4.ToUpper();
						if (flag3)
						{
							try
							{
								bool flag4 = process.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84365);
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
									num++;
								}
								text2 = text2 + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84374) + process.ProcessName.ToUpper() + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84377);
								using (IEnumerator enumerator = process.Threads.GetEnumerator())
								{
									if (!enumerator.MoveNext())
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
									}
									else
									{
										ProcessThread processThread = (ProcessThread)enumerator.Current;
										text3 = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(c0a0c86e671411cd0e30f3b2397a7963a.cb8fe049137d3b430f7f67832c7669556(processThread.Id));
									}
								}
								float num5 = 0f;
								try
								{
									num5 = c0a0c86e671411cd0e30f3b2397a7963a.cfe58c009af041ea76ca5ad470a4b19da(c0a0c86e671411cd0e30f3b2397a7963a.cf8c90b7371aada9c874529cf078b2d2a(process.Id).ToString());
								}
								catch
								{
									num5 = 0f;
								}
								string text5 = "";
								text5 = process.ProcessName.ToUpper() + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362) + num5.ToString();
								text2 = string.Concat(new string[]
								{
									text2,
									text3,
									cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84377),
									text5,
									cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84380)
								});
								bool flag5 = a == text3;
								if (flag5)
								{
									bool flag6 = !text.Contains(text5);
									if (flag6)
									{
										text5 += cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84383);
										try
										{
											process.Kill();
											text2 = text2 + text5 + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84394);
										}
										catch
										{
											text2 = text2 + text5 + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84411);
										}
										num3 = 1;
									}
								}
							}
							catch
							{
							}
						}
					}
					bool flag7 = num3 == 1;
					if (flag7)
					{
						text2 = "";
						num3 = 0;
					}
				}
				catch
				{
					text2 = "";
					num = 0;
				}
				bool flag8 = num == 1;
				if (flag8)
				{
					break;
				}
				num = 0;
				Process[] processes2 = Process.GetProcesses();
				Process[] array2 = processes2;
				for (int l = 0; l < array2.Length; l++)
				{
					Process process2 = array2[l];
					bool flag9 = process2.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84365);
					if (flag9)
					{
						num++;
					}
					bool flag10 = process2.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84434) || process2.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84455);
					if (flag10)
					{
						num2++;
					}
				}
				bool arg_55F_0;
				if (num != 1)
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
					arg_55F_0 = (num2 == 0);
				}
				else
				{
					arg_55F_0 = true;
				}
				bool flag11 = arg_55F_0;
				if (flag11)
				{
					goto IL_565;
				}
				Thread.Sleep(2000);
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
			c0a0c86e671411cd0e30f3b2397a7963a.c9c9526a47ead3713b241c995de8a05a9 = 1;
			return;
			while (true)
			{
				IL_565:
				switch (3)
				{
				case 0:
					continue;
				}
				break;
			}
			c0a0c86e671411cd0e30f3b2397a7963a.c9c9526a47ead3713b241c995de8a05a9 = 1;
			Environment.Exit(0);
			Application.Exit();
		}

		public static void c93faf7c74773007899ea451571170791(DataTable cad02a771c6e71c587f67ec6c34582d13)
		{
			string text = "";
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			string a = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.c61a52af03cc9aab290279cdfd5770132.c64b6942adfe7f41a06ac889222c286fd);
			try
			{
				for (int i = 0; i < cad02a771c6e71c587f67ec6c34582d13.Rows.Count; i++)
				{
					text = string.Concat(new string[]
					{
						text,
						cad02a771c6e71c587f67ec6c34582d13.Rows[i][1].ToString().ToUpper(),
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362),
						cad02a771c6e71c587f67ec6c34582d13.Rows[i][2].ToString(),
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362)
					});
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
				if (!true)
				{
					RuntimeMethodHandle arg_D0_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.c93faf7c74773007899ea451571170791(DataTable)).MethodHandle;
				}
			}
			catch
			{
			}
			c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a = Environment.UserDomainName + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84342) + Environment.UserName;
			while (true)
			{
				string text2 = "";
				try
				{
					Process[] processes = Process.GetProcesses();
					string text3 = "";
					Process[] array = processes;
					for (int j = 0; j < array.Length; j++)
					{
						Process process = array[j];
						string text4 = c0a0c86e671411cd0e30f3b2397a7963a.cc162f98a5f0edf8e4293618cd5951150(process.Id);
						bool flag = c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a.ToUpper() == text4.ToUpper();
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
							try
							{
								bool flag2 = process.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84365);
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
									num++;
								}
								text2 = text2 + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84374) + process.ProcessName.ToUpper() + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84377);
								IEnumerator enumerator = process.Threads.GetEnumerator();
								try
								{
									if (enumerator.MoveNext())
									{
										ProcessThread processThread = (ProcessThread)enumerator.Current;
										text3 = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(c0a0c86e671411cd0e30f3b2397a7963a.cb8fe049137d3b430f7f67832c7669556(processThread.Id));
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									if (disposable != null)
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
										disposable.Dispose();
									}
								}
								float num4 = 0f;
								try
								{
									num4 = c0a0c86e671411cd0e30f3b2397a7963a.cfe58c009af041ea76ca5ad470a4b19da(c0a0c86e671411cd0e30f3b2397a7963a.cf8c90b7371aada9c874529cf078b2d2a(process.Id).ToString());
								}
								catch
								{
									num4 = 0f;
								}
								string text5 = "";
								text5 = process.ProcessName.ToUpper() + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362) + num4.ToString();
								text2 = string.Concat(new string[]
								{
									text2,
									text3,
									cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84377),
									text5,
									cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84380)
								});
								bool flag3 = a == text3;
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
									bool flag4 = !text.Contains(text5);
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
										text5 += cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84383);
										try
										{
											process.Kill();
											text2 = text2 + text5 + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84394);
										}
										catch
										{
											text2 = text2 + text5 + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84411);
										}
										num3 = 1;
									}
								}
							}
							catch
							{
							}
						}
					}
					bool flag5 = num3 == 1;
					if (flag5)
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
						text2 = "";
						num3 = 0;
					}
				}
				catch
				{
					text2 = "";
					num = 0;
				}
				bool flag6 = num == 1;
				if (flag6)
				{
					break;
				}
				num = 0;
				Process[] processes2 = Process.GetProcesses();
				Process[] array2 = processes2;
				for (int k = 0; k < array2.Length; k++)
				{
					Process process2 = array2[k];
					bool flag7 = process2.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84365);
					if (flag7)
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
						num++;
					}
					bool arg_48A_0;
					if (!(process2.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84434)))
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
						arg_48A_0 = (process2.ProcessName.ToUpper() == cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84455));
					}
					else
					{
						arg_48A_0 = true;
					}
					bool flag8 = arg_48A_0;
					if (flag8)
					{
						num2++;
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				bool arg_4C5_0;
				if (num != 1)
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
					arg_4C5_0 = (num2 == 0);
				}
				else
				{
					arg_4C5_0 = true;
				}
				bool flag9 = arg_4C5_0;
				if (flag9)
				{
					goto Block_9;
				}
				Thread.Sleep(2500);
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
			c0a0c86e671411cd0e30f3b2397a7963a.c9c9526a47ead3713b241c995de8a05a9 = 1;
			return;
			Block_9:
			c0a0c86e671411cd0e30f3b2397a7963a.c9c9526a47ead3713b241c995de8a05a9 = 1;
			Environment.Exit(0);
			Application.Exit();
		}

		public static void cfce870b5c8cd82aacc33c806bb3d907b(DataTable cad02a771c6e71c587f67ec6c34582d13, string c011eabec93e06f9439dce24b568209bf)
		{
			string text = "";
			string str = "";
			int num = 0;
			try
			{
				for (int i = 0; i < cad02a771c6e71c587f67ec6c34582d13.Rows.Count; i++)
				{
					text = string.Concat(new string[]
					{
						text,
						cad02a771c6e71c587f67ec6c34582d13.Rows[i][1].ToString().ToUpper(),
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362),
						cad02a771c6e71c587f67ec6c34582d13.Rows[i][2].ToString(),
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362)
					});
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
				if (!true)
				{
					RuntimeMethodHandle arg_C7_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.cfce870b5c8cd82aacc33c806bb3d907b(DataTable, string)).MethodHandle;
				}
			}
			catch
			{
			}
			while (true)
			{
				str = "";
				try
				{
					c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a = Environment.UserDomainName + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84342) + Environment.UserName;
					string b = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.c61a52af03cc9aab290279cdfd5770132.c64b6942adfe7f41a06ac889222c286fd);
					Process[] processes = Process.GetProcesses();
					Process[] array = processes;
					for (int j = 0; j < array.Length; j++)
					{
						Process process = array[j];
						string text2 = c0a0c86e671411cd0e30f3b2397a7963a.cc162f98a5f0edf8e4293618cd5951150(process.Id);
						bool flag = c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a.ToUpper() == text2.ToUpper();
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
							float num2 = 0f;
							try
							{
								num2 = c0a0c86e671411cd0e30f3b2397a7963a.cfe58c009af041ea76ca5ad470a4b19da(c0a0c86e671411cd0e30f3b2397a7963a.cf8c90b7371aada9c874529cf078b2d2a(process.Id).ToString());
							}
							catch
							{
								num2 = 0f;
							}
							string value = process.ProcessName.ToUpper() + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84362) + num2.ToString();
							using (IEnumerator enumerator = process.Threads.GetEnumerator())
							{
								if (!enumerator.MoveNext())
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
								}
								else
								{
									ProcessThread processThread = (ProcessThread)enumerator.Current;
									bool flag2 = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(c0a0c86e671411cd0e30f3b2397a7963a.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) != b;
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
										bool flag3 = !text.Contains(value);
										if (flag3)
										{
											str = str + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84480) + process.ProcessName;
											num = 1;
										}
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
					bool flag4 = num == 1;
					if (flag4)
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
						str = "";
						num = 0;
					}
				}
				catch
				{
					str = "";
					num = 0;
				}
				Thread.Sleep(25000);
			}
		}

		public static void ce3334b24d11583550a48130e287680fc(DataTable cad02a771c6e71c587f67ec6c34582d13)
		{
			c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a = Environment.UserDomainName + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84342) + Environment.UserName;
			string text = "";
			string b = "";
			try
			{
				Process[] processes = Process.GetProcesses();
				string text2 = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(cc6d27704883d7782e5df9603fec73026.c61a52af03cc9aab290279cdfd5770132.c64b6942adfe7f41a06ac889222c286fd);
				text = text2;
				b = text2;
				Process[] array = processes;
				for (int i = 0; i < array.Length; i++)
				{
					Process process = array[i];
					string b2 = c0a0c86e671411cd0e30f3b2397a7963a.cc162f98a5f0edf8e4293618cd5951150(process.Id);
					bool flag = c0a0c86e671411cd0e30f3b2397a7963a.cf79a66c90b48843fdd0bf97620aeab9a == b2;
					if (flag)
					{
						using (IEnumerator enumerator = process.Threads.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								ProcessThread processThread = (ProcessThread)enumerator.Current;
								bool flag2 = cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(c0a0c86e671411cd0e30f3b2397a7963a.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) == text2;
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
										RuntimeMethodHandle arg_ED_0 = methodof(c0a0c86e671411cd0e30f3b2397a7963a.ce3334b24d11583550a48130e287680fc(DataTable)).MethodHandle;
									}
									for (int j = 0; j <= cad02a771c6e71c587f67ec6c34582d13.Rows.Count - 1; j++)
									{
										bool flag3 = process.ProcessName.ToUpper() == cad02a771c6e71c587f67ec6c34582d13.Rows[j].ItemArray[1].ToString().ToUpper() && cc6d27704883d7782e5df9603fec73026.c36fbbc1f680e88365e7b204edfb471aa(c0a0c86e671411cd0e30f3b2397a7963a.cb8fe049137d3b430f7f67832c7669556(processThread.Id)) == text2;
										if (flag3)
										{
											text = text + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(84483) + process.ProcessName;
											process.Kill();
											goto IL_1B5;
										}
									}
									while (true)
									{
										switch (7)
										{
										case 0:
											continue;
										}
										break;
									}
								}
								IL_1B5:;
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
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					break;
				}
				bool flag4 = text != b;
				if (flag4)
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
					text = "";
					b = "";
				}
			}
			catch
			{
				bool flag5 = text != b;
				if (flag5)
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
					text = "";
					b = "";
				}
			}
		}
	}
}
