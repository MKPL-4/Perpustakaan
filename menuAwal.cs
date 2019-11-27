using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekPPK2019
{
	public partial class menuAwal : Form

	{
		menuAwal m;
		peminjaman p = new peminjaman();
		 
		
		public menuAwal()
		{
			InitializeComponent();
			 
			

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void menuAwal_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			p.Show();
		}

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
