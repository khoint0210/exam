using System;
using System.IO;
using System.Reflection;

namespace A
{
	internal class c4806b2feaa3dce24a6053446dbbcc111
	{
		private static readonly Assembly c86762b0721a7c00821afd4c4b7b5931d;

		static c4806b2feaa3dce24a6053446dbbcc111()
		{
			AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(c4806b2feaa3dce24a6053446dbbcc111.cd0aa51cc323d30384957b1d87810d97c);
			AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(c4806b2feaa3dce24a6053446dbbcc111.c8417f5befcdfe87f4605db82fe0023ba);
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string assemblyString = c4806b2feaa3dce24a6053446dbbcc111.c7d33a03c54d0e614f91abc0bea71a035(executingAssembly);
			c4806b2feaa3dce24a6053446dbbcc111.c86762b0721a7c00821afd4c4b7b5931d = Assembly.Load(assemblyString);
		}

		internal static void c757dddc778ad2fdb0fc5fab8636a1fd6()
		{
		}

		private static Assembly c8417f5befcdfe87f4605db82fe0023ba(object ca0b9b3b55269fcc18cd68ac52e023280, ResolveEventArgs c5c755be06bd236cd4f9054b91eded382)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			string text = c4806b2feaa3dce24a6053446dbbcc111.c7d33a03c54d0e614f91abc0bea71a035(executingAssembly);
			if (c5c755be06bd236cd4f9054b91eded382.Name.StartsWith(text))
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
					RuntimeMethodHandle arg_33_0 = methodof(c4806b2feaa3dce24a6053446dbbcc111.c8417f5befcdfe87f4605db82fe0023ba(object, ResolveEventArgs)).MethodHandle;
				}
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
				byte[] rawAssembly = c3d541cd7d0eac8bc2fac8fd0dd77ca7b.c139dca28cf08130cfae4973389dc9b02(97L, manifestResourceStream);
				return Assembly.Load(rawAssembly);
			}
			return null;
		}

		private static string c7d33a03c54d0e614f91abc0bea71a035(Assembly cd4422e60b123f1ce4485cca975d0ab85)
		{
			string text = cd4422e60b123f1ce4485cca975d0ab85.FullName;
			int num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text + '&';
		}

		private static Assembly cd0aa51cc323d30384957b1d87810d97c(object ca0b9b3b55269fcc18cd68ac52e023280, ResolveEventArgs c5c755be06bd236cd4f9054b91eded382)
		{
			if (c4806b2feaa3dce24a6053446dbbcc111.c86762b0721a7c00821afd4c4b7b5931d != null)
			{
				string[] manifestResourceNames = c4806b2feaa3dce24a6053446dbbcc111.c86762b0721a7c00821afd4c4b7b5931d.GetManifestResourceNames();
				for (int i = 0; i < manifestResourceNames.Length; i++)
				{
					string a = manifestResourceNames[i];
					if (a == c5c755be06bd236cd4f9054b91eded382.Name)
					{
						return c4806b2feaa3dce24a6053446dbbcc111.c86762b0721a7c00821afd4c4b7b5931d;
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
				if (!true)
				{
					RuntimeMethodHandle arg_50_0 = methodof(c4806b2feaa3dce24a6053446dbbcc111.cd0aa51cc323d30384957b1d87810d97c(object, ResolveEventArgs)).MethodHandle;
				}
				return null;
			}
			return c4806b2feaa3dce24a6053446dbbcc111.c86762b0721a7c00821afd4c4b7b5931d;
		}
	}
}
