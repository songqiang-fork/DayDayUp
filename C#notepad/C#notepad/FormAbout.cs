using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CS_Note1
{
	/// <summary>
	/// FormAbout ��ժҪ˵����
	/// </summary>
	public class FormAbout : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button OK;
		/// <summary>
		/// ����������������
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormAbout()
		{
			//
			// Windows ���������֧���������
			//
			InitializeComponent();

			//
			// TODO: �� InitializeComponent ���ú�����κι��캯������
			//
		}

		/// <summary>
		/// ������������ʹ�õ���Դ��
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ������������ɵĴ���
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.OK = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(211, 190);
			this.label1.TabIndex = 1;
			// 
			// OK
			// 
			this.OK.BackColor = System.Drawing.SystemColors.Control;
			this.OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OK.Location = new System.Drawing.Point(81, 208);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(64, 20);
			this.OK.TabIndex = 2;
			this.OK.Text = "ȷ��";
			// 
			// FormAbout
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.BackColor = System.Drawing.SystemColors.Control;
			this.CancelButton = this.OK;
			this.ClientSize = new System.Drawing.Size(226, 234);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.Text = "���ڡ�JNote";
			this.Load += new System.EventHandler(this.FormAbout_Load);
			this.ResumeLayout(false);

		}
		#endregion

		private void FormAbout_Load(object sender, System.EventArgs e)
		{
			this.label1.Text = "         JNote V1.03\n            ncwu \n" +
				"\n��������κν�����߷�����BUG�뷢���� :" +
				"\n     cetacean_jy@163.com " + "\n     ��л��";
		}
	}
}
