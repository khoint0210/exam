using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace A
{
	internal class ccae1751bc1f5ff43078e69a2fe925819
	{
		private static readonly object c5fdba3bec04104f452f2c6caf5b16a25;

		private static readonly int c5c37a15976cbff91654c5df0a434ee19;

		private static readonly int c83931d27f3b3b198c5cc7739b3a6ee71;

		private static readonly MemoryStream c580dc681d8ed14f7ade3b5501084b87b;

		private static readonly MemoryStream ce4fde4fc58840cfc82a5db84b775187c;

		private static readonly byte c9c143eb64a4860655c37075e8380d244;

		static ccae1751bc1f5ff43078e69a2fe925819()
		{
			ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b = null;
			ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c = null;
			ccae1751bc1f5ff43078e69a2fe925819.c5c37a15976cbff91654c5df0a434ee19 = 2147483647;
			ccae1751bc1f5ff43078e69a2fe925819.c83931d27f3b3b198c5cc7739b3a6ee71 = -2147483648;
			ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b = new MemoryStream(0);
			ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c = new MemoryStream(0);
			ccae1751bc1f5ff43078e69a2fe925819.c5fdba3bec04104f452f2c6caf5b16a25 = new object();
		}

		private static string c24bb4fbc3f7c9f7101b5789585eadc09(Assembly c549b8023bd9d008c7ce4087f241c89d5)
		{
			string text = c549b8023bd9d008c7ce4087f241c89d5.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
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
					RuntimeMethodHandle arg_2A_0 = methodof(ccae1751bc1f5ff43078e69a2fe925819.c24bb4fbc3f7c9f7101b5789585eadc09(Assembly)).MethodHandle;
				}
				text = text.Substring(0, num);
			}
			return text;
		}

		private static byte[] c24f5c602bbb6cd36bc3370ceffdf69e4(Assembly c549b8023bd9d008c7ce4087f241c89d5)
		{
			try
			{
				string fullName = c549b8023bd9d008c7ce4087f241c89d5.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
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
						RuntimeMethodHandle arg_2D_0 = methodof(ccae1751bc1f5ff43078e69a2fe925819.c24f5c602bbb6cd36bc3370ceffdf69e4(Assembly)).MethodHandle;
					}
					num = fullName.IndexOf("publickeytoken=");
				}
				byte[] result;
				if (num < 0)
				{
					result = null;
					return result;
				}
				num += 15;
				if (fullName[num] != 'n')
				{
					if (fullName[num] != 'N')
					{
						string s = fullName.Substring(num, 16);
						long value = long.Parse(s, NumberStyles.HexNumber);
						byte[] bytes = BitConverter.GetBytes(value);
						Array.Reverse(bytes);
						result = bytes;
						return result;
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
				result = null;
				return result;
			}
			catch
			{
			}
			return null;
		}

		internal static byte[] c6b283909a43963b51f45267639f8e5b2(Stream c7cc933fddafa3c1b511705f8aecacc4f)
		{
			byte[] result;
			lock (ccae1751bc1f5ff43078e69a2fe925819.c5fdba3bec04104f452f2c6caf5b16a25)
			{
				result = ccae1751bc1f5ff43078e69a2fe925819.c09cdac04288e99a30dfee12e35618af6(97L, c7cc933fddafa3c1b511705f8aecacc4f);
			}
			return result;
		}

		internal static byte[] c517d1311ca97ca80255ba79804a68c19(long c9c143eb64a4860655c37075e8380d244, Stream c7cc933fddafa3c1b511705f8aecacc4f)
		{
			byte[] result;
			try
			{
				result = ccae1751bc1f5ff43078e69a2fe925819.c6b283909a43963b51f45267639f8e5b2(c7cc933fddafa3c1b511705f8aecacc4f);
			}
			catch (HostProtectionException)
			{
				result = ccae1751bc1f5ff43078e69a2fe925819.c09cdac04288e99a30dfee12e35618af6(97L, c7cc933fddafa3c1b511705f8aecacc4f);
			}
			return result;
		}

		internal static byte[] c09cdac04288e99a30dfee12e35618af6(long c9c143eb64a4860655c37075e8380d244, Stream c7cc933fddafa3c1b511705f8aecacc4f)
		{
			Stream stream = c7cc933fddafa3c1b511705f8aecacc4f;
			MemoryStream memoryStream = null;
			for (int i = 1; i < 4; i++)
			{
				c7cc933fddafa3c1b511705f8aecacc4f.ReadByte();
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
				RuntimeMethodHandle arg_29_0 = methodof(ccae1751bc1f5ff43078e69a2fe925819.c09cdac04288e99a30dfee12e35618af6(long, Stream)).MethodHandle;
			}
			ushort num = (ushort)c7cc933fddafa3c1b511705f8aecacc4f.ReadByte();
			num = ~num;
			if ((num & 2) != 0)
			{
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = new byte[8];
				c7cc933fddafa3c1b511705f8aecacc4f.Read(array, 0, 8);
				dESCryptoServiceProvider.IV = array;
				byte[] array2 = new byte[8];
				c7cc933fddafa3c1b511705f8aecacc4f.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					byte b = array3[j];
					if (b != 0)
					{
						flag = false;
						IL_AC:
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
							array2 = ccae1751bc1f5ff43078e69a2fe925819.c24f5c602bbb6cd36bc3370ceffdf69e4(Assembly.GetExecutingAssembly());
						}
						dESCryptoServiceProvider.Key = array2;
						if (ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b == null)
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
							if (ccae1751bc1f5ff43078e69a2fe925819.c5c37a15976cbff91654c5df0a434ee19 == 2147483647)
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
								ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b.Capacity = (int)c7cc933fddafa3c1b511705f8aecacc4f.Length;
							}
							else
							{
								ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b.Capacity = ccae1751bc1f5ff43078e69a2fe925819.c5c37a15976cbff91654c5df0a434ee19;
							}
						}
						ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b.Position = 0L;
						ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
						int inputBlockSize = cryptoTransform.InputBlockSize;
						int expr_145 = cryptoTransform.OutputBlockSize;
						byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
						byte[] array5 = new byte[cryptoTransform.InputBlockSize];
						int num2 = (int)c7cc933fddafa3c1b511705f8aecacc4f.Position;
						while ((long)(num2 + inputBlockSize) < c7cc933fddafa3c1b511705f8aecacc4f.Length)
						{
							c7cc933fddafa3c1b511705f8aecacc4f.Read(array5, 0, inputBlockSize);
							int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
							ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b.Write(array4, 0, count);
							num2 += inputBlockSize;
						}
						c7cc933fddafa3c1b511705f8aecacc4f.Read(array5, 0, (int)(c7cc933fddafa3c1b511705f8aecacc4f.Length - (long)num2));
						byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(c7cc933fddafa3c1b511705f8aecacc4f.Length - (long)num2));
						ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b.Write(array6, 0, array6.Length);
						stream = ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b;
						stream.Position = 0L;
						memoryStream = ccae1751bc1f5ff43078e69a2fe925819.c580dc681d8ed14f7ade3b5501084b87b;
						goto IL_213;
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					goto IL_AC;
				}
			}
			IL_213:
			if ((num & 8) != 0)
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
				if (ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c == null)
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
					if (ccae1751bc1f5ff43078e69a2fe925819.c83931d27f3b3b198c5cc7739b3a6ee71 == -2147483648)
					{
						ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c.Capacity = (int)stream.Length * 2;
					}
					else
					{
						ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c.Capacity = ccae1751bc1f5ff43078e69a2fe925819.c83931d27f3b3b198c5cc7739b3a6ee71;
					}
				}
				ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num3 = 1000;
				byte[] buffer = new byte[num3];
				int num4;
				do
				{
					num4 = deflateStream.Read(buffer, 0, num3);
					if (num4 > 0)
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
						ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c.Write(buffer, 0, num4);
					}
				}
				while (num4 >= num3);
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				memoryStream = ccae1751bc1f5ff43078e69a2fe925819.ce4fde4fc58840cfc82a5db84b775187c;
			}
			if (memoryStream != null)
			{
				return memoryStream.ToArray();
			}
			byte[] array7 = new byte[c7cc933fddafa3c1b511705f8aecacc4f.Length - c7cc933fddafa3c1b511705f8aecacc4f.Position];
			c7cc933fddafa3c1b511705f8aecacc4f.Read(array7, 0, array7.Length);
			return array7;
		}
	}
}
