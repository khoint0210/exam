using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A
{
	internal class c0d07d609d29335644b7dbbe53fb10114
	{
		internal static readonly byte[] cd362b6db719e4cbaceec1af1b59ec82a;

		static c0d07d609d29335644b7dbbe53fb10114()
		{
			if (c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a == null)
			{
				string text = "RUYk";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a = ccae1751bc1f5ff43078e69a2fe925819.c517d1311ca97ca80255ba79804a68c19(97L, manifestResourceStream);
			}
		}

		internal static string c631fb4bb3e507f4f0e6349aa5de37200(int c22939aad06404e7424f1168b0b0ceb63)
		{
			int num;
			if ((c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63] & 128) == 0)
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
					RuntimeMethodHandle arg_23_0 = methodof(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(int)).MethodHandle;
				}
				num = (int)c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63];
				c22939aad06404e7424f1168b0b0ceb63++;
			}
			else if ((c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63] & 64) == 0)
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
				num = ((int)c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63] & -129) << 8;
				num |= (int)c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63 + 1];
				c22939aad06404e7424f1168b0b0ceb63 += 2;
			}
			else
			{
				num = ((int)c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63] & -193) << 24;
				num |= (int)c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63 + 1] << 16;
				num |= (int)c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63 + 2] << 8;
				num |= (int)c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a[c22939aad06404e7424f1168b0b0ceb63 + 3];
				c22939aad06404e7424f1168b0b0ceb63 += 4;
			}
			if (num < 1)
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
				return string.Empty;
			}
			string @string = Encoding.Unicode.GetString(c0d07d609d29335644b7dbbe53fb10114.cd362b6db719e4cbaceec1af1b59ec82a, c22939aad06404e7424f1168b0b0ceb63, num);
			return string.Intern(@string);
		}
	}
}
