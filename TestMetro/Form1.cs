using A;
using CefSharp;
using CefSharp.WinForms;
using EF;
using IpHlpApidotnet;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Drawing;
using MetroFramework.Forms;
using Microsoft.Win32;
using NetFwTypeLib;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TestMetro
{
	public class Form1 : MetroForm, ICookieManager, IDisposable, ICookieVisitor
	{
		public struct MARGINS
		{
			public int cxLeftWidth;

			public int cxRightWidth;

			public int cyBottomHeight;

			public int cyTopHeight;
		}

		private enum c782f3ac11f0cb74ab602154c5ec76769 : uint
		{
			c701c35c639aa12732ce2f7d1b017dadb,
			c5cf36b78128adeebf6556fe846d0a16f
		}

		public struct MODLLHOOKSTRUCT
		{
			public int dx;

			public int dy;

			public uint mouseData;

			public uint dwFlags;

			public uint time;

			public IntPtr dwExtraInfo;
		}

		private enum ceece2bd5a07c39a8cf01697d13378fd7
		{
			c0abfbd06405f31e54ca429b546ac2f1a = 513,
			c1f15bd23f5d775f17fea3844f31d029c,
			cbd67c3343a51b92528a23c581ad8d6ff = 512,
			c25d0a3f7329ac8a876a119fa43114847 = 522,
			cffeca6493ab805fd3826afd3badc6f81 = 516,
			c0b9dcbfc1292e83572fefa924dfec44f
		}

		private struct c332d33b8d3c43d457aafe75928dadb99
		{
			public Keys c981a74dad40bfd37bf51def99f9fa4b9;

			public int c3a0f0a3d56ed8c46b70fe2f8b7541bc6;

			public int c8ac9354f59eb399b63b6548682c3df35;

			public int c06a5d0a3c384f262e7756c3b37f944e5;

			public IntPtr c6098083845abf14d4ac6ad670c1bfde2;
		}

		private delegate IntPtr ce881d4012689ed47ea14280b6018eb32(int nCode, IntPtr wParam, IntPtr lParam);

		private delegate IntPtr c5ad2d9cf8087d85a7e15bc2163edffe5(int nCode, IntPtr wParam, IntPtr lParam);

		[CompilerGenerated]
		private sealed class c68b97403a49fc3162af641a8027a88fb
		{
			public bool c6477c03923e3638b670f3a451d0a36d0;

			public Form1 cf43b04534e2de0594338bc9ad7fd3bb8;

			internal void cd5bfdbc422badd57f28b0708f361c5bd()
			{
				this.cf43b04534e2de0594338bc9ad7fd3bb8.c3934c8bc4742c8476a099d04049ef5c2(this.c6477c03923e3638b670f3a451d0a36d0);
			}
		}

		private Thread c728e8fb065530ca9e0ee54cb92a6df2f;

		private Thread cbc2d6da61c999bb1ac8896e6b4512e9a;

		private Thread c0929750c5c1c178019964eb84613daca;

		private int c90825074a48d2cd2fffd8fd589ec2ac3 = 0;

		private int c147fe16ea3fe8802d3640245a46eb3cc = 0;

		private int c464a5e5055ffebabe6ac6c225b86d22f = 0;

		private string[] c2d2884a05e0bfa82d01d639d66f5dfcf = new string[]
		{
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3845),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(25545),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(32923),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(33781),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(36967),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(43985),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(48523),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(62133),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(63231),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(70897)
		};

		private string c736f7132e46d07293581b957fcea6e6f = "";

		private string cf4f8b3b97b4ab5a3c32dc8617a419578 = "";

		private string cf2a57801a38211749189624ee297a063 = "";

		private string c62781324a57f911e84a9c049babd30cc = "";

		public string _XYZ = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83323);

		private bool c6d6f2f4babf265760a6a82753ae049f7 = false;

		private string c8edfeda75036df1a5e8e0f6383b1171a = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83328);

		private string c6ce61e086bfb749b6e8c1ef189c117e5 = "";

		public static string _Model = "";

		private cb68214d339f81dad2024054b39412403 c3286fa06f8ae276786e225e91d1af497;

		private string c60c9e7d2bb1810541760f546a6b2ab13 = "";

		private string c1160a70462f40d9d5b96a71f0d4c71de = "";

		private IPHelper c0caf2549ab473c0dc49c61202761997d;

		private ChromiumWebBrowser c0e47669d9ffd2c244c10a6ae1eec57df;

		private string c0968cd41a9dc317f878c90d4207493a3 = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83355);

		private int cffc0d16d4efcc63fdc4be291ac5c7059 = 0;

		private int ceee64b70af61042ca7ba0f1a8e47ccde = 0;

		private int ceffc0047f6006a397acd0ecfa01df75d = 0;

		private string[] cb72cd135c8164a896f0ab3f370670c9b = new string[2];

		private int cddea84e16d5a6a4a45fec529a383a026 = 15;

		private IntPtr ce7d15def5d3259a1659fdd027a042bd6;

		private IntPtr c184e74e96094e0f2a95b29f65db4c30b;

		private int c517250b1761b0356af7d66de7023628c = 0;

		private Form1.ce881d4012689ed47ea14280b6018eb32 cab112a677d892f23ccac8bb26b8f0d7d;

		public string[] WPCs = new string[]
		{
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83432),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83477),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83526),
			c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83647)
		};

		private IContainer c3428cd311a5a992405a2ec7e050b9758 = null;

		private MetroPanel c2b1a968c825b45a2bdb85645e72f72a6;

		private MetroPanel c082c450a51760dc14921d7568a6f46d9;

		private MetroTile c703b8c3fc6f13b9f5378fcf54882074f;

		private PictureBox cce84080449f756b5a6589663d9ef6ea5;

		private PictureBox c16e465e6eb9c27470690056c0fc52449;

		private MetroTile c1ec7f9624edf7bf513de0e3208d48a22;

		private MetroTile cbb3fbfde589e08605aec9be60949612e;

		private MetroTile c1e9b2c35d731237eed49d56b6b930f10;

		private Label c8b9b89e708ac8cd466dfefdeced7472e;

		private Label cc7d16720697530a802c7c4f103756faa;

		private PictureBox c9cb43b594760e5e67e591cc88e7ab9e1;

		public Form1()
		{
			this.c80dca008c226c3b8c5a102239844619e();
			ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
			this.cab112a677d892f23ccac8bb26b8f0d7d = new Form1.ce881d4012689ed47ea14280b6018eb32(this.c99b61b2bdfd882e18b06a0f338706957);
			this.ce7d15def5d3259a1659fdd027a042bd6 = Form1.c05ddeec6a7c4bbf2d961388b4ee292db(13, this.cab112a677d892f23ccac8bb26b8f0d7d, Form1.c8c2ecfe64a6edac7a0c8c109b0a7186c(mainModule.ModuleName), 0u);
			MouseHook.Start();
			MouseHook.MouseAction += new EventHandler(this.c20708a454fd7cbe125571c3e4155bd92);
			this.c0caf2549ab473c0dc49c61202761997d = new IPHelper();
		}

		[DllImport("user32.dll", EntryPoint = "SetWindowDisplayAffinity")]
		private static extern bool c913eacc996cd5fe2544044355221d011(IntPtr c4e044947d17495826ea87f124536c5b1, Form1.c782f3ac11f0cb74ab602154c5ec76769 c1bc407476d081e10f58f383d48d55ae5);

		[DllImport("DwmApi.dll")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref Form1.MARGINS pMarInset);

		public void InitBrowser()
		{
			CefSettings cefSettings = new CefSettings();
			string path = Path.GetDirectoryName(Application.ExecutablePath) + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1);
			cefSettings.IgnoreCertificateErrors = true;
			Cef.Initialize(cefSettings);
			Cef.GetGlobalCookieManager().SetStoragePath(path, true, null);
			this.c0e47669d9ffd2c244c10a6ae1eec57df = new ChromiumWebBrowser(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(18));
			this.c0e47669d9ffd2c244c10a6ae1eec57df.Refresh();
			this.c082c450a51760dc14921d7568a6f46d9.Controls.Add(this.c0e47669d9ffd2c244c10a6ae1eec57df);
			this.c0e47669d9ffd2c244c10a6ae1eec57df.Dock = DockStyle.Fill;
			this.c0e47669d9ffd2c244c10a6ae1eec57df.LoadingStateChanged += new EventHandler<LoadingStateChangedEventArgs>(this.c83e1ea5c6c16231f1c12efd8a4cf3062);
			this.c0e47669d9ffd2c244c10a6ae1eec57df.FrameLoadStart += new EventHandler<FrameLoadStartEventArgs>(this.c13e9c25c2b4e5504534f1bd3bf4bab2c);
			this.c0e47669d9ffd2c244c10a6ae1eec57df.LoadError += new EventHandler<LoadErrorEventArgs>(this.ccc9887f77946336a1612df77a4e44724);
			this.c0e47669d9ffd2c244c10a6ae1eec57df.AddressChanged += new EventHandler<AddressChangedEventArgs>(this.cdfbdc20b23cd9823707eaef2135a4a65);
			this.c0e47669d9ffd2c244c10a6ae1eec57df.BringToFront();
			this.c0e47669d9ffd2c244c10a6ae1eec57df.BrowserSettings.Plugins = CefState.Enabled;
		}

		private void c13e9c25c2b4e5504534f1bd3bf4bab2c(object c3ed4d20323484c3c606ba7d732ac2604, FrameLoadStartEventArgs c13546ab4454ce53e0d6e592b742b0d9d)
		{
			this.ce18273d83fd4adf61b9cc3e9e0e348fe();
			this.c3934c8bc4742c8476a099d04049ef5c2(true);
		}

		private void c83e1ea5c6c16231f1c12efd8a4cf3062(object c3ed4d20323484c3c606ba7d732ac2604, LoadingStateChangedEventArgs c13546ab4454ce53e0d6e592b742b0d9d)
		{
			this.c3934c8bc4742c8476a099d04049ef5c2(false);
		}

		private void ccc9887f77946336a1612df77a4e44724(object c3ed4d20323484c3c606ba7d732ac2604, LoadErrorEventArgs c13546ab4454ce53e0d6e592b742b0d9d)
		{
			this.ce18273d83fd4adf61b9cc3e9e0e348fe();
		}

		private void cdfbdc20b23cd9823707eaef2135a4a65(object c3ed4d20323484c3c606ba7d732ac2604, AddressChangedEventArgs c13546ab4454ce53e0d6e592b742b0d9d)
		{
			bool flag = c13546ab4454ce53e0d6e592b742b0d9d.Address.Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83));
			if (flag)
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
					RuntimeMethodHandle arg_32_0 = methodof(Form1.cdfbdc20b23cd9823707eaef2135a4a65(object, AddressChangedEventArgs)).MethodHandle;
				}
				string[] array = c13546ab4454ce53e0d6e592b742b0d9d.Address.Split(new string[]
				{
					c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(100)
				}, StringSplitOptions.None);
				this.c6ce61e086bfb749b6e8c1ef189c117e5 = array[1].ToUpper();
				Form1.Write_Log(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(119) + this.c6ce61e086bfb749b6e8c1ef189c117e5);
				bool flag2 = this.c6d6f2f4babf265760a6a82753ae049f7;
				if (flag2)
				{
					this.c9a0cdf2868190bada8c91c4c84bc96a7();
				}
				else
				{
					this.cc29d414f6a596a6159d21fe090c040cf();
				}
			}
			else
			{
				this.ce18273d83fd4adf61b9cc3e9e0e348fe();
			}
			bool flag3 = c13546ab4454ce53e0d6e592b742b0d9d.Address.Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(134));
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
				this.c0e47669d9ffd2c244c10a6ae1eec57df.Load(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(18));
			}
			bool flag4 = c13546ab4454ce53e0d6e592b742b0d9d.Address.Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(143));
			if (flag4)
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
				this.c0e47669d9ffd2c244c10a6ae1eec57df.Load(this.cf2a57801a38211749189624ee297a063);
			}
		}

		private void c9a0cdf2868190bada8c91c4c84bc96a7()
		{
			bool invokeRequired = this.c8b9b89e708ac8cd466dfefdeced7472e.InvokeRequired;
			if (invokeRequired)
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
					RuntimeMethodHandle arg_24_0 = methodof(Form1.c9a0cdf2868190bada8c91c4c84bc96a7()).MethodHandle;
				}
				this.c8b9b89e708ac8cd466dfefdeced7472e.Invoke(new Action(this.c9a0cdf2868190bada8c91c4c84bc96a7));
			}
			else
			{
				this.c8b9b89e708ac8cd466dfefdeced7472e.Visible = true;
				this.c8b9b89e708ac8cd466dfefdeced7472e.Text = this.c6ce61e086bfb749b6e8c1ef189c117e5;
				bool flag = !this.c6ce61e086bfb749b6e8c1ef189c117e5.Trim().ToUpper().Contains(Environment.MachineName.Trim().ToUpper());
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
					this.c0e47669d9ffd2c244c10a6ae1eec57df.LoadHtml(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(224), false);
					this.c0e47669d9ffd2c244c10a6ae1eec57df.Refresh();
				}
			}
		}

		private void cc29d414f6a596a6159d21fe090c040cf()
		{
			bool invokeRequired = this.c8b9b89e708ac8cd466dfefdeced7472e.InvokeRequired;
			if (invokeRequired)
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
					RuntimeMethodHandle arg_24_0 = methodof(Form1.cc29d414f6a596a6159d21fe090c040cf()).MethodHandle;
				}
				this.c8b9b89e708ac8cd466dfefdeced7472e.Invoke(new Action(this.cc29d414f6a596a6159d21fe090c040cf));
			}
			else
			{
				this.c8b9b89e708ac8cd466dfefdeced7472e.Visible = true;
				this.c8b9b89e708ac8cd466dfefdeced7472e.Text = this.c6ce61e086bfb749b6e8c1ef189c117e5;
			}
		}

		private void ce18273d83fd4adf61b9cc3e9e0e348fe()
		{
			bool invokeRequired = this.cc7d16720697530a802c7c4f103756faa.InvokeRequired;
			if (invokeRequired)
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
					RuntimeMethodHandle arg_24_0 = methodof(Form1.ce18273d83fd4adf61b9cc3e9e0e348fe()).MethodHandle;
				}
				this.cc7d16720697530a802c7c4f103756faa.Invoke(new Action(this.ce18273d83fd4adf61b9cc3e9e0e348fe));
			}
			else
			{
				base.TopMost = false;
				bool flag = !FormInfo.DoGetHostAddresses(Environment.MachineName).ToString().Contains(this.c62781324a57f911e84a9c049babd30cc);
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
					this.cc7d16720697530a802c7c4f103756faa.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(796);
					this.cc7d16720697530a802c7c4f103756faa.Visible = true;
				}
				else
				{
					this.cc7d16720697530a802c7c4f103756faa.Visible = false;
				}
			}
		}

		private void c3934c8bc4742c8476a099d04049ef5c2(bool c6477c03923e3638b670f3a451d0a36d0)
		{
			Form1.c68b97403a49fc3162af641a8027a88fb c68b97403a49fc3162af641a8027a88fb = new Form1.c68b97403a49fc3162af641a8027a88fb();
			c68b97403a49fc3162af641a8027a88fb.cf43b04534e2de0594338bc9ad7fd3bb8 = this;
			c68b97403a49fc3162af641a8027a88fb.c6477c03923e3638b670f3a451d0a36d0 = c6477c03923e3638b670f3a451d0a36d0;
			bool invokeRequired = this.c9cb43b594760e5e67e591cc88e7ab9e1.InvokeRequired;
			if (invokeRequired)
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
					RuntimeMethodHandle arg_36_0 = methodof(Form1.c3934c8bc4742c8476a099d04049ef5c2(bool)).MethodHandle;
				}
				this.c9cb43b594760e5e67e591cc88e7ab9e1.Invoke(new Action(c68b97403a49fc3162af641a8027a88fb.cd5bfdbc422badd57f28b0708f361c5bd));
			}
			else
			{
				this.c9cb43b594760e5e67e591cc88e7ab9e1.Visible = c68b97403a49fc3162af641a8027a88fb.c6477c03923e3638b670f3a451d0a36d0;
			}
		}

		private void c64b3ffd23859f9ff3b1939c29e2c2e54(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			base.TopMost = false;
			FormInfo formInfo = new FormInfo();
			try
			{
				formInfo.ShowDialog();
			}
			finally
			{
				if (formInfo != null)
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
						RuntimeMethodHandle arg_31_0 = methodof(Form1.c64b3ffd23859f9ff3b1939c29e2c2e54(object, EventArgs)).MethodHandle;
					}
					((IDisposable)formInfo).Dispose();
				}
			}
		}

		private void cfc327b1ee97b08daecee394bd8b8b491(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c1ec7f9624edf7bf513de0e3208d48a22.BackColor = Color.Orange;
		}

		private void c2cee6c137fa122c67dcec288be8f6157(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c1ec7f9624edf7bf513de0e3208d48a22.BackColor = Color.White;
		}

		private void c0c5af32ec0de8fdb4bf30e792aa65422(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c0e47669d9ffd2c244c10a6ae1eec57df.Back();
			this.c0e47669d9ffd2c244c10a6ae1eec57df.Reload();
		}

		private void cbf9993e708205495646aa8fc589cdbc6(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c0e47669d9ffd2c244c10a6ae1eec57df.Forward();
			this.c0e47669d9ffd2c244c10a6ae1eec57df.Reload();
		}

		private void c67473200b492113432f90ecfc85fec1e(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c0e47669d9ffd2c244c10a6ae1eec57df.Reload();
		}

		private void c371039aadc4a8f08fb2035bf03087573(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c1e9b2c35d731237eed49d56b6b930f10.BackColor = Color.Orange;
		}

		private void c409aa4a8baddcf0b161242006f789ff8(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c1e9b2c35d731237eed49d56b6b930f10.BackColor = Color.White;
		}

		private void c9d37715264e56ff601c323154d7c7df6(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.cbb3fbfde589e08605aec9be60949612e.BackColor = Color.Orange;
		}

		private void c7d3b27ae62fd18877fbf8a907162b33b(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.cbb3fbfde589e08605aec9be60949612e.BackColor = Color.White;
		}

		private void c9d757a70e3f6d1815515bdc65bcf7275(object c3ed4d20323484c3c606ba7d732ac2604, FormClosingEventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			base.TopMost = false;
			bool flag = this.c464a5e5055ffebabe6ac6c225b86d22f == 0;
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
				if (!true)
				{
					RuntimeMethodHandle arg_2B_0 = methodof(Form1.c9d757a70e3f6d1815515bdc65bcf7275(object, FormClosingEventArgs)).MethodHandle;
				}
				DialogResult dialogResult = MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(825), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(886), MessageBoxButtons.YesNo);
				bool flag2 = dialogResult == DialogResult.Yes;
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
					MouseHook.stop();
					this.cbc2d6da61c999bb1ac8896e6b4512e9a.Abort();
					this.c728e8fb065530ca9e0ee54cb92a6df2f.Abort();
					this.c0929750c5c1c178019964eb84613daca.Abort();
					this.FirewallDefault();
				}
				else
				{
					bool flag3 = dialogResult == DialogResult.No;
					if (flag3)
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
						c9dc84a566fdd90c5cf8bf1965467062c.Cancel = true;
						base.OnClosing(c9dc84a566fdd90c5cf8bf1965467062c);
					}
				}
			}
			else
			{
				MouseHook.stop();
				this.cbc2d6da61c999bb1ac8896e6b4512e9a.Abort();
				this.c728e8fb065530ca9e0ee54cb92a6df2f.Abort();
				this.c0929750c5c1c178019964eb84613daca.Abort();
				this.FirewallDefault();
			}
		}

		private void cd6818606380d08da3c7cc614102adb70(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this._XYZ += this.cc7d16720697530a802c7c4f103756faa.Tag.ToString();
			this.c02e27ff0d64a3cc8dca473c5cf2e2184(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(895), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(910));
			Form1._Model = Form1.ExecuteCommandAsAdmin(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(935));
			bool arg_BA_0;
			if (!Form1._Model.ToString().ToUpper().Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(988)))
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
					RuntimeMethodHandle arg_99_0 = methodof(Form1.cd6818606380d08da3c7cc614102adb70(object, EventArgs)).MethodHandle;
				}
				arg_BA_0 = Form1._Model.ToString().Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1003));
			}
			else
			{
				arg_BA_0 = true;
			}
			bool flag = arg_BA_0;
			if (flag)
			{
				base.TopMost = false;
				bool flag2 = MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1018), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1101), MessageBoxButtons.OK) == DialogResult.OK;
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
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				}
				this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				Environment.Exit(0);
				Application.Exit();
			}
			Form1.Write_Log(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1116) + Environment.OSVersion.ToString());
			bool flag3 = !Environment.OSVersion.ToString().ToUpper().Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1147));
			if (flag3)
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
				base.TopMost = false;
				bool flag4 = MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1188), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1101), MessageBoxButtons.OK) == DialogResult.OK;
				if (flag4)
				{
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				}
				this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				Environment.Exit(0);
				Application.Exit();
			}
			this.FirewallDefault();
			try
			{
				ce736d0a2b8403aaf5a4e87b0ae304d49.c49f7ee845e792bfa59578ee3352e3d35(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1287), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1308), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1329), this._XYZ);
				bool flag5 = ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 != "";
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
					base.TopMost = false;
					MessageBox.Show(ce736d0a2b8403aaf5a4e87b0ae304d49.c1ac76fff79a880a4475b33636557db51 + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1338));
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
					Environment.Exit(0);
					Application.Exit();
					return;
				}
				Form1.Write_Log(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1397));
				DataTable dataTable = new DataTable();
				try
				{
					dataTable = ce736d0a2b8403aaf5a4e87b0ae304d49.cdd132a3050b31cc46bd3c884828e017f(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1436), new object[0]);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
					Environment.Exit(0);
					Application.Exit();
				}
				bool flag6 = dataTable.Columns.Count < 3;
				if (flag6)
				{
					Form1.Write_Log(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1475));
					base.TopMost = false;
					MessageBox.Show(dataTable.Rows[0][1].ToString());
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
					Environment.Exit(0);
					Application.Exit();
				}
				this.cddea84e16d5a6a4a45fec529a383a026 = int.Parse(dataTable.Rows[20][1].ToString());
				bool flag8;
				bool flag7 = bool.TryParse(dataTable.Rows[18][1].ToString(), out flag8);
				if (flag7)
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
					base.TopMost = flag8;
				}
				else
				{
					base.TopMost = false;
				}
				bool flag9 = bool.TryParse(dataTable.Rows[16][1].ToString(), out flag8);
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
					this.c6d6f2f4babf265760a6a82753ae049f7 = flag8;
				}
				else
				{
					this.c6d6f2f4babf265760a6a82753ae049f7 = false;
				}
				bool flag10 = bool.TryParse(dataTable.Rows[17][1].ToString(), out flag8);
				if (flag10)
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
					MouseHook.CheckkillP = flag8;
				}
				else
				{
					MouseHook.CheckkillP = false;
				}
				this.c62781324a57f911e84a9c049babd30cc = dataTable.Rows[0][1].ToString() + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1528) + dataTable.Rows[1][1].ToString() + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1528);
				this.cf2a57801a38211749189624ee297a063 = dataTable.Rows[12][1].ToString();
				string b = dataTable.Rows[11][2].ToString();
				bool flag11 = this.c8edfeda75036df1a5e8e0f6383b1171a != b;
				if (flag11)
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
					base.TopMost = false;
					Form1.Write_Log(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1531));
					MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1580));
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
					Environment.Exit(0);
					Application.Exit();
				}
			}
			catch (Exception ex2)
			{
				base.TopMost = false;
				MessageBox.Show(ex2.ToString());
				this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				Environment.Exit(0);
				Application.Exit();
			}
			base.WindowState = FormWindowState.Normal;
			base.FormBorderStyle = FormBorderStyle.None;
			base.Bounds = Screen.PrimaryScreen.Bounds;
			this.InitBrowser();
			this.FirewallBlock();
			this.Firewall(Application.ExecutablePath, c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1703), NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT);
			this.Firewall(Path.GetDirectoryName(Application.ExecutablePath) + c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1708), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1703), NET_FW_RULE_DIRECTION_.NET_FW_RULE_DIR_OUT);
			this.firewallcheck();
			this.cbc2d6da61c999bb1ac8896e6b4512e9a = new Thread(new ThreadStart(this.c5c4338cf586fb269d3f8e7fe42f7880c));
			this.cbc2d6da61c999bb1ac8896e6b4512e9a.IsBackground = true;
			this.cbc2d6da61c999bb1ac8896e6b4512e9a.Start();
			this.c728e8fb065530ca9e0ee54cb92a6df2f = new Thread(new ThreadStart(this.cb2cf024463ba1b38560025760fb816ba));
			this.c728e8fb065530ca9e0ee54cb92a6df2f.IsBackground = true;
			this.c728e8fb065530ca9e0ee54cb92a6df2f.Start();
			this.c0929750c5c1c178019964eb84613daca = new Thread(new ThreadStart(this.c7d6b37314bba3bbcd9ead0a877482a59));
			this.c0929750c5c1c178019964eb84613daca.IsBackground = true;
			this.c0929750c5c1c178019964eb84613daca.Start();
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			bool flag12 = !FormInfo.DoGetHostAddresses(Environment.MachineName).ToString().Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1771));
			if (flag12)
			{
				this.cc7d16720697530a802c7c4f103756faa.Visible = true;
			}
			this.c3286fa06f8ae276786e225e91d1af497 = new cb68214d339f81dad2024054b39412403();
			this.c3286fa06f8ae276786e225e91d1af497.c3c9b2ce27fa8d94826eff82d0574e862 += new KeyEventHandler(this.gHook_KeyDown);
			using (IEnumerator enumerator = Enum.GetValues(typeof(Keys)).GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Keys item = (Keys)enumerator.Current;
					this.c3286fa06f8ae276786e225e91d1af497.c151d47083d85cae542ad97ba9891496d.Add(item);
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
			this.c3286fa06f8ae276786e225e91d1af497.c0b377274dd642494427bf19a4e379eee();
			this.c736f7132e46d07293581b957fcea6e6f = WindowsIdentity.GetCurrent().Name;
			IntPtr handle = base.Handle;
			bool flag13 = Form1.c913eacc996cd5fe2544044355221d011(handle, Form1.c782f3ac11f0cb74ab602154c5ec76769.c5cf36b78128adeebf6556fe846d0a16f);
			bool flag14 = !flag13;
			if (flag14)
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
				base.TopMost = false;
				MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1784), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1853), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				base.TopMost = true;
				Form1.Write_Log(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1882));
				this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				Environment.Exit(0);
				Application.Exit();
			}
			DataTable dataTable2 = new DataTable();
			try
			{
				dataTable2 = ce736d0a2b8403aaf5a4e87b0ae304d49.cdd132a3050b31cc46bd3c884828e017f(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1931), new object[0]);
			}
			catch (Exception ex3)
			{
				MessageBox.Show(ex3.ToString());
				this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				Environment.Exit(0);
				Application.Exit();
			}
			int num = int.Parse(dataTable2.Rows[0][0].ToString());
			int num2 = int.Parse(dataTable2.Rows[0][1].ToString());
			int num3 = (num + num2) % 10;
			this.cce84080449f756b5a6589663d9ef6ea5.Image = this.Base64ToImage(this.c2d2884a05e0bfa82d01d639d66f5dfcf[num3].ToString());
		}

		public void RunCheckWPC()
		{
			while (true)
			{
				this.c02e27ff0d64a3cc8dca473c5cf2e2184(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(895), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(910));
				Thread.Sleep(2500);
			}
		}

		public void RunCheckWifi()
		{
			while (true)
			{
				bool flag = !Form1.CheckForInternetConnection();
				if (flag)
				{
					this.cc7d16720697530a802c7c4f103756faa.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1944);
					this.cc7d16720697530a802c7c4f103756faa.Visible = true;
					Form1.Write_Log(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1979));
					Thread.Sleep(5000);
				}
				else
				{
					this.cc7d16720697530a802c7c4f103756faa.Visible = false;
				}
				Thread.Sleep(5000);
			}
		}

		public static bool CheckForInternetConnection()
		{
			bool result;
			try
			{
				WebClient webClient = new WebClient();
				try
				{
					Stream stream = webClient.OpenRead(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2032));
					try
					{
						result = true;
					}
					finally
					{
						if (stream != null)
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
								RuntimeMethodHandle arg_37_0 = methodof(Form1.CheckForInternetConnection()).MethodHandle;
							}
							((IDisposable)stream).Dispose();
						}
					}
				}
				finally
				{
					if (webClient != null)
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
						((IDisposable)webClient).Dispose();
					}
				}
			}
			catch
			{
				result = false;
			}
			return result;
		}

		public void RunCheckSFW()
		{
			while (true)
			{
				this.firewallcheck();
				Thread.Sleep(2500);
			}
		}

		public static string EncodeTo64(string toEncode)
		{
			byte[] bytes = Encoding.ASCII.GetBytes(toEncode);
			return Convert.ToBase64String(bytes);
		}

		public static string DecodeFrom64(string encodedData)
		{
			byte[] bytes = Convert.FromBase64String(encodedData);
			return Encoding.ASCII.GetString(bytes);
		}

		public void gHook_KeyDown(object sender, KeyEventArgs e)
		{
			bool flag = e.KeyData.ToString() != c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2107);
			if (flag)
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
					RuntimeMethodHandle arg_42_0 = methodof(Form1.gHook_KeyDown(object, KeyEventArgs)).MethodHandle;
				}
				bool flag2 = this.ceffc0047f6006a397acd0ecfa01df75d == 0;
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
					this.cffc0d16d4efcc63fdc4be291ac5c7059 = 0;
					this.ceee64b70af61042ca7ba0f1a8e47ccde = 0;
				}
				this.ceffc0047f6006a397acd0ecfa01df75d = 0;
			}
			else
			{
				this.ceee64b70af61042ca7ba0f1a8e47ccde++;
				bool flag3 = this.ceee64b70af61042ca7ba0f1a8e47ccde > this.cddea84e16d5a6a4a45fec529a383a026 || this.ceee64b70af61042ca7ba0f1a8e47ccde == this.cddea84e16d5a6a4a45fec529a383a026;
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
					bool flag4 = this.cffc0d16d4efcc63fdc4be291ac5c7059 == 1;
					if (flag4)
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
						int num = this.ceee64b70af61042ca7ba0f1a8e47ccde - 1;
						for (int i = num; i < this.ceee64b70af61042ca7ba0f1a8e47ccde; i++)
						{
							this.ceffc0047f6006a397acd0ecfa01df75d = 1;
							e.Handled = true;
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
					else
					{
						bool flag5 = this.cffc0d16d4efcc63fdc4be291ac5c7059 == 0;
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
							for (int j = 0; j < this.ceee64b70af61042ca7ba0f1a8e47ccde; j++)
							{
								this.ceffc0047f6006a397acd0ecfa01df75d = 1;
								Form1.c628cf7e987e4bbb9b231e337a7eae90c(8, 0, 0u, UIntPtr.Zero);
								Form1.c628cf7e987e4bbb9b231e337a7eae90c(8, 0, 2u, UIntPtr.Zero);
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
							this.cffc0d16d4efcc63fdc4be291ac5c7059 = 1;
						}
					}
				}
			}
		}

		public string ImageToBase64(Image image, ImageFormat format)
		{
			MemoryStream memoryStream = new MemoryStream();
			string result;
			try
			{
				image.Save(memoryStream, format);
				byte[] inArray = memoryStream.ToArray();
				string text = Convert.ToBase64String(inArray);
				result = text;
			}
			finally
			{
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
					if (!true)
					{
						RuntimeMethodHandle arg_3C_0 = methodof(Form1.ImageToBase64(Image, ImageFormat)).MethodHandle;
					}
					((IDisposable)memoryStream).Dispose();
				}
			}
			return result;
		}

		public Image Base64ToImage(string base64String)
		{
			byte[] array = Convert.FromBase64String(base64String);
			MemoryStream memoryStream = new MemoryStream(array, 0, array.Length);
			memoryStream.Write(array, 0, array.Length);
			return Image.FromStream(memoryStream, true);
		}

		public static string Base64Encode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		public static string Base64Decode(string base64EncodedData)
		{
			byte[] bytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(bytes);
		}

		public byte[] ImageToByteArray(Image imageIn, int gif)
		{
			MemoryStream memoryStream = new MemoryStream();
			byte[] result;
			try
			{
				bool flag = gif == 0;
				if (flag)
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
						RuntimeMethodHandle arg_22_0 = methodof(Form1.ImageToByteArray(Image, int)).MethodHandle;
					}
					imageIn.Save(memoryStream, ImageFormat.Bmp);
				}
				else
				{
					imageIn.Save(memoryStream, ImageFormat.Gif);
				}
				result = memoryStream.ToArray();
			}
			finally
			{
				if (memoryStream != null)
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
					((IDisposable)memoryStream).Dispose();
				}
			}
			return result;
		}

		public Image byteArrayToImage(byte[] byteArrayIn)
		{
			MemoryStream stream = new MemoryStream(byteArrayIn);
			return Image.FromStream(stream);
		}

		public static string ExecuteCommandAsAdmin(string command)
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2120), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2127) + command);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			process.Start();
			return process.StandardOutput.ReadToEnd();
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
		private static extern IntPtr c05ddeec6a7c4bbf2d961388b4ee292db(int c56c09f8ecb74942ffb9f3be0db06d3b9, Form1.c5ad2d9cf8087d85a7e15bc2163edffe5 c95f12029c753ccf805b694132e554643, IntPtr c6b3572ce653125f7ea90b390882b91aa, uint cd6b915b0feec07dccc875043071e70a2);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SetWindowsHookEx", SetLastError = true)]
		private static extern IntPtr c05ddeec6a7c4bbf2d961388b4ee292db(int c56c09f8ecb74942ffb9f3be0db06d3b9, Form1.ce881d4012689ed47ea14280b6018eb32 c95f12029c753ccf805b694132e554643, IntPtr c6b3572ce653125f7ea90b390882b91aa, uint cd6b915b0feec07dccc875043071e70a2);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "UnhookWindowsHookEx", SetLastError = true)]
		private static extern bool c554d98576c0dd02a9bcfdb4017415872(IntPtr c0b377274dd642494427bf19a4e379eee);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "CallNextHookEx", SetLastError = true)]
		private static extern IntPtr cd2de35974097402192c4ddd752724c8a(IntPtr c0b377274dd642494427bf19a4e379eee, int c89eb5c42e848e03966cd2c102c78ef7f, IntPtr c7cf709062a0b26b7535500ba4c5fbd3c, IntPtr cebe33c2821b1102137f9a9b4d9fa8217);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "GetModuleHandle", SetLastError = true)]
		private static extern IntPtr c8c2ecfe64a6edac7a0c8c109b0a7186c(string c543c9d87b732886afab8a7a74ecaa2e1);

		[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "GetAsyncKeyState")]
		private static extern short cc6d8b2bcd9e3d380a6a8130c5a46e195(Keys c981a74dad40bfd37bf51def99f9fa4b9);

		[DllImport("user32.dll", EntryPoint = "keybd_event")]
		private static extern void c628cf7e987e4bbb9b231e337a7eae90c(byte c0aae410cb6fa4c768924208366a33fff, byte c7807d5255b2d96a01aaa396f396facb2, uint ce3c7b0e2f8ea2cbad2f42ba06daa5aa0, UIntPtr c2eb244748ff843562042980d2fd19cd1);

		private IntPtr c99b61b2bdfd882e18b06a0f338706957(int c89eb5c42e848e03966cd2c102c78ef7f, IntPtr c7cf709062a0b26b7535500ba4c5fbd3c, IntPtr cebe33c2821b1102137f9a9b4d9fa8217)
		{
			bool flag = c89eb5c42e848e03966cd2c102c78ef7f >= 0;
			IntPtr result;
			if (flag)
			{
				Form1.c332d33b8d3c43d457aafe75928dadb99 c332d33b8d3c43d457aafe75928dadb = (Form1.c332d33b8d3c43d457aafe75928dadb99)Marshal.PtrToStructure(cebe33c2821b1102137f9a9b4d9fa8217, typeof(Form1.c332d33b8d3c43d457aafe75928dadb99));
				Clipboard.Clear();
				bool flag2 = c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 == Keys.RWin || c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 == Keys.LWin;
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
					if (!true)
					{
						RuntimeMethodHandle arg_5D_0 = methodof(Form1.c99b61b2bdfd882e18b06a0f338706957(int, IntPtr, IntPtr)).MethodHandle;
					}
					result = (IntPtr)1;
					return result;
				}
				bool arg_B8_0;
				if (c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 != Keys.RMenu)
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
					if (c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 != Keys.LMenu && c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 != Keys.RControlKey)
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
						arg_B8_0 = (c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 == Keys.LControlKey);
						goto IL_B8;
					}
				}
				arg_B8_0 = true;
				IL_B8:
				bool flag3 = arg_B8_0;
				if (flag3)
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
					result = (IntPtr)1;
					return result;
				}
				bool arg_F5_0;
				if (c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 != Keys.Snapshot)
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
					arg_F5_0 = (c332d33b8d3c43d457aafe75928dadb.c981a74dad40bfd37bf51def99f9fa4b9 == Keys.Print);
				}
				else
				{
					arg_F5_0 = true;
				}
				bool flag4 = arg_F5_0;
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
					result = (IntPtr)1;
					return result;
				}
			}
			result = Form1.cd2de35974097402192c4ddd752724c8a(this.ce7d15def5d3259a1659fdd027a042bd6, c89eb5c42e848e03966cd2c102c78ef7f, c7cf709062a0b26b7535500ba4c5fbd3c, cebe33c2821b1102137f9a9b4d9fa8217);
			return result;
		}

		protected override void Dispose(bool disposing)
		{
			bool arg_23_0;
			if (disposing)
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
					RuntimeMethodHandle arg_16_0 = methodof(Form1.Dispose(bool)).MethodHandle;
				}
				arg_23_0 = (this.c3428cd311a5a992405a2ec7e050b9758 != null);
			}
			else
			{
				arg_23_0 = false;
			}
			bool flag = arg_23_0;
			if (flag)
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
				this.c3428cd311a5a992405a2ec7e050b9758.Dispose();
			}
			bool flag2 = this.ce7d15def5d3259a1659fdd027a042bd6 != IntPtr.Zero;
			if (flag2)
			{
				Form1.c554d98576c0dd02a9bcfdb4017415872(this.ce7d15def5d3259a1659fdd027a042bd6);
				this.ce7d15def5d3259a1659fdd027a042bd6 = IntPtr.Zero;
			}
			bool flag3 = this.c184e74e96094e0f2a95b29f65db4c30b != IntPtr.Zero;
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
				Form1.c554d98576c0dd02a9bcfdb4017415872(this.c184e74e96094e0f2a95b29f65db4c30b);
				this.c184e74e96094e0f2a95b29f65db4c30b = IntPtr.Zero;
			}
			base.Dispose(disposing);
		}

		private void c20708a454fd7cbe125571c3e4155bd92(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			base.TopMost = false;
			MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2134));
			base.TopMost = false;
			MessageBox.Show(c9dc84a566fdd90c5cf8bf1965467062c.ToString());
			base.TopMost = true;
		}

		private void cc60d94f496ebcafd837eec21b30063dd(string cee0ac2dd7716b1c39263d4d9f288a91a, string ca14813068184a71f191113d10ddc0ec5)
		{
			try
			{
				Process process = new Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(895);
				processStartInfo.Arguments = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2169) + ca14813068184a71f191113d10ddc0ec5;
				processStartInfo.Verb = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2176);
				process.StartInfo = processStartInfo;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				processStartInfo.CreateNoWindow = true;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				string text = process.StandardOutput.ReadToEnd().ToUpper();
				process.WaitForExit();
				bool flag = !text.Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2187));
				if (flag)
				{
					base.TopMost = false;
					MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1784), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2192), MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Application.Exit();
				}
			}
			catch (Exception var_4_100)
			{
				base.TopMost = false;
				MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1784), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2192), MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Application.Exit();
			}
		}

		private void c02e27ff0d64a3cc8dca473c5cf2e2184(string cee0ac2dd7716b1c39263d4d9f288a91a, string ca14813068184a71f191113d10ddc0ec5)
		{
			try
			{
				Process process = new Process();
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.FileName = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(895);
				processStartInfo.Arguments = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2169) + ca14813068184a71f191113d10ddc0ec5;
				processStartInfo.Verb = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2176);
				process.StartInfo = processStartInfo;
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.RedirectStandardError = true;
				processStartInfo.CreateNoWindow = true;
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				string text = process.StandardOutput.ReadToEnd().ToUpper();
				string text2 = process.StandardError.ReadToEnd();
				process.WaitForExit();
				bool flag = ca14813068184a71f191113d10ddc0ec5.Contains(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2213));
				if (flag)
				{
					int i = 0;
					while (i < this.WPCs.Length)
					{
						bool flag2 = text != string.Empty;
						if (flag2)
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
								RuntimeMethodHandle arg_123_0 = methodof(Form1.c02e27ff0d64a3cc8dca473c5cf2e2184(string, string)).MethodHandle;
							}
							bool flag3 = !text.ToUpper().Contains(this.WPCs[i]);
							if (!flag3)
							{
								goto IL_2E0;
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
							bool flag4 = i == this.WPCs.Length - 1;
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
								base.TopMost = false;
								this.c147fe16ea3fe8802d3640245a46eb3cc = 1;
								this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
								MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2222), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2321), MessageBoxButtons.OK, MessageBoxIcon.Hand);
								this.cc60d94f496ebcafd837eec21b30063dd(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(895), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2344));
								Environment.Exit(0);
								Application.Exit();
							}
						}
						else
						{
							bool flag5 = text2 != string.Empty;
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
								bool flag6 = !text2.ToUpper().Contains(this.WPCs[i]);
								if (!flag6)
								{
									goto IL_2E0;
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
								bool flag7 = i == this.WPCs.Length - 1;
								if (flag7)
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
									base.TopMost = false;
									this.c147fe16ea3fe8802d3640245a46eb3cc = 1;
									this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
									MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2222), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2321), MessageBoxButtons.OK, MessageBoxIcon.Hand);
									this.cc60d94f496ebcafd837eec21b30063dd(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(895), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2344));
									Environment.Exit(0);
									Application.Exit();
								}
							}
						}
						i++;
						continue;
						IL_2E0:
						goto IL_2E1;
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
				IL_2E1:;
			}
			catch (Exception var_13_2E4)
			{
				base.TopMost = false;
				MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(1784), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2321), MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		public void FirewallBlock()
		{
			try
			{
				Type typeFromProgID = Type.GetTypeFromProgID(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2391));
				INetFwPolicy2 netFwPolicy = (INetFwPolicy2)Activator.CreateInstance(typeFromProgID);
				netFwPolicy.RestoreLocalFirewallDefaults();
				netFwPolicy.set_DefaultOutboundAction(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE, NET_FW_ACTION_.NET_FW_ACTION_BLOCK);
				netFwPolicy.set_DefaultInboundAction(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE, NET_FW_ACTION_.NET_FW_ACTION_BLOCK);
			}
			catch
			{
				base.TopMost = false;
				MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2426), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2519));
				this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				Application.Exit();
			}
		}

		public void firewallcheck()
		{
			try
			{
				Type typeFromProgID = Type.GetTypeFromProgID(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2391));
				INetFwPolicy2 netFwPolicy = (INetFwPolicy2)Activator.CreateInstance(typeFromProgID);
				try
				{
					RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2542));
					bool flag = registryKey.GetValue(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2661)) != null;
					if (flag)
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
							RuntimeMethodHandle arg_69_0 = methodof(Form1.firewallcheck()).MethodHandle;
						}
						base.TopMost = false;
						MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2690), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2783));
						this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
						Environment.Exit(0);
						Application.Exit();
					}
				}
				catch
				{
				}
				int count = netFwPolicy.Rules.Count;
				NET_FW_ACTION_ nET_FW_ACTION_ = netFwPolicy.get_DefaultOutboundAction(NET_FW_PROFILE_TYPE2_.NET_FW_PROFILE2_PRIVATE);
				bool flag2 = nET_FW_ACTION_ > NET_FW_ACTION_.NET_FW_ACTION_BLOCK;
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
					base.TopMost = false;
					MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2806), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2899));
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
					Application.Exit();
				}
				bool flag3 = count > this.c90825074a48d2cd2fffd8fd589ec2ac3;
				if (flag3)
				{
					base.TopMost = false;
					MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2922), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3015));
					this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
					Application.Exit();
				}
			}
			catch (Exception var_8_15A)
			{
				base.TopMost = false;
				MessageBox.Show(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3038), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3131));
				this.c464a5e5055ffebabe6ac6c225b86d22f = 1;
				Application.Exit();
			}
		}

		public void FirewallDefault()
		{
			Type typeFromProgID = Type.GetTypeFromProgID(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2391));
			INetFwPolicy2 netFwPolicy = (INetFwPolicy2)Activator.CreateInstance(typeFromProgID);
			netFwPolicy.RestoreLocalFirewallDefaults();
		}

		public void Firewall(string localaddress, string rulename, NET_FW_RULE_DIRECTION_ inout)
		{
			Type typeFromProgID = Type.GetTypeFromProgID(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2391));
			INetFwPolicy2 netFwPolicy = (INetFwPolicy2)Activator.CreateInstance(typeFromProgID);
			int currentProfileTypes = netFwPolicy.CurrentProfileTypes;
			INetFwRule2 netFwRule = (INetFwRule2)Activator.CreateInstance(Type.GetTypeFromProgID(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3154)));
			netFwRule.Enabled = true;
			netFwRule.ApplicationName = localaddress;
			netFwRule.Profiles = currentProfileTypes;
			netFwRule.Action = NET_FW_ACTION_.NET_FW_ACTION_ALLOW;
			netFwRule.Direction = inout;
			netFwRule.Name = rulename;
			INetFwPolicy2 netFwPolicy2 = (INetFwPolicy2)Activator.CreateInstance(Type.GetTypeFromProgID(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(2391)));
			netFwPolicy2.Rules.Add(netFwRule);
			this.c90825074a48d2cd2fffd8fd589ec2ac3 = netFwPolicy2.Rules.Count;
		}

		public static void DisableTask(int TempVar)
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3183));
				bool flag = registryKey.GetValue(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3298)) == null;
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
					if (!true)
					{
						RuntimeMethodHandle arg_46_0 = methodof(Form1.DisableTask(int)).MethodHandle;
					}
					registryKey.SetValue(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3298), c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3327));
				}
				else
				{
					bool flag2 = TempVar == 1;
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
						registryKey.DeleteValue(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3298));
					}
				}
				registryKey.Close();
			}
			catch
			{
			}
		}

		public static void Write_Log(string _detail)
		{
			try
			{
				string text = FormInfo.DoGetHostAddresses(Environment.MachineName);
				string text2 = string.Concat(new object[]
				{
					DateTime.Now.Month,
					c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3330),
					DateTime.Now.Day,
					c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3330),
					DateTime.Now.Year
				});
				DataTable dataTable = ce736d0a2b8403aaf5a4e87b0ae304d49.cdd132a3050b31cc46bd3c884828e017f(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3333), new object[]
				{
					Environment.MachineName,
					text,
					text2,
					_detail
				});
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		public bool DeleteCookies(string url, string name, IDeleteCookiesCallback callback = null)
		{
			throw new NotImplementedException();
		}

		public bool SetCookie(string url, CefSharp.Cookie cookie, ISetCookieCallback callback = null)
		{
			throw new NotImplementedException();
		}

		public bool SetStoragePath(string path, bool persistSessionCookies, ICompletionCallback callback = null)
		{
			throw new NotImplementedException();
		}

		public void SetSupportedSchemes(string[] schemes, ICompletionCallback callback = null)
		{
			throw new NotImplementedException();
		}

		public bool VisitAllCookies(ICookieVisitor visitor)
		{
			throw new NotImplementedException();
		}

		public bool VisitUrlCookies(string url, bool includeHttpOnly, ICookieVisitor visitor)
		{
			throw new NotImplementedException();
		}

		public bool FlushStore(ICompletionCallback callback)
		{
			throw new NotImplementedException();
		}

		public bool Visit(CefSharp.Cookie cookie, int count, int total, ref bool deleteCookie)
		{
			throw new NotImplementedException();
		}

		private void c80dca008c226c3b8c5a102239844619e()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.c2b1a968c825b45a2bdb85645e72f72a6 = new MetroPanel();
			this.c1ec7f9624edf7bf513de0e3208d48a22 = new MetroTile();
			this.cbb3fbfde589e08605aec9be60949612e = new MetroTile();
			this.c1e9b2c35d731237eed49d56b6b930f10 = new MetroTile();
			this.c703b8c3fc6f13b9f5378fcf54882074f = new MetroTile();
			this.cce84080449f756b5a6589663d9ef6ea5 = new PictureBox();
			this.c16e465e6eb9c27470690056c0fc52449 = new PictureBox();
			this.c082c450a51760dc14921d7568a6f46d9 = new MetroPanel();
			this.c8b9b89e708ac8cd466dfefdeced7472e = new Label();
			this.cc7d16720697530a802c7c4f103756faa = new Label();
			this.c9cb43b594760e5e67e591cc88e7ab9e1 = new PictureBox();
			this.c2b1a968c825b45a2bdb85645e72f72a6.SuspendLayout();
			((ISupportInitialize)this.cce84080449f756b5a6589663d9ef6ea5).BeginInit();
			((ISupportInitialize)this.c16e465e6eb9c27470690056c0fc52449).BeginInit();
			((ISupportInitialize)this.c9cb43b594760e5e67e591cc88e7ab9e1).BeginInit();
			base.SuspendLayout();
			this.c2b1a968c825b45a2bdb85645e72f72a6.Controls.Add(this.c1ec7f9624edf7bf513de0e3208d48a22);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Controls.Add(this.cbb3fbfde589e08605aec9be60949612e);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Controls.Add(this.c1e9b2c35d731237eed49d56b6b930f10);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Controls.Add(this.c703b8c3fc6f13b9f5378fcf54882074f);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Controls.Add(this.cce84080449f756b5a6589663d9ef6ea5);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Controls.Add(this.c16e465e6eb9c27470690056c0fc52449);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Dock = DockStyle.Left;
			this.c2b1a968c825b45a2bdb85645e72f72a6.HorizontalScrollbarBarColor = true;
			this.c2b1a968c825b45a2bdb85645e72f72a6.HorizontalScrollbarHighlightOnWheel = false;
			this.c2b1a968c825b45a2bdb85645e72f72a6.HorizontalScrollbarSize = 10;
			this.c2b1a968c825b45a2bdb85645e72f72a6.Location = new Point(20, 60);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3356);
			this.c2b1a968c825b45a2bdb85645e72f72a6.Size = new Size(135, 649);
			this.c2b1a968c825b45a2bdb85645e72f72a6.TabIndex = 0;
			this.c2b1a968c825b45a2bdb85645e72f72a6.VerticalScrollbarBarColor = true;
			this.c2b1a968c825b45a2bdb85645e72f72a6.VerticalScrollbarHighlightOnWheel = false;
			this.c2b1a968c825b45a2bdb85645e72f72a6.VerticalScrollbarSize = 10;
			this.c1ec7f9624edf7bf513de0e3208d48a22.BackColor = Color.White;
			this.c1ec7f9624edf7bf513de0e3208d48a22.CustomBackground = true;
			this.c1ec7f9624edf7bf513de0e3208d48a22.Location = new Point(12, 430);
			this.c1ec7f9624edf7bf513de0e3208d48a22.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3385);
			this.c1ec7f9624edf7bf513de0e3208d48a22.Size = new Size(35, 34);
			this.c1ec7f9624edf7bf513de0e3208d48a22.TabIndex = 4;
			this.c1ec7f9624edf7bf513de0e3208d48a22.TileImage = c05a191f14159d42f3c64970f6518ae32.back_32;
			this.c1ec7f9624edf7bf513de0e3208d48a22.TileImageAlign = ContentAlignment.MiddleCenter;
			this.c1ec7f9624edf7bf513de0e3208d48a22.TileTextFontSize = MetroTileTextSize.Small;
			this.c1ec7f9624edf7bf513de0e3208d48a22.UseTileImage = true;
			this.c1ec7f9624edf7bf513de0e3208d48a22.Click += new EventHandler(this.c0c5af32ec0de8fdb4bf30e792aa65422);
			this.c1ec7f9624edf7bf513de0e3208d48a22.MouseLeave += new EventHandler(this.c2cee6c137fa122c67dcec288be8f6157);
			this.c1ec7f9624edf7bf513de0e3208d48a22.MouseHover += new EventHandler(this.cfc327b1ee97b08daecee394bd8b8b491);
			this.cbb3fbfde589e08605aec9be60949612e.BackColor = Color.White;
			this.cbb3fbfde589e08605aec9be60949612e.CustomBackground = true;
			this.cbb3fbfde589e08605aec9be60949612e.Location = new Point(53, 430);
			this.cbb3fbfde589e08605aec9be60949612e.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3412);
			this.cbb3fbfde589e08605aec9be60949612e.Size = new Size(35, 34);
			this.cbb3fbfde589e08605aec9be60949612e.TabIndex = 4;
			this.cbb3fbfde589e08605aec9be60949612e.TileImage = c05a191f14159d42f3c64970f6518ae32.next_32;
			this.cbb3fbfde589e08605aec9be60949612e.TileImageAlign = ContentAlignment.MiddleCenter;
			this.cbb3fbfde589e08605aec9be60949612e.UseTileImage = true;
			this.cbb3fbfde589e08605aec9be60949612e.Click += new EventHandler(this.cbf9993e708205495646aa8fc589cdbc6);
			this.cbb3fbfde589e08605aec9be60949612e.MouseLeave += new EventHandler(this.c7d3b27ae62fd18877fbf8a907162b33b);
			this.cbb3fbfde589e08605aec9be60949612e.MouseHover += new EventHandler(this.c9d37715264e56ff601c323154d7c7df6);
			this.c1e9b2c35d731237eed49d56b6b930f10.BackColor = Color.White;
			this.c1e9b2c35d731237eed49d56b6b930f10.Cursor = Cursors.Default;
			this.c1e9b2c35d731237eed49d56b6b930f10.CustomBackground = true;
			this.c1e9b2c35d731237eed49d56b6b930f10.Location = new Point(94, 430);
			this.c1e9b2c35d731237eed49d56b6b930f10.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3445);
			this.c1e9b2c35d731237eed49d56b6b930f10.Size = new Size(35, 34);
			this.c1e9b2c35d731237eed49d56b6b930f10.TabIndex = 4;
			this.c1e9b2c35d731237eed49d56b6b930f10.TileImage = c05a191f14159d42f3c64970f6518ae32.refresh_321;
			this.c1e9b2c35d731237eed49d56b6b930f10.TileImageAlign = ContentAlignment.MiddleCenter;
			this.c1e9b2c35d731237eed49d56b6b930f10.UseTileImage = true;
			this.c1e9b2c35d731237eed49d56b6b930f10.Click += new EventHandler(this.c67473200b492113432f90ecfc85fec1e);
			this.c1e9b2c35d731237eed49d56b6b930f10.MouseLeave += new EventHandler(this.c409aa4a8baddcf0b161242006f789ff8);
			this.c1e9b2c35d731237eed49d56b6b930f10.MouseHover += new EventHandler(this.c371039aadc4a8f08fb2035bf03087573);
			this.c703b8c3fc6f13b9f5378fcf54882074f.CustomBackground = true;
			this.c703b8c3fc6f13b9f5378fcf54882074f.CustomForeColor = true;
			this.c703b8c3fc6f13b9f5378fcf54882074f.Location = new Point(4, 301);
			this.c703b8c3fc6f13b9f5378fcf54882074f.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3476);
			this.c703b8c3fc6f13b9f5378fcf54882074f.Size = new Size(125, 104);
			this.c703b8c3fc6f13b9f5378fcf54882074f.TabIndex = 3;
			this.c703b8c3fc6f13b9f5378fcf54882074f.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3511);
			this.c703b8c3fc6f13b9f5378fcf54882074f.TileImage = c05a191f14159d42f3c64970f6518ae32.User;
			this.c703b8c3fc6f13b9f5378fcf54882074f.TileImageAlign = ContentAlignment.MiddleCenter;
			this.c703b8c3fc6f13b9f5378fcf54882074f.TileTextFontSize = MetroTileTextSize.Tall;
			this.c703b8c3fc6f13b9f5378fcf54882074f.TileTextFontWeight = MetroTileTextWeight.Regular;
			this.c703b8c3fc6f13b9f5378fcf54882074f.UseTileImage = true;
			this.c703b8c3fc6f13b9f5378fcf54882074f.Click += new EventHandler(this.c64b3ffd23859f9ff3b1939c29e2c2e54);
			this.cce84080449f756b5a6589663d9ef6ea5.Location = new Point(0, 151);
			this.cce84080449f756b5a6589663d9ef6ea5.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3538);
			this.cce84080449f756b5a6589663d9ef6ea5.Size = new Size(133, 144);
			this.cce84080449f756b5a6589663d9ef6ea5.SizeMode = PictureBoxSizeMode.StretchImage;
			this.cce84080449f756b5a6589663d9ef6ea5.TabIndex = 2;
			this.cce84080449f756b5a6589663d9ef6ea5.TabStop = false;
			this.c16e465e6eb9c27470690056c0fc52449.Location = new Point(3, 3);
			this.c16e465e6eb9c27470690056c0fc52449.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3561);
			this.c16e465e6eb9c27470690056c0fc52449.Size = new Size(129, 144);
			this.c16e465e6eb9c27470690056c0fc52449.SizeMode = PictureBoxSizeMode.StretchImage;
			this.c16e465e6eb9c27470690056c0fc52449.TabIndex = 2;
			this.c16e465e6eb9c27470690056c0fc52449.TabStop = false;
			this.c16e465e6eb9c27470690056c0fc52449.WaitOnLoad = true;
			this.c082c450a51760dc14921d7568a6f46d9.Dock = DockStyle.Fill;
			this.c082c450a51760dc14921d7568a6f46d9.HorizontalScrollbarBarColor = true;
			this.c082c450a51760dc14921d7568a6f46d9.HorizontalScrollbarHighlightOnWheel = false;
			this.c082c450a51760dc14921d7568a6f46d9.HorizontalScrollbarSize = 10;
			this.c082c450a51760dc14921d7568a6f46d9.Location = new Point(155, 60);
			this.c082c450a51760dc14921d7568a6f46d9.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3576);
			this.c082c450a51760dc14921d7568a6f46d9.Size = new Size(833, 649);
			this.c082c450a51760dc14921d7568a6f46d9.TabIndex = 0;
			this.c082c450a51760dc14921d7568a6f46d9.VerticalScrollbarBarColor = true;
			this.c082c450a51760dc14921d7568a6f46d9.VerticalScrollbarHighlightOnWheel = false;
			this.c082c450a51760dc14921d7568a6f46d9.VerticalScrollbarSize = 10;
			this.c8b9b89e708ac8cd466dfefdeced7472e.AutoSize = true;
			this.c8b9b89e708ac8cd466dfefdeced7472e.Font = new Font(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3611), 34f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.c8b9b89e708ac8cd466dfefdeced7472e.Location = new Point(161, 4);
			this.c8b9b89e708ac8cd466dfefdeced7472e.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3652);
			this.c8b9b89e708ac8cd466dfefdeced7472e.Size = new Size(47, 53);
			this.c8b9b89e708ac8cd466dfefdeced7472e.TabIndex = 1;
			this.c8b9b89e708ac8cd466dfefdeced7472e.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3681);
			this.cc7d16720697530a802c7c4f103756faa.AutoSize = true;
			this.cc7d16720697530a802c7c4f103756faa.Font = new Font(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3611), 16f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.cc7d16720697530a802c7c4f103756faa.ForeColor = Color.Red;
			this.cc7d16720697530a802c7c4f103756faa.Location = new Point(763, 17);
			this.cc7d16720697530a802c7c4f103756faa.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3686);
			this.cc7d16720697530a802c7c4f103756faa.Size = new Size(225, 26);
			this.cc7d16720697530a802c7c4f103756faa.TabIndex = 2;
			this.cc7d16720697530a802c7c4f103756faa.Tag = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3711);
			this.cc7d16720697530a802c7c4f103756faa.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3734);
			this.cc7d16720697530a802c7c4f103756faa.Visible = false;
			this.c9cb43b594760e5e67e591cc88e7ab9e1.Image = (Image)componentResourceManager.GetObject(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3777));
			this.c9cb43b594760e5e67e591cc88e7ab9e1.Location = new Point(703, 7);
			this.c9cb43b594760e5e67e591cc88e7ab9e1.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3804);
			this.c9cb43b594760e5e67e591cc88e7ab9e1.Size = new Size(54, 54);
			this.c9cb43b594760e5e67e591cc88e7ab9e1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.c9cb43b594760e5e67e591cc88e7ab9e1.TabIndex = 3;
			this.c9cb43b594760e5e67e591cc88e7ab9e1.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			base.BorderStyle = MetroBorderStyle.FixedSingle;
			base.ClientSize = new Size(1008, 729);
			base.Controls.Add(this.c9cb43b594760e5e67e591cc88e7ab9e1);
			base.Controls.Add(this.cc7d16720697530a802c7c4f103756faa);
			base.Controls.Add(this.c8b9b89e708ac8cd466dfefdeced7472e);
			base.Controls.Add(this.c082c450a51760dc14921d7568a6f46d9);
			base.Controls.Add(this.c2b1a968c825b45a2bdb85645e72f72a6);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3819);
			base.Resizable = false;
			base.Tag = "";
			this.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(3830);
			base.WindowState = FormWindowState.Maximized;
			base.FormClosing += new FormClosingEventHandler(this.c9d757a70e3f6d1815515bdc65bcf7275);
			base.Load += new EventHandler(this.cd6818606380d08da3c7cc614102adb70);
			this.c2b1a968c825b45a2bdb85645e72f72a6.ResumeLayout(false);
			((ISupportInitialize)this.cce84080449f756b5a6589663d9ef6ea5).EndInit();
			((ISupportInitialize)this.c16e465e6eb9c27470690056c0fc52449).EndInit();
			((ISupportInitialize)this.c9cb43b594760e5e67e591cc88e7ab9e1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		bool ICookieManager.cfdb180d762659e00d1f6b7228435a101()
		{
			return base.IsDisposed;
		}

		[CompilerGenerated]
		private void c5c4338cf586fb269d3f8e7fe42f7880c()
		{
			this.RunCheckSFW();
		}

		[CompilerGenerated]
		private void cb2cf024463ba1b38560025760fb816ba()
		{
			this.RunCheckWPC();
		}

		[CompilerGenerated]
		private void c7d6b37314bba3bbcd9ead0a877482a59()
		{
			this.RunCheckWifi();
		}
	}
}
