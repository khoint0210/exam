using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace A
{
	internal class cb501ad6cdbf534367e1bef279bffbd03
	{
		private static string c7f7d02723f1b4650bef3e788bc2603eb = "";

		public static string cabdfd1e33fbba783ed9eb05bdfd5d7da = "";

		public static string c4762dfb5c922a0dddd9ca2fe7d19c36a = Process.GetCurrentProcess().ProcessName;

		public static SqlConnection c185ceb8bf1be15267252758a85a56823;

		public static string c4407b37349197a8e380ac11f97f2a0ad = "";

		public static int c62234ffe5faa265a93563d922831603e = 0;

		public static void c19ebdb6b466ad8419a2eae2757a56e0d(string c2d281062a86ffddaebe5925f217b5f66, string c25b61e852b79f690ea2e39a57f759d65, string cbd5fd0a1c35d2c76e3fef329b7cf8b2d = "", string c16379f55feaf45dc49f35a7676653e72 = "")
		{
			cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = "";
			try
			{
				bool arg_3C_0;
				if (!(cbd5fd0a1c35d2c76e3fef329b7cf8b2d == ""))
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
						RuntimeMethodHandle arg_2D_0 = methodof(cb501ad6cdbf534367e1bef279bffbd03.c19ebdb6b466ad8419a2eae2757a56e0d(string, string, string, string)).MethodHandle;
					}
					arg_3C_0 = (c16379f55feaf45dc49f35a7676653e72 == "");
				}
				else
				{
					arg_3C_0 = true;
				}
				bool flag = arg_3C_0;
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
					cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb = cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83542) + c25b61e852b79f690ea2e39a57f759d65 + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83682) + c2d281062a86ffddaebe5925f217b5f66;
				}
				else
				{
					cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb = string.Concat(new string[]
					{
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83709),
						c16379f55feaf45dc49f35a7676653e72,
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83728),
						cbd5fd0a1c35d2c76e3fef329b7cf8b2d,
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83853),
						c25b61e852b79f690ea2e39a57f759d65,
						cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83682),
						c2d281062a86ffddaebe5925f217b5f66
					});
				}
				SqlConnection sqlConnection = new SqlConnection(cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb);
				bool flag2 = sqlConnection.State == ConnectionState.Closed;
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
					sqlConnection.Open();
					cb501ad6cdbf534367e1bef279bffbd03.c62234ffe5faa265a93563d922831603e = 1;
				}
				sqlConnection.Close();
				SqlConnection.ClearPool(sqlConnection);
			}
			catch
			{
				cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da += new StackFrame(0, true).GetFileLineNumber().ToString();
			}
		}

		public static DataTable cf012a438afaffd8f0b22cb659b2dbda3(string c74d82d7bdeee1f306e3ec932fa8c5425, params object[] c7af67b5c6377106ec7a4c1ba5092b6d4)
		{
			cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = "";
			DataTable dataTable = null;
			DataTable result;
			try
			{
				bool flag = cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb == "";
				if (flag)
				{
					cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
					throw new Exception(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83909));
				}
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(c74d82d7bdeee1f306e3ec932fa8c5425, cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb);
				bool flag2 = sqlDataAdapter.SelectCommand.Connection.State == ConnectionState.Closed;
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
						RuntimeMethodHandle arg_A0_0 = methodof(cb501ad6cdbf534367e1bef279bffbd03.cf012a438afaffd8f0b22cb659b2dbda3(string, object[])).MethodHandle;
					}
					sqlDataAdapter.SelectCommand.Connection.Open();
				}
				sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(sqlDataAdapter.SelectCommand);
				bool flag3 = sqlDataAdapter.SelectCommand.Parameters.Count - 1 != c7af67b5c6377106ec7a4c1ba5092b6d4.Length;
				if (flag3)
				{
					cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
					throw new Exception(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83966));
				}
				int num = 0;
				try
				{
					IEnumerator enumerator = sqlDataAdapter.SelectCommand.Parameters.GetEnumerator();
					while (enumerator.MoveNext())
					{
						SqlParameter sqlParameter = (SqlParameter)enumerator.Current;
						bool flag4 = sqlParameter.Direction == ParameterDirection.Input || sqlParameter.Direction == ParameterDirection.InputOutput;
						if (flag4)
						{
							sqlParameter.Value = RuntimeHelpers.GetObjectValue(c7af67b5c6377106ec7a4c1ba5092b6d4[num]);
							num++;
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
				catch
				{
					cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
				}
				try
				{
					DataTable dataTable2 = new DataTable();
					sqlDataAdapter.Fill(dataTable2);
					sqlDataAdapter.SelectCommand.Connection.Close();
					SqlConnection.ClearPool(sqlDataAdapter.SelectCommand.Connection);
					sqlDataAdapter.Dispose();
					dataTable = dataTable2;
				}
				catch
				{
					cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
				}
				result = dataTable;
			}
			catch
			{
				result = dataTable;
			}
			return result;
		}

		public static void c635cfa8a0b02d27098a447e0d990a0e9(DataSet c4bf111c549bde02681f4c597a409f1b3, string c74d82d7bdeee1f306e3ec932fa8c5425, params object[] c7af67b5c6377106ec7a4c1ba5092b6d4)
		{
			cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = "";
			bool flag = cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb == "";
			if (flag)
			{
				cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
				throw new Exception(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83909));
			}
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(c74d82d7bdeee1f306e3ec932fa8c5425, cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb);
			bool flag2 = sqlDataAdapter.SelectCommand.Connection.State == ConnectionState.Closed;
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
				if (!true)
				{
					RuntimeMethodHandle arg_9B_0 = methodof(cb501ad6cdbf534367e1bef279bffbd03.c635cfa8a0b02d27098a447e0d990a0e9(DataSet, string, object[])).MethodHandle;
				}
				sqlDataAdapter.SelectCommand.Connection.Open();
			}
			sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			SqlCommandBuilder.DeriveParameters(sqlDataAdapter.SelectCommand);
			bool flag3 = sqlDataAdapter.SelectCommand.Parameters.Count - 1 != c7af67b5c6377106ec7a4c1ba5092b6d4.Length;
			if (flag3)
			{
				cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
				throw new Exception(cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83966));
			}
			int num = 0;
			try
			{
				IEnumerator enumerator = sqlDataAdapter.SelectCommand.Parameters.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SqlParameter sqlParameter = (SqlParameter)enumerator.Current;
					bool arg_186_0;
					if (sqlParameter.Direction != ParameterDirection.Input)
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
						arg_186_0 = (sqlParameter.Direction == ParameterDirection.InputOutput);
					}
					else
					{
						arg_186_0 = true;
					}
					bool flag4 = arg_186_0;
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
						sqlParameter.Value = RuntimeHelpers.GetObjectValue(c7af67b5c6377106ec7a4c1ba5092b6d4[num]);
						num++;
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
			catch
			{
				cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
			}
			try
			{
				sqlDataAdapter.Fill(c4bf111c549bde02681f4c597a409f1b3, c74d82d7bdeee1f306e3ec932fa8c5425);
				sqlDataAdapter.SelectCommand.Connection.Close();
				SqlConnection.ClearPool(sqlDataAdapter.SelectCommand.Connection);
				sqlDataAdapter.Dispose();
			}
			catch
			{
				cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da = cb501ad6cdbf534367e1bef279bffbd03.cabdfd1e33fbba783ed9eb05bdfd5d7da + cbd0372a653c260ff2f0d06b7395c23ee.c65d45d1d6ce072b35a4de0618d52e24b(83888) + new StackFrame(0, true).GetFileLineNumber().ToString();
			}
		}

		public static bool c580cc30679ea46c66e53876cd2b41407()
		{
			return cb501ad6cdbf534367e1bef279bffbd03.c7f7d02723f1b4650bef3e788bc2603eb.Length > 0;
		}
	}
}
