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
	public partial class Form3Delegate : Form
	{

		//Declare a Delegate
		public delegate void DataBackEventHandler(object sender, int PersonID);

		//Declare an Event using the Delegate
		public event DataBackEventHandler DataBack;

		public Form3Delegate()
		{
			InitializeComponent();
		}

		private void btnSendDataBackToForm1_Click(object sender, EventArgs e)
		{
			int PersonID = int.Parse(txtPersonID.Text);

			//Trigger the event to send data back to form 1
			DataBack?.Invoke(this, PersonID);

			this.Close();
		}

		private void Form3Delegate_Load(object sender, EventArgs e)
		{

		}
	}
}
