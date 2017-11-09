using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace A
{
	internal class ce736d0a2b8403aaf5a4e87b0ae304d49
	{
		private static string c52c6e746e8fecc19b9b0339be3fa2f0c = "";

		public static string c1ac76fff79a880a4475b33636557db51 = "";

		public static string c8470635d19e1dd109ec8b49c0ab2ab06 = Process.GetCurrentProcess().ProcessName;

		public static SqlConnection c57569bf7a9dbed29ceeaf485719df314;

		public static string c6e56dd8ac4e9dbd5938506761aa7b90a = "";

		public static int c2103086e2e63355d8c1f5d8bd69b151d = 0;

		public static void c49f7ee845e792bfa59578ee3352e3d35(string ca9a3eef65082717013dfb0c2aba5ae7a, string cca0bdd920d8f70df42459906437ef46e, string c7fd52c6a0dfca27d14ed69b0792eefda = "", string c07cea6530659703cd377207c8cbaac54 = "")
		{
			ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = "";
			try
			{
				bool arg_3C_0;
				if (!(c7fd52c6a0dfca27d14ed69b0792eefda == ""))
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
						RuntimeMethodHandle arg_2B_0 = methodof(ce736d0a2b8403aaf5a4e87b0ae304d49.c49f7ee845e792bfa59578ee3352e3d35(string, string, string, string)).MethodHandle;
					}
					arg_3C_0 = (c07cea6530659703cd377207c8cbaac54 == "");
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
						switch (2)
						{
						case 0:
							continue;
						}
						break;
					}
					ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84179) + cca0bdd920d8f70df42459906437ef46e + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84319) + ca9a3eef65082717013dfb0c2aba5ae7a;
				}
				else
				{
					ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c = string.Concat(new string[]
					{
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84346),
						c07cea6530659703cd377207c8cbaac54,
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84365),
						c7fd52c6a0dfca27d14ed69b0792eefda,
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84490),
						cca0bdd920d8f70df42459906437ef46e,
						c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84319),
						ca9a3eef65082717013dfb0c2aba5ae7a
					});
				}
				SqlConnection sqlConnection = new SqlConnection(ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c);
				bool flag2 = sqlConnection.State == ConnectionState.Closed;
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
					sqlConnection.Open();
					ce736d0a2b8403aaf5a4e87b0ae304d49.c2103086e2e63355d8c1f5d8bd69b151d = 1;
				}
				sqlConnection.Close();
				SqlConnection.ClearPool(sqlConnection);
			}
			catch
			{
				ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 += new StackFrame(0, true).GetFileLineNumber().ToString();
			}
		}

		public static DataTable cdd132a3050b31cc46bd3c884828e017f(string c10fd2bfe3733448cc6171974258e30fc, params object[] ca305b39038c4219643e4aaa0170d93d7)
		{
			ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = "";
			DataTable dataTable = null;
			DataTable result;
			try
			{
				bool flag = ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c == "";
				if (flag)
				{
					ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
					throw new Exception(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84546));
				}
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(c10fd2bfe3733448cc6171974258e30fc, ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c);
				bool flag2 = sqlDataAdapter.SelectCommand.Connection.State == ConnectionState.Closed;
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
						RuntimeMethodHandle arg_A0_0 = methodof(ce736d0a2b8403aaf5a4e87b0ae304d49.cdd132a3050b31cc46bd3c884828e017f(string, object[])).MethodHandle;
					}
					sqlDataAdapter.SelectCommand.Connection.Open();
				}
				sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
				SqlCommandBuilder.DeriveParameters(sqlDataAdapter.SelectCommand);
				bool flag3 = sqlDataAdapter.SelectCommand.Parameters.Count - 1 != ca305b39038c4219643e4aaa0170d93d7.Length;
				if (flag3)
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
					ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
					throw new Exception(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84603));
				}
				int num = 0;
				try
				{
					IEnumerator enumerator = sqlDataAdapter.SelectCommand.Parameters.GetEnumerator();
					while (enumerator.MoveNext())
					{
						SqlParameter sqlParameter = (SqlParameter)enumerator.Current;
						bool arg_199_0;
						if (sqlParameter.Direction != ParameterDirection.Input)
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
							arg_199_0 = (sqlParameter.Direction == ParameterDirection.InputOutput);
						}
						else
						{
							arg_199_0 = true;
						}
						bool flag4 = arg_199_0;
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
							sqlParameter.Value = RuntimeHelpers.GetObjectValue(ca305b39038c4219643e4aaa0170d93d7[num]);
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
					ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
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
					ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
				}
				result = dataTable;
			}
			catch
			{
				result = dataTable;
			}
			return result;
		}

		public static void c5286f78cd038f60d7687a7a7593183ea(DataSet c47dbaf6736f4e5a8afd371fa75630e92, string c10fd2bfe3733448cc6171974258e30fc, params object[] ca305b39038c4219643e4aaa0170d93d7)
		{
			ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = "";
			bool flag = ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c == "";
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
					RuntimeMethodHandle arg_32_0 = methodof(ce736d0a2b8403aaf5a4e87b0ae304d49.c5286f78cd038f60d7687a7a7593183ea(DataSet, string, object[])).MethodHandle;
				}
				ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
				throw new Exception(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84546));
			}
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(c10fd2bfe3733448cc6171974258e30fc, ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c);
			bool flag2 = sqlDataAdapter.SelectCommand.Connection.State == ConnectionState.Closed;
			if (flag2)
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
				sqlDataAdapter.SelectCommand.Connection.Open();
			}
			sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
			SqlCommandBuilder.DeriveParameters(sqlDataAdapter.SelectCommand);
			bool flag3 = sqlDataAdapter.SelectCommand.Parameters.Count - 1 != ca305b39038c4219643e4aaa0170d93d7.Length;
			if (flag3)
			{
				ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
				throw new Exception(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84603));
			}
			int num = 0;
			try
			{
				IEnumerator enumerator = sqlDataAdapter.SelectCommand.Parameters.GetEnumerator();
				while (enumerator.MoveNext())
				{
					SqlParameter sqlParameter = (SqlParameter)enumerator.Current;
					bool arg_190_0;
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
						arg_190_0 = (sqlParameter.Direction == ParameterDirection.InputOutput);
					}
					else
					{
						arg_190_0 = true;
					}
					bool flag4 = arg_190_0;
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
						sqlParameter.Value = RuntimeHelpers.GetObjectValue(ca305b39038c4219643e4aaa0170d93d7[num]);
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
				ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
			}
			try
			{
				sqlDataAdapter.Fill(c47dbaf6736f4e5a8afd371fa75630e92, c10fd2bfe3733448cc6171974258e30fc);
				sqlDataAdapter.SelectCommand.Connection.Close();
				SqlConnection.ClearPool(sqlDataAdapter.SelectCommand.Connection);
				sqlDataAdapter.Dispose();
			}
			catch
			{
				ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 = ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84525) + new StackFrame(0, true).GetFileLineNumber().ToString();
			}
		}

		public static bool c83c94b4affe464807b7f3be6dc903b3a()
		{
			return ce736d0a2b8403aaf5a4e87b0ae304d49.c52c6e746e8fecc19b9b0339be3fa2f0c.Length > 0;
		}
	}
}
