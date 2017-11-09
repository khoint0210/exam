using System;
using System.IO;
using System.Reflection;

namespace A
{
	internal class cf3f23711f688987d8a5bf354dcefae1f
	{
		private static readonly Assembly c25fcd004f25bfa6383c1196bbc273b68;

		static cf3f23711f688987d8a5bf354dcefae1f()
		{
			AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(cf3f23711f688987d8a5bf354dcefae1f.c47d32e6b07c73c8601b4925738650fab);
			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(cf3f23711f688987d8a5bf354dcefae1f.cc5dd62eaa81fafcd72717ced13a17c19);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string assemblyString = cf3f23711f688987d8a5bf354dcefae1f.c24bb4fbc3f7c9f7101b5789585eadc09(executingAssembly);
			cf3f23711f688987d8a5bf354dcefae1f.c25fcd004f25bfa6383c1196bbc273b68 = Assembly.Load(assemblyString);
		}

		internal static void c3cb6542b3d61448c202c98a84cfe0b38()
		{
		}

		private static Assembly cc5dd62eaa81fafcd72717ced13a17c19(object c3ed4d20323484c3c606ba7d732ac2604, ResolveEventArgs c13546ab4454ce53e0d6e592b742b0d9d)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string text = cf3f23711f688987d8a5bf354dcefae1f.c24bb4fbc3f7c9f7101b5789585eadc09(executingAssembly);
			if (c13546ab4454ce53e0d6e592b742b0d9d.Name.StartsWith(text))
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
					RuntimeMethodHandle arg_33_0 = methodof(cf3f23711f688987d8a5bf354dcefae1f.cc5dd62eaa81fafcd72717ced13a17c19(object, ResolveEventArgs)).MethodHandle;
				}
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
				byte[] rawAssembly = ccae1751bc1f5ff43078e69a2fe925819.c517d1311ca97ca80255ba79804a68c19(97L, manifestResourceStream);
				return Assembly.Load(rawAssembly);
			}
			return null;
		}

		private static string c24bb4fbc3f7c9f7101b5789585eadc09(Assembly c549b8023bd9d008c7ce4087f241c89d5)
		{
			string text = c549b8023bd9d008c7ce4087f241c89d5.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text + '&';
		}

		private static Assembly c47d32e6b07c73c8601b4925738650fab(object c3ed4d20323484c3c606ba7d732ac2604, ResolveEventArgs c13546ab4454ce53e0d6e592b742b0d9d)
		{
			if (cf3f23711f688987d8a5bf354dcefae1f.c25fcd004f25bfa6383c1196bbc273b68 != null)
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
					RuntimeMethodHandle arg_19_0 = methodof(cf3f23711f688987d8a5bf354dcefae1f.c47d32e6b07c73c8601b4925738650fab(object, ResolveEventArgs)).MethodHandle;
				}
				string[] manifestResourceNames = cf3f23711f688987d8a5bf354dcefae1f.c25fcd004f25bfa6383c1196bbc273b68.GetManifestResourceNames();
				for (int i = 0; i < manifestResourceNames.Length; i++)
				{
					string a = manifestResourceNames[i];
					if (a == c13546ab4454ce53e0d6e592b742b0d9d.Name)
					{
						return cf3f23711f688987d8a5bf354dcefae1f.c25fcd004f25bfa6383c1196bbc273b68;
					}
				}
				return null;
			}
			return cf3f23711f688987d8a5bf354dcefae1f.c25fcd004f25bfa6383c1196bbc273b68;
		}
	}
}
