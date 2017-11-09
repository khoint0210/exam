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
	internal class cb846fc50c97d00ca6b6db07cdc5ac60b
	{
		public enum c1c58ddb6e924f645c15a9b91c618f234 : uint
		{
			cde3756fe0bfc04bb6163385124ab53c0 = 2035711u,
			ce77b96074614d84dbd742f0750a9977a = 1u,
			c8f73cc4cb893751fd98e99798f731a45,
			cf3778dacc37742f553c809b032a5f60b = 8u,
			c614cd2d8b5ca8d7c4746a9010172e860 = 16u,
			cc0a0e3d62d2b9e0481832cf9d1e73048 = 64u,
			ce61fc351dbc70067477abcb78fc3eb3c = 128u,
			c591559da1b4c52faec2ea5c7b66a98c0 = 256u,
			ccce57612d625c2bdb9c910499b773ea5 = 512u,
			c818c414fbf4aa572d185e9227b589a0e = 1024u,
			c2c1257d27aaa5327c8fee3385fb6f53d = 4096u,
			cf92520c385b8b8cdda9dbe9252d66276 = 1048576u
		}

		public static string c98bb4f4b15cf5ccc2e0e26f0967c64bd = "";

		public DateTime c4e933a4ee8cf3203607a1ebdcb8c36c3 = DateTime.Now;

		public static string c5767b64ebcb91c350a61c5aa04f02137 = "";

		public static string cbc8354a21a53ea1be029dfa414787b71 = "";

		public static int c0fc95c40fd6695e2aaa02d2c0655fc47 = 0;

		[DllImport("user32.dll", EntryPoint = "GetThreadDesktop")]
		private static extern IntPtr c2d9f17ca4d0e24b7fef811f3de7f9d98(int cd6b915b0feec07dccc875043071e70a2);

		[DllImport("kernel32.dll", EntryPoint = "QueryFullProcessImageName")]
		private static extern bool c0181969c65023c86def36ad163fb7c75(IntPtr cc789daceb986c94c3c2954a31641d190, int ce3c7b0e2f8ea2cbad2f42ba06daa5aa0, StringBuilder c32c7760078a3332dbeaa3acf2c146ce2, out int c03bb97a8654f0aafad1e9520af20dad3);

		[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
		private static extern IntPtr c76aa583c1f6c25bf6b2fdf3154b55cb1(cb846fc50c97d00ca6b6db07cdc5ac60b.c1c58ddb6e924f645c15a9b91c618f234 c3dd4c3c8bd605b268e2941c071b8b8fc, bool c60ed6b522af7b0b59b5176a1cd955a97, int ceb92aa65bebd3b037b8ac5aa291667c7);

		[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
		private static extern bool c79324b57232e4854f1044ac14506653f(IntPtr c7a54bb2f541d0cc4c54cda2b5500c57d);

		public static string cd52806b5b5190902f0e9420600ce669c(int cfeb9713f81c6320d0b122759c25cd493)
		{
			bool flag = Environment.OSVersion.Version.Major >= 6;
			string result;
			if (flag)
			{
				result = cb846fc50c97d00ca6b6db07cdc5ac60b.c2d1ae621f952faf76ea635eee0cf628f(cfeb9713f81c6320d0b122759c25cd493);
			}
			else
			{
				string queryString = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84698) + cfeb9713f81c6320d0b122759c25cd493;
				using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString))
				{
					using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
					{
						ManagementObject managementObject = managementObjectCollection.Cast<ManagementObject>().FirstOrDefault<ManagementObject>();
						bool flag2 = managementObject != null;
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
								RuntimeMethodHandle arg_89_0 = methodof(cb846fc50c97d00ca6b6db07cdc5ac60b.cd52806b5b5190902f0e9420600ce669c(int)).MethodHandle;
							}
							result = (string)managementObject[c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84840)];
							return result;
						}
					}
				}
				result = null;
			}
			return result;
		}

		private static string c7cf72e6696e495935b45d98fd25140ae(Process ced31a82fd2748f227153b7d0b0308f66)
		{
			bool flag = Environment.OSVersion.Version.Major >= 6;
			string result;
			if (flag)
			{
				result = cb846fc50c97d00ca6b6db07cdc5ac60b.c2d1ae621f952faf76ea635eee0cf628f(ced31a82fd2748f227153b7d0b0308f66.Id);
			}
			else
			{
				result = ced31a82fd2748f227153b7d0b0308f66.MainModule.FileName;
			}
			return result;
		}

		private static string c2d1ae621f952faf76ea635eee0cf628f(int c2d934d4a20bc4d72a38bdd3899056d21)
		{
			StringBuilder stringBuilder = new StringBuilder(1024);
			IntPtr intPtr = cb846fc50c97d00ca6b6db07cdc5ac60b.c76aa583c1f6c25bf6b2fdf3154b55cb1(cb846fc50c97d00ca6b6db07cdc5ac60b.c1c58ddb6e924f645c15a9b91c618f234.c2c1257d27aaa5327c8fee3385fb6f53d, false, c2d934d4a20bc4d72a38bdd3899056d21);
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
					RuntimeMethodHandle arg_3E_0 = methodof(cb846fc50c97d00ca6b6db07cdc5ac60b.c2d1ae621f952faf76ea635eee0cf628f(int)).MethodHandle;
				}
				try
				{
					int capacity = stringBuilder.Capacity;
					bool flag2 = cb846fc50c97d00ca6b6db07cdc5ac60b.c0181969c65023c86def36ad163fb7c75(intPtr, 0, stringBuilder, out capacity);
					if (flag2)
					{
						return stringBuilder.ToString();
					}
				}
				finally
				{
					cb846fc50c97d00ca6b6db07cdc5ac60b.c79324b57232e4854f1044ac14506653f(intPtr);
				}
			}
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}

		public static string c69ec5f0763deb58017a005acba9615d6(int cfeb9713f81c6320d0b122759c25cd493)
		{
			string queryString = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84869) + cfeb9713f81c6320d0b122759c25cd493;
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(queryString);
			ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
			ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator();
			string result;
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)enumerator.Current;
					string[] array = new string[]
					{
						string.Empty,
						string.Empty
					};
					int num = Convert.ToInt32(managementObject.InvokeMethod(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84962), array));
					bool flag = num == 0;
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
							RuntimeMethodHandle arg_9D_0 = methodof(cb846fc50c97d00ca6b6db07cdc5ac60b.c69ec5f0763deb58017a005acba9615d6(int)).MethodHandle;
						}
						result = array[1] + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84979) + array[0];
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
			finally
			{
				if (enumerator != null)
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
					((IDisposable)enumerator).Dispose();
				}
			}
			result = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84982);
			return result;
		}

		public static float cb0ba27ee0e374a3cf035b2bbb144d8d9(string cfc394f4f14fc71d829dd7386338a12ba)
		{
			FileInfo fileInfo = new FileInfo(cfc394f4f14fc71d829dd7386338a12ba);
			return (float)fileInfo.Length;
		}

		public static void ca0890e9c337dbf5ae0d40fbb9beebae0(DataTable c261914cc505bd9fa901460bee59eea52, DataTable c88338416e5240b6ab623e42978a7df32)
		{
			string text = "";
			string a = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c199b8958f035a5267b76668d393204af.c38472f73e6d2fadcdccf0566cd533d8b);
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			try
			{
				for (int i = 0; i < c261914cc505bd9fa901460bee59eea52.Rows.Count; i++)
				{
					text = string.Concat(new string[]
					{
						text,
						c261914cc505bd9fa901460bee59eea52.Rows[i][1].ToString().ToUpper(),
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999),
						c261914cc505bd9fa901460bee59eea52.Rows[i][2].ToString(),
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999)
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
					RuntimeMethodHandle arg_D7_0 = methodof(cb846fc50c97d00ca6b6db07cdc5ac60b.ca0890e9c337dbf5ae0d40fbb9beebae0(DataTable, DataTable)).MethodHandle;
				}
			}
			catch
			{
			}
			cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71 = Environment.UserDomainName + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84979) + Environment.UserName;
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
						string text4 = cb846fc50c97d00ca6b6db07cdc5ac60b.c69ec5f0763deb58017a005acba9615d6(process.Id);
						int num4 = 0;
						for (int k = 0; k < c88338416e5240b6ab623e42978a7df32.Rows.Count; k++)
						{
							bool arg_1B9_0;
							if (!(text4.ToUpper() == cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71.ToUpper()))
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
								arg_1B9_0 = (text4.ToUpper() == c88338416e5240b6ab623e42978a7df32.Rows[k].ItemArray[1].ToString().ToUpper());
							}
							else
							{
								arg_1B9_0 = true;
							}
							bool flag = arg_1B9_0;
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
								num4++;
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
						bool flag2 = num4 > 0;
						if (!flag2)
						{
							Environment.Exit(0);
							Application.Exit();
							IL_489:
							bool flag3 = num3 == 1;
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
								text2 = "";
								num3 = 0;
							}
							goto IL_4BB;
						}
						cb846fc50c97d00ca6b6db07cdc5ac60b.c0fc95c40fd6695e2aaa02d2c0655fc47 = 0;
						bool flag4 = cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71.ToUpper() == text4.ToUpper();
						if (flag4)
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
							try
							{
								bool flag5 = process.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85002);
								if (flag5)
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
									num++;
								}
								text2 = text2 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85011) + process.ProcessName.ToUpper() + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85014);
								IEnumerator enumerator = process.Threads.GetEnumerator();
								try
								{
									if (enumerator.MoveNext())
									{
										ProcessThread processThread = (ProcessThread)enumerator.Current;
										text3 = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(cb846fc50c97d00ca6b6db07cdc5ac60b.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id));
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
								float num5 = 0f;
								try
								{
									num5 = cb846fc50c97d00ca6b6db07cdc5ac60b.cb0ba27ee0e374a3cf035b2bbb144d8d9(cb846fc50c97d00ca6b6db07cdc5ac60b.cd52806b5b5190902f0e9420600ce669c(process.Id).ToString());
								}
								catch
								{
									num5 = 0f;
								}
								string text5 = "";
								text5 = process.ProcessName.ToUpper() + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999) + num5.ToString();
								text2 = string.Concat(new string[]
								{
									text2,
									text3,
									c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85014),
									text5,
									c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85017)
								});
								bool flag6 = a == text3;
								if (flag6)
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
									bool flag7 = !text.Contains(text5);
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
										text5 += c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85020);
										try
										{
											process.Kill();
											text2 = text2 + text5 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85031);
										}
										catch
										{
											text2 = text2 + text5 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85048);
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
					while (true)
					{
						switch (4)
						{
						case 0:
							continue;
						}
						goto IL_489;
					}
				}
				catch
				{
					text2 = "";
					num = 0;
				}
				IL_4BB:
				bool flag8 = num == 1;
				if (flag8)
				{
					goto Block_3;
				}
				num = 0;
				Process[] processes2 = Process.GetProcesses();
				Process[] array2 = processes2;
				for (int l = 0; l < array2.Length; l++)
				{
					Process process2 = array2[l];
					bool flag9 = process2.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85002);
					if (flag9)
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
						num++;
					}
					bool arg_57D_0;
					if (!(process2.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85071)))
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
						arg_57D_0 = (process2.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85092));
					}
					else
					{
						arg_57D_0 = true;
					}
					bool flag10 = arg_57D_0;
					if (flag10)
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
						num2++;
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
				bool arg_5C5_0;
				if (num != 1)
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
					arg_5C5_0 = (num2 == 0);
				}
				else
				{
					arg_5C5_0 = true;
				}
				bool flag11 = arg_5C5_0;
				if (flag11)
				{
					break;
				}
				Thread.Sleep(2000);
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
			cb846fc50c97d00ca6b6db07cdc5ac60b.c0fc95c40fd6695e2aaa02d2c0655fc47 = 1;
			Environment.Exit(0);
			Application.Exit();
			return;
			Block_3:
			cb846fc50c97d00ca6b6db07cdc5ac60b.c0fc95c40fd6695e2aaa02d2c0655fc47 = 1;
		}

		public static void c8553c1f3bf9721e5632f741f941cb784(DataTable c261914cc505bd9fa901460bee59eea52)
		{
			string text = "";
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			string a = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c199b8958f035a5267b76668d393204af.c38472f73e6d2fadcdccf0566cd533d8b);
			try
			{
				for (int i = 0; i < c261914cc505bd9fa901460bee59eea52.Rows.Count; i++)
				{
					text = string.Concat(new string[]
					{
						text,
						c261914cc505bd9fa901460bee59eea52.Rows[i][1].ToString().ToUpper(),
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999),
						c261914cc505bd9fa901460bee59eea52.Rows[i][2].ToString(),
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999)
					});
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
				if (!true)
				{
					RuntimeMethodHandle arg_CC_0 = methodof(cb846fc50c97d00ca6b6db07cdc5ac60b.c8553c1f3bf9721e5632f741f941cb784(DataTable)).MethodHandle;
				}
			}
			catch
			{
			}
			cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71 = Environment.UserDomainName + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84979) + Environment.UserName;
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
						string text4 = cb846fc50c97d00ca6b6db07cdc5ac60b.c69ec5f0763deb58017a005acba9615d6(process.Id);
						bool flag = cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71.ToUpper() == text4.ToUpper();
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
							try
							{
								bool flag2 = process.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85002);
								if (flag2)
								{
									num++;
								}
								text2 = text2 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85011) + process.ProcessName.ToUpper() + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85014);
								IEnumerator enumerator = process.Threads.GetEnumerator();
								try
								{
									if (!enumerator.MoveNext())
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
									}
									else
									{
										ProcessThread processThread = (ProcessThread)enumerator.Current;
										text3 = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(cb846fc50c97d00ca6b6db07cdc5ac60b.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id));
									}
								}
								finally
								{
									IDisposable disposable = enumerator as IDisposable;
									if (disposable != null)
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
										disposable.Dispose();
									}
								}
								float num4 = 0f;
								try
								{
									num4 = cb846fc50c97d00ca6b6db07cdc5ac60b.cb0ba27ee0e374a3cf035b2bbb144d8d9(cb846fc50c97d00ca6b6db07cdc5ac60b.cd52806b5b5190902f0e9420600ce669c(process.Id).ToString());
								}
								catch
								{
									num4 = 0f;
								}
								string text5 = "";
								text5 = process.ProcessName.ToUpper() + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999) + num4.ToString();
								text2 = string.Concat(new string[]
								{
									text2,
									text3,
									c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85014),
									text5,
									c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85017)
								});
								bool flag3 = a == text3;
								if (flag3)
								{
									bool flag4 = !text.Contains(text5);
									if (flag4)
									{
										text5 += c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85020);
										try
										{
											process.Kill();
											text2 = text2 + text5 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85031);
										}
										catch
										{
											text2 = text2 + text5 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85048);
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
							switch (4)
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
					bool flag7 = process2.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85002);
					if (flag7)
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
						num++;
					}
					bool arg_473_0;
					if (!(process2.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85071)))
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
						arg_473_0 = (process2.ProcessName.ToUpper() == c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85092));
					}
					else
					{
						arg_473_0 = true;
					}
					bool flag8 = arg_473_0;
					if (flag8)
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
						num2++;
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
				bool arg_4B8_0;
				if (num != 1)
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
					arg_4B8_0 = (num2 == 0);
				}
				else
				{
					arg_4B8_0 = true;
				}
				bool flag9 = arg_4B8_0;
				if (flag9)
				{
					goto IL_4BE;
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
			cb846fc50c97d00ca6b6db07cdc5ac60b.c0fc95c40fd6695e2aaa02d2c0655fc47 = 1;
			return;
			while (true)
			{
				IL_4BE:
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			cb846fc50c97d00ca6b6db07cdc5ac60b.c0fc95c40fd6695e2aaa02d2c0655fc47 = 1;
			Environment.Exit(0);
			Application.Exit();
		}

		public static void ca0890e9c337dbf5ae0d40fbb9beebae0(DataTable c261914cc505bd9fa901460bee59eea52, string c5cf0eb8f6c7d57525b363ef5042ce743)
		{
			string text = "";
			string str = "";
			int num = 0;
			try
			{
				for (int i = 0; i < c261914cc505bd9fa901460bee59eea52.Rows.Count; i++)
				{
					text = string.Concat(new string[]
					{
						text,
						c261914cc505bd9fa901460bee59eea52.Rows[i][1].ToString().ToUpper(),
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999),
						c261914cc505bd9fa901460bee59eea52.Rows[i][2].ToString(),
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999)
					});
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
					cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71 = Environment.UserDomainName + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84979) + Environment.UserName;
					string b = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c199b8958f035a5267b76668d393204af.c38472f73e6d2fadcdccf0566cd533d8b);
					Process[] processes = Process.GetProcesses();
					Process[] array = processes;
					for (int j = 0; j < array.Length; j++)
					{
						Process process = array[j];
						string text2 = cb846fc50c97d00ca6b6db07cdc5ac60b.c69ec5f0763deb58017a005acba9615d6(process.Id);
						bool flag = cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71.ToUpper() == text2.ToUpper();
						if (flag)
						{
							float num2 = 0f;
							try
							{
								num2 = cb846fc50c97d00ca6b6db07cdc5ac60b.cb0ba27ee0e374a3cf035b2bbb144d8d9(cb846fc50c97d00ca6b6db07cdc5ac60b.cd52806b5b5190902f0e9420600ce669c(process.Id).ToString());
							}
							catch
							{
								num2 = 0f;
							}
							string value = process.ProcessName.ToUpper() + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84999) + num2.ToString();
							IEnumerator enumerator = process.Threads.GetEnumerator();
							try
							{
								if (!enumerator.MoveNext())
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
								}
								else
								{
									ProcessThread processThread = (ProcessThread)enumerator.Current;
									bool flag2 = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(cb846fc50c97d00ca6b6db07cdc5ac60b.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) != b;
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
											RuntimeMethodHandle arg_20C_0 = methodof(cb846fc50c97d00ca6b6db07cdc5ac60b.ca0890e9c337dbf5ae0d40fbb9beebae0(DataTable, string)).MethodHandle;
										}
										bool flag3 = !text.Contains(value);
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
											str = str + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85117) + process.ProcessName;
											num = 1;
										}
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
										switch (1)
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

		public static void ceda1957c8dda1a0777d5debb44a3b166(DataTable c261914cc505bd9fa901460bee59eea52)
		{
			cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71 = Environment.UserDomainName + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84979) + Environment.UserName;
			string text = "";
			string b = "";
			try
			{
				Process[] processes = Process.GetProcesses();
				string text2 = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(c98d268433aff2e8318ffa81b2310b67e.c199b8958f035a5267b76668d393204af.c38472f73e6d2fadcdccf0566cd533d8b);
				text = text2;
				b = text2;
				Process[] array = processes;
				for (int i = 0; i < array.Length; i++)
				{
					Process process = array[i];
					string b2 = cb846fc50c97d00ca6b6db07cdc5ac60b.c69ec5f0763deb58017a005acba9615d6(process.Id);
					bool flag = cb846fc50c97d00ca6b6db07cdc5ac60b.cbc8354a21a53ea1be029dfa414787b71 == b2;
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
							RuntimeMethodHandle arg_9F_0 = methodof(cb846fc50c97d00ca6b6db07cdc5ac60b.ceda1957c8dda1a0777d5debb44a3b166(DataTable)).MethodHandle;
						}
						IEnumerator enumerator = process.Threads.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								ProcessThread processThread = (ProcessThread)enumerator.Current;
								bool flag2 = c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(cb846fc50c97d00ca6b6db07cdc5ac60b.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) == text2;
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
									for (int j = 0; j <= c261914cc505bd9fa901460bee59eea52.Rows.Count - 1; j++)
									{
										bool flag3 = process.ProcessName.ToUpper() == c261914cc505bd9fa901460bee59eea52.Rows[j].ItemArray[1].ToString().ToUpper() && c98d268433aff2e8318ffa81b2310b67e.c5d6ec0f01c15237862b9e73082547873(cb846fc50c97d00ca6b6db07cdc5ac60b.c2d9f17ca4d0e24b7fef811f3de7f9d98(processThread.Id)) == text2;
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
											text = text + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(85120) + process.ProcessName;
											process.Kill();
											goto IL_1C7;
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
								}
								IL_1C7:;
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
					}
				}
				bool flag4 = text != b;
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
						switch (2)
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
