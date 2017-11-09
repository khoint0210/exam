using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace A
{
	internal class c3d541cd7d0eac8bc2fac8fd0dd77ca7b
	{
		private static readonly object c6091b4c67794dddc4420dcbef81ef5aa;

		private static readonly int c4a881086f0d88d8fc202731e4c1f7d6d;

		private static readonly int c3abb7f9448a1f91751a79cdd27e7d9cc;

		private static readonly MemoryStream c9c48f4b814cc59f9849a98078070a7f1;

		private static readonly MemoryStream cedc4b3fd004c2f57e450f5fb123e855a;

		private static readonly byte cf402a92eb80fb09be5b07c24c78ef63a;

		static c3d541cd7d0eac8bc2fac8fd0dd77ca7b()
		{
			c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1 = null;
			c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a = null;
			c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c4a881086f0d88d8fc202731e4c1f7d6d = 2147483647;
			c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c3abb7f9448a1f91751a79cdd27e7d9cc = -2147483648;
			c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1 = new MemoryStream(0);
			c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a = new MemoryStream(0);
			c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c6091b4c67794dddc4420dcbef81ef5aa = new object();
		}

		private static string c7d33a03c54d0e614f91abc0bea71a035(Assembly cd4422e60b123f1ce4485cca975d0ab85)
		{
			string text = cd4422e60b123f1ce4485cca975d0ab85.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}

		private static byte[] c1409083e445f12b209f3df06b5df4f90(Assembly cd4422e60b123f1ce4485cca975d0ab85)
		{
			try
			{
				string fullName = cd4422e60b123f1ce4485cca975d0ab85.FullName;
				int num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
				{
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
						RuntimeMethodHandle arg_56_0 = methodof(c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c1409083e445f12b209f3df06b5df4f90(Assembly)).MethodHandle;
					}
					if (fullName[num] != 'N')
					{
						string s = fullName.Substring(num, 16);
						long value = long.Parse(s, NumberStyles.HexNumber);
						byte[] bytes = BitConverter.GetBytes(value);
						Array.Reverse(bytes);
						result = bytes;
						return result;
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

		internal static byte[] ce85f33c4d68f414079b468ed506fc45d(Stream c650b79a26ac7b2a6487536cab21bbbc6)
		{
			byte[] result;
			lock (c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c6091b4c67794dddc4420dcbef81ef5aa)
			{
				result = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.ca7d31fe9ad3b62e4a70e470ea0ce2067(97L, c650b79a26ac7b2a6487536cab21bbbc6);
			}
			return result;
		}

		internal static byte[] c139dca28cf08130cfae4973389dc9b02(long cf402a92eb80fb09be5b07c24c78ef63a, Stream c650b79a26ac7b2a6487536cab21bbbc6)
		{
			byte[] result;
			try
			{
				result = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.ce85f33c4d68f414079b468ed506fc45d(c650b79a26ac7b2a6487536cab21bbbc6);
			}
			catch (HostProtectionException)
			{
				result = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.ca7d31fe9ad3b62e4a70e470ea0ce2067(97L, c650b79a26ac7b2a6487536cab21bbbc6);
			}
			return result;
		}

		internal static byte[] ca7d31fe9ad3b62e4a70e470ea0ce2067(long cf402a92eb80fb09be5b07c24c78ef63a, Stream c650b79a26ac7b2a6487536cab21bbbc6)
		{
			Stream stream = c650b79a26ac7b2a6487536cab21bbbc6;
			MemoryStream memoryStream = null;
			for (int i = 1; i < 4; i++)
			{
				c650b79a26ac7b2a6487536cab21bbbc6.ReadByte();
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
				RuntimeMethodHandle arg_2B_0 = methodof(c3d541cd7d0eac8bc2fac8fd0dd77ca7b.ca7d31fe9ad3b62e4a70e470ea0ce2067(long, Stream)).MethodHandle;
			}
			ushort num = (ushort)c650b79a26ac7b2a6487536cab21bbbc6.ReadByte();
			num = ~num;
			if ((num & 2) != 0)
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
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = new byte[8];
				c650b79a26ac7b2a6487536cab21bbbc6.Read(array, 0, 8);
				dESCryptoServiceProvider.IV = array;
				byte[] array2 = new byte[8];
				c650b79a26ac7b2a6487536cab21bbbc6.Read(array2, 0, 8);
				bool flag = true;
				byte[] array3 = array2;
				for (int j = 0; j < array3.Length; j++)
				{
					byte b = array3[j];
					if (b != 0)
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
						flag = false;
						IL_C2:
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
							array2 = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c1409083e445f12b209f3df06b5df4f90(Assembly.GetExecutingAssembly());
						}
						dESCryptoServiceProvider.Key = array2;
						if (c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1 == null)
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
							if (c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c4a881086f0d88d8fc202731e4c1f7d6d == 2147483647)
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
								c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1.Capacity = (int)c650b79a26ac7b2a6487536cab21bbbc6.Length;
							}
							else
							{
								c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1.Capacity = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c4a881086f0d88d8fc202731e4c1f7d6d;
							}
						}
						c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1.Position = 0L;
						ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
						int inputBlockSize = cryptoTransform.InputBlockSize;
						int expr_159 = cryptoTransform.OutputBlockSize;
						byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
						byte[] array5 = new byte[cryptoTransform.InputBlockSize];
						int num2 = (int)c650b79a26ac7b2a6487536cab21bbbc6.Position;
						while ((long)(num2 + inputBlockSize) < c650b79a26ac7b2a6487536cab21bbbc6.Length)
						{
							c650b79a26ac7b2a6487536cab21bbbc6.Read(array5, 0, inputBlockSize);
							int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
							c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1.Write(array4, 0, count);
							num2 += inputBlockSize;
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
						c650b79a26ac7b2a6487536cab21bbbc6.Read(array5, 0, (int)(c650b79a26ac7b2a6487536cab21bbbc6.Length - (long)num2));
						byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(c650b79a26ac7b2a6487536cab21bbbc6.Length - (long)num2));
						c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1.Write(array6, 0, array6.Length);
						stream = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1;
						stream.Position = 0L;
						memoryStream = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c9c48f4b814cc59f9849a98078070a7f1;
						goto IL_22F;
					}
				}
				while (true)
				{
					switch (7)
					{
					case 0:
						continue;
					}
					goto IL_C2;
				}
			}
			IL_22F:
			if ((num & 8) != 0)
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
				if (c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a == null)
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
					if (c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c3abb7f9448a1f91751a79cdd27e7d9cc == -2147483648)
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
						c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a.Capacity = (int)stream.Length * 2;
					}
					else
					{
						c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a.Capacity = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c3abb7f9448a1f91751a79cdd27e7d9cc;
					}
				}
				c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a.Position = 0L;
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
							switch (4)
							{
							case 0:
								continue;
							}
							break;
						}
						c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a.Write(buffer, 0, num4);
					}
				}
				while (num4 >= num3);
				memoryStream = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.cedc4b3fd004c2f57e450f5fb123e855a;
			}
			if (memoryStream != null)
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
				return memoryStream.ToArray();
			}
			byte[] array7 = new byte[c650b79a26ac7b2a6487536cab21bbbc6.Length - c650b79a26ac7b2a6487536cab21bbbc6.Position];
			c650b79a26ac7b2a6487536cab21bbbc6.Read(array7, 0, array7.Length);
			return array7;
		}
	}
}
