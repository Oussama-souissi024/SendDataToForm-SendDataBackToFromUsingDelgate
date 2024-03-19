using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSendData_Click(object sender, EventArgs e)
        {

            int PersonID=-1;

            if (int.TryParse(txtPersonID1.Text, out PersonID))
            {
                Form frm = new SendData(PersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("PersonID should be a number!");
                txtPersonID1.Focus();
            }
        }

		private void btnOpenForm3_Click(object sender, EventArgs e)
		{
			Form3Delegate frm3 = new Form3Delegate();

			frm3.DataBack += Frm3_DataBack;

            frm3.ShowDialog();

		}

		private void Frm3_DataBack(object sender, int PersonID)
		{
			//Handel the data received from Form3Delegate
            txtPersonID2.Text = PersonID.ToString();
		}
	}
}
