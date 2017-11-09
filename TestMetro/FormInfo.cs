using A;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TestMetro
{
	public class FormInfo : MetroForm
	{
		private IContainer c3428cd311a5a992405a2ec7e050b9758 = null;

		private MetroPanel c3d2e9f7159b8c08a59ada6a19410beb3;

		private MetroLabel c0a39639a6d378b9dbc95f32203d2b848;

		private MetroLabel c87048e824136fc9a972cc75bb5a04d9e;

		private MetroLabel cf3f4ed4aefdccf04418a2082d7a6af88;

		private MetroLabel c165892df15c1e6f7d4176f3aaa437fc1;

		private MetroLabel c429f19aaa5e36ea074c80bb11c318b5f;

		private MetroLabel c1f754ac88026488c1bbeb849da61afa6;

		private MetroLabel cae5d89d591ce19af4df074d0265b1c07;

		private MetroLabel c8a60a7de78ee61e8af9f6121e8045d4b;

		public FormInfo()
		{
			this.c80dca008c226c3b8c5a102239844619e();
		}

		private void c51eacc51a167765bde79aabfc6bd3817(object c3ed4d20323484c3c606ba7d732ac2604, EventArgs c9dc84a566fdd90c5cf8bf1965467062c)
		{
			this.c429f19aaa5e36ea074c80bb11c318b5f.Text = Environment.MachineName;
			this.c165892df15c1e6f7d4176f3aaa437fc1.Text = FormInfo.DoGetHostAddresses(Environment.MachineName);
			this.cf3f4ed4aefdccf04418a2082d7a6af88.Text = FormInfo.GetMACAddress2(this.c165892df15c1e6f7d4176f3aaa437fc1.Text);
			this.cae5d89d591ce19af4df074d0265b1c07.Text = Form1._Model;
			MessageBox.Show(Environment.OSVersion.ToString());
		}

		public static string DoGetHostAddresses(string hostname)
		{
			return Dns.GetHostByName(hostname).AddressList[0].ToString();
		}

		[DllImport("iphlpapi.dll", ExactSpelling = true)]
		public static extern int SendARP(int destIp, int srcIP, byte[] macAddr, ref uint physicalAddrLen);

		public static string GetMACAddress2(string IP)
		{
			IPAddress iPAddress = IPAddress.Parse(IP);
			byte[] array = new byte[6];
			uint num = (uint)array.Length;
			bool flag = FormInfo.SendARP(BitConverter.ToInt32(iPAddress.GetAddressBytes(), 0), 0, array, ref num) != 0;
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
					RuntimeMethodHandle arg_49_0 = methodof(FormInfo.GetMACAddress2(string)).MethodHandle;
				}
				throw new InvalidOperationException(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83702));
			}
			string[] array2 = new string[num];
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				array2[num2] = array[num2].ToString(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83733));
				num2++;
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
			return string.Join(c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83738), array2);
		}

		protected override void Dispose(bool disposing)
		{
			bool arg_23_0;
			if (disposing)
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
					RuntimeMethodHandle arg_16_0 = methodof(FormInfo.Dispose(bool)).MethodHandle;
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
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				this.c3428cd311a5a992405a2ec7e050b9758.Dispose();
			}
			base.Dispose(disposing);
		}

		private void c80dca008c226c3b8c5a102239844619e()
		{
			this.c3d2e9f7159b8c08a59ada6a19410beb3 = new MetroPanel();
			this.c0a39639a6d378b9dbc95f32203d2b848 = new MetroLabel();
			this.c87048e824136fc9a972cc75bb5a04d9e = new MetroLabel();
			this.cf3f4ed4aefdccf04418a2082d7a6af88 = new MetroLabel();
			this.c165892df15c1e6f7d4176f3aaa437fc1 = new MetroLabel();
			this.c429f19aaa5e36ea074c80bb11c318b5f = new MetroLabel();
			this.c1f754ac88026488c1bbeb849da61afa6 = new MetroLabel();
			this.c8a60a7de78ee61e8af9f6121e8045d4b = new MetroLabel();
			this.cae5d89d591ce19af4df074d0265b1c07 = new MetroLabel();
			this.c3d2e9f7159b8c08a59ada6a19410beb3.SuspendLayout();
			base.SuspendLayout();
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.cae5d89d591ce19af4df074d0265b1c07);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.c8a60a7de78ee61e8af9f6121e8045d4b);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.c0a39639a6d378b9dbc95f32203d2b848);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.c87048e824136fc9a972cc75bb5a04d9e);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.cf3f4ed4aefdccf04418a2082d7a6af88);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.c165892df15c1e6f7d4176f3aaa437fc1);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.c429f19aaa5e36ea074c80bb11c318b5f);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Controls.Add(this.c1f754ac88026488c1bbeb849da61afa6);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Dock = DockStyle.Fill;
			this.c3d2e9f7159b8c08a59ada6a19410beb3.HorizontalScrollbarBarColor = true;
			this.c3d2e9f7159b8c08a59ada6a19410beb3.HorizontalScrollbarHighlightOnWheel = false;
			this.c3d2e9f7159b8c08a59ada6a19410beb3.HorizontalScrollbarSize = 10;
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Location = new Point(20, 60);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83741);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.Size = new Size(521, 327);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.TabIndex = 0;
			this.c3d2e9f7159b8c08a59ada6a19410beb3.VerticalScrollbarBarColor = true;
			this.c3d2e9f7159b8c08a59ada6a19410beb3.VerticalScrollbarHighlightOnWheel = false;
			this.c3d2e9f7159b8c08a59ada6a19410beb3.VerticalScrollbarSize = 10;
			this.c0a39639a6d378b9dbc95f32203d2b848.AutoSize = true;
			this.c0a39639a6d378b9dbc95f32203d2b848.Location = new Point(13, 81);
			this.c0a39639a6d378b9dbc95f32203d2b848.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83778);
			this.c0a39639a6d378b9dbc95f32203d2b848.Size = new Size(196, 19);
			this.c0a39639a6d378b9dbc95f32203d2b848.TabIndex = 2;
			this.c0a39639a6d378b9dbc95f32203d2b848.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83801);
			this.c87048e824136fc9a972cc75bb5a04d9e.AutoSize = true;
			this.c87048e824136fc9a972cc75bb5a04d9e.Location = new Point(13, 48);
			this.c87048e824136fc9a972cc75bb5a04d9e.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83864);
			this.c87048e824136fc9a972cc75bb5a04d9e.Size = new Size(78, 19);
			this.c87048e824136fc9a972cc75bb5a04d9e.TabIndex = 2;
			this.c87048e824136fc9a972cc75bb5a04d9e.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83887);
			this.cf3f4ed4aefdccf04418a2082d7a6af88.AutoSize = true;
			this.cf3f4ed4aefdccf04418a2082d7a6af88.Location = new Point(222, 81);
			this.cf3f4ed4aefdccf04418a2082d7a6af88.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83912);
			this.cf3f4ed4aefdccf04418a2082d7a6af88.Size = new Size(116, 19);
			this.cf3f4ed4aefdccf04418a2082d7a6af88.TabIndex = 2;
			this.cf3f4ed4aefdccf04418a2082d7a6af88.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83939);
			this.c165892df15c1e6f7d4176f3aaa437fc1.AutoSize = true;
			this.c165892df15c1e6f7d4176f3aaa437fc1.Location = new Point(222, 48);
			this.c165892df15c1e6f7d4176f3aaa437fc1.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83970);
			this.c165892df15c1e6f7d4176f3aaa437fc1.Size = new Size(116, 19);
			this.c165892df15c1e6f7d4176f3aaa437fc1.TabIndex = 2;
			this.c165892df15c1e6f7d4176f3aaa437fc1.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83939);
			this.c429f19aaa5e36ea074c80bb11c318b5f.AutoSize = true;
			this.c429f19aaa5e36ea074c80bb11c318b5f.Location = new Point(222, 14);
			this.c429f19aaa5e36ea074c80bb11c318b5f.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83995);
			this.c429f19aaa5e36ea074c80bb11c318b5f.Size = new Size(116, 19);
			this.c429f19aaa5e36ea074c80bb11c318b5f.TabIndex = 2;
			this.c429f19aaa5e36ea074c80bb11c318b5f.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83939);
			this.c1f754ac88026488c1bbeb849da61afa6.AutoSize = true;
			this.c1f754ac88026488c1bbeb849da61afa6.Location = new Point(13, 14);
			this.c1f754ac88026488c1bbeb849da61afa6.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84040);
			this.c1f754ac88026488c1bbeb849da61afa6.Size = new Size(116, 19);
			this.c1f754ac88026488c1bbeb849da61afa6.TabIndex = 2;
			this.c1f754ac88026488c1bbeb849da61afa6.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83939);
			this.c8a60a7de78ee61e8af9f6121e8045d4b.AutoSize = true;
			this.c8a60a7de78ee61e8af9f6121e8045d4b.Location = new Point(13, 114);
			this.c8a60a7de78ee61e8af9f6121e8045d4b.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84063);
			this.c8a60a7de78ee61e8af9f6121e8045d4b.Size = new Size(50, 19);
			this.c8a60a7de78ee61e8af9f6121e8045d4b.TabIndex = 3;
			this.c8a60a7de78ee61e8af9f6121e8045d4b.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84086);
			this.cae5d89d591ce19af4df074d0265b1c07.AutoSize = true;
			this.cae5d89d591ce19af4df074d0265b1c07.Location = new Point(222, 114);
			this.cae5d89d591ce19af4df074d0265b1c07.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84099);
			this.cae5d89d591ce19af4df074d0265b1c07.Size = new Size(116, 19);
			this.cae5d89d591ce19af4df074d0265b1c07.TabIndex = 3;
			this.cae5d89d591ce19af4df074d0265b1c07.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(83939);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			base.ClientSize = new Size(561, 407);
			base.Controls.Add(this.c3d2e9f7159b8c08a59ada6a19410beb3);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Movable = false;
			base.Name = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84130);
			base.Resizable = false;
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = SizeGripStyle.Hide;
			this.Text = c0d07d609d29335644b7dbbe53fb10114.c631fb4bb3e507f4f0e6349aa5de37200(84147);
			base.Load += new EventHandler(this.c51eacc51a167765bde79aabfc6bd3817);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.ResumeLayout(false);
			this.c3d2e9f7159b8c08a59ada6a19410beb3.PerformLayout();
			base.ResumeLayout(false);
		}
	}
}
