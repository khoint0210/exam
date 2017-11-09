using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A
{
	internal class cbd0372a653c260ff2f0d06b7395c23ee
	{
		internal static readonly byte[] ce0a1a5e0f0c5f00e97abd7ba65bca208;

		static cbd0372a653c260ff2f0d06b7395c23ee()
		{
			if (cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208 == null)
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
					RuntimeMethodHandle arg_19_0 = methodof(cbd0372a653c260ff2f0d06b7395c23ee..cctor()).MethodHandle;
				}
				string text = "RUYk";
				byte[] array = Convert.FromBase64String(text);
				text = Encoding.UTF8.GetString(array, 0, array.Length);
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
				cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208 = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c139dca28cf08130cfae4973389dc9b02(97L, manifestResourceStream);
			}
		}

		internal static string c65d45d1d6ce072b35a4de0618d52e24b(int c497296735c228cb7927f1e4f483b2475)
		{
			int num;
			if ((cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475] & 128) == 0)
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
					RuntimeMethodHandle arg_23_0 = methodof(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(int)).MethodHandle;
				}
				num = (int)cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475];
				c497296735c228cb7927f1e4f483b2475++;
			}
			else if ((cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475] & 64) == 0)
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
				num = ((int)cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475] & -129) << 8;
				num |= (int)cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475 + 1];
				c497296735c228cb7927f1e4f483b2475 += 2;
			}
			else
			{
				num = ((int)cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475] & -193) << 24;
				num |= (int)cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475 + 1] << 16;
				num |= (int)cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475 + 2] << 8;
				num |= (int)cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208[c497296735c228cb7927f1e4f483b2475 + 3];
				c497296735c228cb7927f1e4f483b2475 += 4;
			}
			if (num < 1)
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
				return string.Empty;
			}
			string @string = Encoding.Unicode.GetString(cbd0372a653c260ff2f0d06b7395c23ee.ce0a1a5e0f0c5f00e97abd7ba65bca208, c497296735c228cb7927f1e4f483b2475, num);
			return string.Intern(@string);
		}
	}
}
