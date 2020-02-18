using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDG_Tes102
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'database1DataSet.TB_CLIENTE' table. You can move, or remove it, as needed.
			this.tB_CLIENTETableAdapter.Fill(this.database1DataSet.TB_CLIENTE);
			// TODO: This line of code loads data into the 'database1DataSet.View' table. You can move, or remove it, as needed.
			this.viewTableAdapter.Fill(this.database1DataSet.View);

		}
	}
}
